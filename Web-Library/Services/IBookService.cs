﻿using LibraryBookAPI.Models.DTOs;

namespace Web_Library.Services
{
    public interface IBookService
    {
        Task<T> GetAllBooks<T>();

        Task<T> GetBookById<T>(int id);

        Task<T> CreateBookAsync<T>(BookDTO bookDTO);

        Task<T> UpdateBookAsync<T>(BookDTO bookDTO);

        Task<T> DeleteBookAsync<T>(int id);

    }
}
