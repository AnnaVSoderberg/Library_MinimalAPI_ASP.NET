﻿using LibraryAPI.Models;

namespace LibraryBookAPI.Models.DTOs
{
    public class BookUpdateDTO
    {
        public int ID { get; set; }
        public string BookName { get; set; }
        public string AuthorFirstname { get; set; }
        public string AuthorLastname { get; set; }
        public Genre BookGenre { get; set; }
        public int YearOfPublication { get; set; }
        public bool AvailableForLoan { get; set; }
    }
}
