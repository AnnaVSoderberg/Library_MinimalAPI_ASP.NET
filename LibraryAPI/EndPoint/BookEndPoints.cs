using AutoMapper;
using LibraryAPI.Models;
using LibraryBookAPI.Data;
using LibraryBookAPI.Models;
using LibraryBookAPI.Models.DTOs;
using LibraryBookAPI.Repository;
using Microsoft.AspNetCore.Builder;

namespace LibraryBookAPI.EndPoint
{
    public static class BookEndPoints
    {
        public static void ConfigurationBookEndPoints(this WebApplication app)
        {
            app.MapGet("/api/books", GetAllBooks).WithName("GetBooks").Produces<APIResponse>();
            app.MapGet("/api/book/{id:int}", GetBook).WithName("GetBook").Produces<APIResponse>();
            app.MapPost("/api/book/", CreateBook).WithName("CreateBook").Accepts<BookCreateDTO>("application/Json").Produces<APIResponse>(201).Produces(400);
            app.MapPut("/api/book", UpdateBook).WithName("UpdateBook").Accepts<BookUpdateDTO>("application/json").Produces<APIResponse>(200).Produces(400);
            app.MapDelete("/api/book/{id:int}",DeleteBook).WithName("DeleteBook");
        }

        private async static Task<IResult> GetAllBooks(IBookRepository _bookrepo)
        {
            APIResponse response = new APIResponse();

            response.Result = await _bookrepo.GetAllAsync();
            response.IsSuccess = true;  
            response.StatusCode = System.Net.HttpStatusCode.OK;

            return Results.Ok(response);

        }

        private async static Task<IResult> GetBook(IBookRepository _bookrepo, int id)
        {
            APIResponse response = new APIResponse();

            response.Result = await _bookrepo.GetAsync(id);
            response.IsSuccess = true;
            response.StatusCode = System.Net.HttpStatusCode.OK;

            return Results.Ok(response);

        }

        private async static Task<IResult> CreateBook(IBookRepository _bookrepo, IMapper _mapper, BookCreateDTO book_c_DTO)
        {
            APIResponse response = new() { IsSuccess = false, StatusCode = System.Net.HttpStatusCode.BadRequest };

            if(_bookrepo.GetAsync(book_c_DTO.BookName).GetAwaiter().GetResult() != null)
            {
                response.ErrorMessages.Add("Book Name is already in database");
                return Results.BadRequest(response);
            }
            
            Book book = _mapper.Map<Book>(book_c_DTO);
            await _bookrepo.CreateAsync(book);
            await _bookrepo.SaveAsync();
            BookDTO bookDTO = _mapper.Map<BookDTO>(book);

            response.Result = bookDTO;
            response.IsSuccess = true;
            response.StatusCode= System.Net.HttpStatusCode.Created;

            return Results.Ok(response);
        }

        private async static Task<IResult> UpdateBook(IBookRepository _bookrepo, IMapper _mapper, BookUpdateDTO book_u_DTO)
        {
            APIResponse response = new() { IsSuccess =false, StatusCode = System.Net.HttpStatusCode.BadRequest };

            await _bookrepo.UpdateAsync(_mapper.Map<Book>(book_u_DTO));
            await _bookrepo.SaveAsync();

            response.Result = _mapper.Map<BookUpdateDTO>(await _bookrepo.GetAsync(book_u_DTO.ID));
            response.IsSuccess = true;
            response.StatusCode = System.Net.HttpStatusCode.OK;

            return Results.Ok(response);
        }

        private async static Task<IResult> DeleteBook(IBookRepository _bookrepo, int id)
        {
            APIResponse response = new() { IsSuccess = false, StatusCode = System.Net.HttpStatusCode.BadRequest };

            Book bookToDelete = await _bookrepo.GetAsync(id);
            if (bookToDelete != null)
            {
                await _bookrepo.RemoveAsync(bookToDelete);
                await _bookrepo.SaveAsync();
                response.IsSuccess=true;
                response.StatusCode=System.Net.HttpStatusCode.NoContent;

                return Results.Ok(response);
            }
            else
            {
                response.ErrorMessages.Add("Invalid ID");

                return Results.BadRequest(response);
            }
        }

    }
}
