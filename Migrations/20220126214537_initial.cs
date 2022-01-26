using Microsoft.EntityFrameworkCore.Migrations;

namespace mission4.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Peter Jackson", false, "", "", "PG-13", "Lord of the Rings: The Fellowship of the Ring", (ushort)2001 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action/Adventure", "Peter Jackson", false, "", "", "PG-13", "Lord of the Rings: The Two Towers", (ushort)2002 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "Peter Jackson", false, "", "", "PG-13", "Lord of the Rings: The Return of the King", (ushort)2002 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
