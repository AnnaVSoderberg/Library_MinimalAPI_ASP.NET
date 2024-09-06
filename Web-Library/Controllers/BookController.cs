using LibraryBookAPI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Web_Library.Models;
using Web_Library.Services;

namespace Web_Library.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            this._bookService = bookService;
        }
        public async Task<IActionResult> BookIndex()
        {
            List<BookDTO> list = new List<BookDTO>();
            var respons = await _bookService.GetAllBooks<ResponsDto>();

            if (respons != null && respons.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<BookDTO>>(Convert.ToString(respons.Result));
            }
            return View(list);
        }


        public async Task<IActionResult> Details(int id)
        {
            BookDTO bDTO = new BookDTO();
            var response = await _bookService.GetBookById<ResponsDto>(id);
            if(response != null && response.IsSuccess)
            {
                BookDTO model = JsonConvert.DeserializeObject<BookDTO>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }

        public async Task<IActionResult> BookCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BookCreate(BookDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _bookService.CreateBookAsync<ResponsDto>(model);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(BookIndex));
                }
            }
            return View(model);
        }

        public async Task<IActionResult> UpdateBook(int bookid)
        {
            var response = await _bookService.GetBookById<ResponsDto>(bookid);
            if (response != null && response.IsSuccess)
            {
                BookDTO model = JsonConvert.DeserializeObject<BookDTO>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }
        
        [HttpPost]
        public async Task<IActionResult> UpdateBook(BookDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _bookService.UpdateBookAsync<ResponsDto>(model);
                if(response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(BookIndex));
                }
            }
            return View(model);
        }

        public async Task<IActionResult> DeleteBook(int bookid)
        {
            var response = await _bookService.GetBookById<ResponsDto>(bookid);
            if (response != null && response.IsSuccess)
            {
                BookDTO model = JsonConvert.DeserializeObject<BookDTO>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> DeleteBook(BookDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _bookService.DeleteBookAsync<ResponsDto>(model.ID);
                if(response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(BookIndex));
                }
            }
            return NotFound();
        }
               
    }
}
