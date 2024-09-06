using LibraryAPI.Models;
using LibraryBookAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryBookAPI.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDBContext _db;
        public BookRepository(AppDBContext db)
        {
            _db = db;
        }
        public async Task CreateAsync(Book book)
        {
            _db.Books.AddAsync(book);
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _db.Books.ToListAsync();
        }

        public async Task<Book> GetAsync(int id)
        {
            return await _db.Books.FirstOrDefaultAsync(b => b.ID == id);
        }

        public async Task<Book> GetAsync(string bookName)
        {
            return await _db.Books.FirstOrDefaultAsync(b => b.BookName == bookName.ToLower());
        }

        public async Task RemoveAsync(Book book)
        {
                _db.Books.Remove(book);
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Book book)
        {
            _db.Books.Update(book);
        }
    }
}
