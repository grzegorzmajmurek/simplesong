using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleSong.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlbumName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumName", "Author", "Length", "Title" },
                values: new object[] { 1, "Na legalu", "Rychu Peja", 3.2000000000000002, "Jest jedna rzecz" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumName", "Author", "Length", "Title" },
                values: new object[] { 2, "Tabasko", "OSTR", 2.5, "Kochana Polsko" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumName", "Author", "Length", "Title" },
                values: new object[] { 3, "Najwieksze przeboje", "Krzysztof Krawczyk", 3.4500000000000002, "Chcialem Byc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
