using FluentValidation;
using LibraryBookAPI.Models.DTOs;

namespace LibraryBookAPI.Validations
{
    public class BookUpdateValidation : AbstractValidator<BookUpdateDTO>
    {
        public BookUpdateValidation()
        {
            RuleFor(model => model.BookName).NotEmpty();
            RuleFor(model => model.AuthorFirstname).NotEmpty();
            RuleFor(model => model.AuthorLastname).NotEmpty();
            RuleFor(model => model.AvailableForLoan).NotEmpty();

        }
    }
}
