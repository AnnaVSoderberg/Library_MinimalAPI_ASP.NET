using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryBookAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AuthorFirstname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AuthorLastname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BookGenre = table.Column<int>(type: "int", nullable: false),
                    YearOfPublication = table.Column<int>(type: "int", nullable: false),
                    AvailableForLoan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AuthorFirstname", "AuthorLastname", "AvailableForLoan", "BookGenre", "BookName", "YearOfPublication" },
                values: new object[,]
                {
                    { 1, "Simon", "Grenlang", false, 5, "Kalla Kårar Fotografen", 1995 },
                    { 2, "Anna", "Berg", true, 6, "Mörkrets Hjärta", 2001 },
                    { 3, "Erik", "Lund", true, 7, "Stjärnornas Krig", 2010 },
                    { 4, "Maria", "Nilsson", false, 1, "Historien om Oss", 1998 },
                    { 5, "Lars", "Johansson", true, 2, "Den Förlorade Staden", 2005 },
                    { 6, "Karin", "Svensson", false, 6, "Skräckens Hus", 2012 },
                    { 7, "Olof", "Andersson", true, 7, "Rymdens Hjältar", 2018 },
                    { 8, "Eva", "Karlsson", true, 4, "Livets Poesi", 1993 },
                    { 9, "Per", "Eriksson", false, 5, "Barnens Äventyr", 2000 },
                    { 10, "Sofia", "Larsson", true, 9, "Konstens Mästare", 2015 },
                    { 11, "Gustav", "Pettersson", false, 8, "Samhällets Spegel", 1997 },
                    { 12, "Helena", "Olsson", true, 7, "Fantasins Värld", 2003 },
                    { 13, "Fredrik", "Lind", false, 6, "Brott och Straff", 2011 },
                    { 14, "Ingrid", "Bengtsson", true, 2, "Historiska Hjältar", 2007 },
                    { 15, "Henrik", "Gustafsson", true, 1, "Livets Resa", 1999 },
                    { 16, "Linda", "Holm", false, 6, "Skräckens Natt", 2013 },
                    { 17, "Johan", "Sandberg", true, 7, "Rymdens Mysterier", 2019 },
                    { 18, "Annika", "Lundberg", true, 4, "Poesins Kraft", 1994 },
                    { 19, "Mats", "Hansson", false, 5, "Barnens Drömmar", 2001 },
                    { 20, "Elin", "Söderberg", true, 9, "Konstens Historia", 2016 },
                    { 21, "Nils", "Bergström", false, 8, "Samhällets Utveckling", 1998 },
                    { 22, "Kristina", "Ek", true, 7, "Fantasins Gränser", 2004 },
                    { 23, "Anders", "Lindgren", false, 6, "Brottets Skugga", 2012 },
                    { 24, "Monica", "Sjöberg", true, 2, "Historiska Äventyr", 2008 },
                    { 25, "Tommy", "Hedlund", true, 1, "Livets Berättelser", 2000 },
                    { 26, "Ulla", "Forsberg", false, 6, "Skräckens Tid", 2014 },
                    { 27, "Patrik", "Lindqvist", true, 7, "Rymdens Hemligheter", 2020 },
                    { 28, "Birgitta", "Nyström", true, 4, "Poesins Skönhet", 1995 },
                    { 29, "Oskar", "Sundström", false, 5, "Barnens Fantasi", 2002 },
                    { 30, "Margareta", "Lindholm", true, 9, "Konstens Under", 2017 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
