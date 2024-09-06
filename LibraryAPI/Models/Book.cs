using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public enum Genre
    {
        Fiction,
        BiographiesAndMemoirs,
        HistoricalBooks,
        NonFiction,
        Poetry,
        ChildrensAndYoungAdultLiterature,
        CrimeAndThrillers,
        ScienceFictionAndFantasy,
        SocialSciences,
        ArtAndCulture,
    }
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string BookName { get; set; }
        [Required]
        [MaxLength(50)]
        public string AuthorFirstname { get; set; }
        [Required]
        [MaxLength(100)]
        public string AuthorLastname { get; set; }
        public Genre BookGenre { get; set; }
        [Required]
        public int YearOfPublication { get; set; }
        [Required]
        public bool AvailableForLoan { get; set; }
    }
}
