using LibraryAPI.Models;

namespace LibraryBookAPI.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book> GetAsync(int id);
        Task<Book> GetAsync(string bookName);
        Task CreateAsync (Book book);
        Task UpdateAsync (Book book);
        Task RemoveAsync (Book book);
        Task SaveAsync();

    }
}
