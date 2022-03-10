using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore.Migrations
{
    public partial class new4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 2, "JK Rowling", "Fantasy +", "Action", "0590353405", 145, 20.010000000000002, "Commonhouse Publishing", "Harry Potter and the Twlilight Princess" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 3, "Trashy Bashy", "Romance", "Romance", "0570353405", 1, 300.44999999999999, "Strangehouse Publishing", "50 Shades of Trash" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 3);
        }
    }
}
