using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoLibrary.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LookupGenres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    TmDbId = table.Column<int>(type: "int", nullable: true),
                    TheTvDbId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupGenres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LookupRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TmDbId = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    TheTvDbId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupRatings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    RatingId = table.Column<int>(type: "int", nullable: false),
                    Runtime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_LookupRatings_RatingId",
                        column: x => x.RatingId,
                        principalTable: "LookupRatings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenres",
                columns: table => new
                {
                    MovieGenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    LookupGenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenres", x => x.MovieGenreId);
                    table.ForeignKey(
                        name: "FK_MovieGenres_LookupGenres_LookupGenreId",
                        column: x => x.LookupGenreId,
                        principalTable: "LookupGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LookupGenres",
                columns: new[] { "Id", "Name", "Order", "TheTvDbId", "TmDbId" },
                values: new object[,]
                {
                    { 1, "Action", null, 19, 28 },
                    { 2, "Adventure", null, 18, 12 },
                    { 3, "Animation", null, 17, 16 },
                    { 4, "Science Fiction", null, 2, 878 },
                    { 5, "Horror", null, 6, 27 },
                    { 6, "Thriller", null, 24, 53 },
                    { 7, "Crime", null, 14, 80 },
                    { 8, "Fantasy", null, 10, 14 },
                    { 9, "Family", null, 11, 10751 },
                    { 10, "Comedy", null, 15, 35 },
                    { 11, "Documentary", null, 13, 99 },
                    { 12, "Sport", null, 21, null },
                    { 13, "Western", null, 26, 37 },
                    { 14, "Romance", null, 28, 10749 },
                    { 15, "Mystery", null, 31, 9648 },
                    { 16, "Musical", null, 29, 10402 },
                    { 17, "History", null, 33, 36 },
                    { 18, "War", null, 34, 10752 },
                    { 19, "Anime", null, 27, 16 },
                    { 20, "Martial Arts", null, 35, null }
                });

            migrationBuilder.InsertData(
                table: "LookupRatings",
                columns: new[] { "Id", "Description", "Name", "Order", "TheTvDbId", "TmDbId" },
                values: new object[,]
                {
                    { 1, "Suitable for all ages", "G", 1, 288, "G" },
                    { 2, "Parental guidance advised", "PG", 2, 289, "PG" },
                    { 3, "Parental guidance advised for viewers 14 or younger", "14A", 3, 290, "14A" },
                    { 4, "Parental guidance advised for viewers 18 or younger", "18A", 4, 291, "18A" },
                    { 5, "Restricted to viewers 18 years and over", "R", 5, 292, "R" },
                    { 6, "Restricted to viewers 18 years and over, sexually explicit content", "A", 6, 293, "A" },
                    { 7, "Exempt. Contains material not subject to classification such as documentaries, nature, travel, music, arts and culture, sports and educational and instructional information", "E", 7, 294, "E" },
                    { 8, "No rating information", "NR", 8, null, "NR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_LookupGenreId",
                table: "MovieGenres",
                column: "LookupGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_MovieId",
                table: "MovieGenres",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_RatingId",
                table: "Movies",
                column: "RatingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieGenres");

            migrationBuilder.DropTable(
                name: "LookupGenres");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "LookupRatings");
        }
    }
}
