using FluentValidation;
using LibraryAPI.Models;
using LibraryBookAPI.Models.DTOs;

namespace LibraryBookAPI.Validations
{
    public class BookCreateValidation : AbstractValidator<BookCreateDTO>
    {
        public BookCreateValidation() 
        {
            RuleFor(model => model.BookName).NotEmpty();
            RuleFor(model => model.AuthorFirstname).NotEmpty();
            RuleFor(model => model.AuthorLastname).NotEmpty();

        }
    }
}
