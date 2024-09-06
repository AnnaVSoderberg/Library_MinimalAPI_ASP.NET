using AutoMapper;
using LibraryAPI.Models;
using LibraryBookAPI.Models.DTOs;

namespace LibraryBookAPI
{
    public class MappingConfig :Profile
    {
        public MappingConfig()
        {
            CreateMap<Book, BookCreateDTO>().ReverseMap();  
            CreateMap<Book, BookUpdateDTO>().ReverseMap();
            CreateMap<Book, BookDTO>().ReverseMap();
        }
    }
}
