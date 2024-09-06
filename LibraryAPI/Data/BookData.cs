using LibraryAPI.Models;

namespace LibraryBookAPI.Data
{
    public static class BookData
    {
        public static List<Book> bookList = new List<Book> 
        {
            new Book{ID = 101, BookName = "Kalla Kårar Fotografen", AuthorFirstname = "Simon", AuthorLastname ="Grenlang", BookGenre = Genre.ChildrensAndYoungAdultLiterature, AvailableForLoan = false, YearOfPublication = 1995},
            new Book{ID = 102, BookName = "Mörkrets Hjärta", AuthorFirstname = "Anna", AuthorLastname ="Berg", BookGenre = Genre.CrimeAndThrillers, AvailableForLoan = true, YearOfPublication = 2001},
            new Book{ID = 103, BookName = "Stjärnornas Krig", AuthorFirstname = "Erik", AuthorLastname ="Lund", BookGenre = Genre.ScienceFictionAndFantasy, AvailableForLoan = true, YearOfPublication = 2010},
            new Book{ID = 104, BookName = "Historien om Oss", AuthorFirstname = "Maria", AuthorLastname ="Nilsson", BookGenre = Genre.BiographiesAndMemoirs, AvailableForLoan = false, YearOfPublication = 1998},
            new Book{ID = 105, BookName = "Den Förlorade Staden", AuthorFirstname = "Lars", AuthorLastname ="Johansson", BookGenre = Genre.HistoricalBooks, AvailableForLoan = true, YearOfPublication = 2005},
            new Book{ID = 106, BookName = "Skräckens Hus", AuthorFirstname = "Karin", AuthorLastname ="Svensson", BookGenre = Genre.CrimeAndThrillers, AvailableForLoan = false, YearOfPublication = 2012},
            new Book{ID = 107, BookName = "Rymdens Hjältar", AuthorFirstname = "Olof", AuthorLastname ="Andersson", BookGenre = Genre.ScienceFictionAndFantasy, AvailableForLoan = true, YearOfPublication = 2018},
            new Book{ID = 108, BookName = "Livets Poesi", AuthorFirstname = "Eva", AuthorLastname ="Karlsson", BookGenre = Genre.Poetry, AvailableForLoan = true, YearOfPublication = 1993},
            new Book{ID = 109, BookName = "Barnens Äventyr", AuthorFirstname = "Per", AuthorLastname ="Eriksson", BookGenre = Genre.ChildrensAndYoungAdultLiterature, AvailableForLoan = false, YearOfPublication = 2000},
            new Book{ID = 110, BookName = "Konstens Mästare", AuthorFirstname = "Sofia", AuthorLastname ="Larsson", BookGenre = Genre.ArtAndCulture, AvailableForLoan = true, YearOfPublication = 2015},
            new Book{ID = 111, BookName = "Samhällets Spegel", AuthorFirstname = "Gustav", AuthorLastname ="Pettersson", BookGenre = Genre.SocialSciences, AvailableForLoan = false, YearOfPublication = 1997},
            new Book{ID = 112, BookName = "Fantasins Värld", AuthorFirstname = "Helena", AuthorLastname ="Olsson", BookGenre = Genre.ScienceFictionAndFantasy, AvailableForLoan = true, YearOfPublication = 2003},
            new Book{ID = 113, BookName = "Brott och Straff", AuthorFirstname = "Fredrik", AuthorLastname ="Lind", BookGenre = Genre.CrimeAndThrillers, AvailableForLoan = false, YearOfPublication = 2011},
            new Book{ID = 114, BookName = "Historiska Hjältar", AuthorFirstname = "Ingrid", AuthorLastname ="Bengtsson", BookGenre = Genre.HistoricalBooks, AvailableForLoan = true, YearOfPublication = 2007},
            new Book{ID = 115, BookName = "Livets Resa", AuthorFirstname = "Henrik", AuthorLastname ="Gustafsson", BookGenre = Genre.BiographiesAndMemoirs, AvailableForLoan = true, YearOfPublication = 1999},
            new Book{ID = 116, BookName = "Skräckens Natt", AuthorFirstname = "Linda", AuthorLastname ="Holm", BookGenre = Genre.CrimeAndThrillers, AvailableForLoan = false, YearOfPublication = 2013},
            new Book{ID = 117, BookName = "Rymdens Mysterier", AuthorFirstname = "Johan", AuthorLastname ="Sandberg", BookGenre = Genre.ScienceFictionAndFantasy, AvailableForLoan = true, YearOfPublication = 2019},
            new Book{ID = 118, BookName = "Poesins Kraft", AuthorFirstname = "Annika", AuthorLastname ="Lundberg", BookGenre = Genre.Poetry, AvailableForLoan = true, YearOfPublication = 1994},
            new Book{ID = 119, BookName = "Barnens Drömmar", AuthorFirstname = "Mats", AuthorLastname ="Hansson", BookGenre = Genre.ChildrensAndYoungAdultLiterature, AvailableForLoan = false, YearOfPublication = 2001},
            new Book{ID = 120, BookName = "Konstens Historia", AuthorFirstname = "Elin", AuthorLastname ="Söderberg", BookGenre = Genre.ArtAndCulture, AvailableForLoan = true, YearOfPublication = 2016},
            new Book{ID = 121, BookName = "Samhällets Utveckling", AuthorFirstname = "Nils", AuthorLastname ="Bergström", BookGenre = Genre.SocialSciences, AvailableForLoan = false, YearOfPublication = 1998},
            new Book{ID = 122, BookName = "Fantasins Gränser", AuthorFirstname = "Kristina", AuthorLastname ="Ek", BookGenre = Genre.ScienceFictionAndFantasy, AvailableForLoan = true, YearOfPublication = 2004},
            new Book{ID = 123, BookName = "Brottets Skugga", AuthorFirstname = "Anders", AuthorLastname ="Lindgren", BookGenre = Genre.CrimeAndThrillers, AvailableForLoan = false, YearOfPublication = 2012},
            new Book{ID = 124, BookName = "Historiska Äventyr", AuthorFirstname = "Monica", AuthorLastname ="Sjöberg", BookGenre = Genre.HistoricalBooks, AvailableForLoan = true, YearOfPublication = 2008},
            new Book{ID = 125, BookName = "Livets Berättelser", AuthorFirstname = "Tommy", AuthorLastname ="Hedlund", BookGenre = Genre.BiographiesAndMemoirs, AvailableForLoan = true, YearOfPublication = 2000},
            new Book{ID = 126, BookName = "Skräckens Tid", AuthorFirstname = "Ulla", AuthorLastname ="Forsberg", BookGenre = Genre.CrimeAndThrillers, AvailableForLoan = false, YearOfPublication = 2014},
            new Book{ID = 127, BookName = "Rymdens Hemligheter", AuthorFirstname = "Patrik", AuthorLastname ="Lindqvist", BookGenre = Genre.ScienceFictionAndFantasy, AvailableForLoan = true, YearOfPublication = 2020},
            new Book{ID = 128, BookName = "Poesins Skönhet", AuthorFirstname = "Birgitta", AuthorLastname ="Nyström", BookGenre = Genre.Poetry, AvailableForLoan = true, YearOfPublication = 1995},
            new Book{ID = 129, BookName = "Barnens Fantasi", AuthorFirstname = "Oskar", AuthorLastname ="Sundström", BookGenre = Genre.ChildrensAndYoungAdultLiterature, AvailableForLoan = false, YearOfPublication = 2002},
            new Book{ID = 130, BookName = "Konstens Under", AuthorFirstname = "Margareta", AuthorLastname ="Lindholm", BookGenre = Genre.ArtAndCulture, AvailableForLoan = true, YearOfPublication = 2017}
        };

    }
}
