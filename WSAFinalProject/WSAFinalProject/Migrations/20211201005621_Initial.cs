using Microsoft.EntityFrameworkCore.Migrations;

namespace WSAFinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Casts",
                columns: table => new
                {
                    CastId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casts", x => x.CastId);
                });

            migrationBuilder.CreateTable(
                name: "Descriptions",
                columns: table => new
                {
                    DescriptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptions", x => x.DescriptionId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    BirthYear = table.Column<string>(nullable: true),
                    CastId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorId);
                    table.ForeignKey(
                        name: "FK_Actors_Casts_CastId",
                        column: x => x.CastId,
                        principalTable: "Casts",
                        principalColumn: "CastId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    DescriptionId = table.Column<int>(nullable: false),
                    CastId = table.Column<int>(nullable: false),
                    ActorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movies_Casts_CastId",
                        column: x => x.CastId,
                        principalTable: "Casts",
                        principalColumn: "CastId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Descriptions_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Descriptions",
                        principalColumn: "DescriptionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "BirthYear", "CastId", "Name" },
                values: new object[,]
                {
                    { 1, "1961", null, "Laurence Fishburne" },
                    { 2, "1947", null, "Sam Neil" },
                    { 3, "1954", null, "Kathleen Quinlan" },
                    { 4, "1967", null, "Laura Dern" },
                    { 5, "1952", null, "Jeff Goldblum" }
                });

            migrationBuilder.InsertData(
                table: "Casts",
                column: "CastId",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "DescriptionId", "DescriptionText" },
                values: new object[,]
                {
                    { 2, "A pragmatic paleontologist touring an almost complete theme park on an island in Central America is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose." },
                    { 1, "A rescue crew investigates a spaceship that disappeared into a black hole and has now returned....with osmeone or something new on-board" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { 8, "Musical" },
                    { 1, "Horror" },
                    { 2, "SciFi" },
                    { 3, "Drama" },
                    { 4, "Comedy" },
                    { 5, "RomCom" },
                    { 6, "Action" },
                    { 7, "SuperHero" },
                    { 9, "Documentary" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "ActorId", "CastId", "DescriptionId", "Duration", "GenreId", "Name", "Year" },
                values: new object[] { 1, null, 1, 1, 96, 2, "Event Horizon", 1997 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "ActorId", "CastId", "DescriptionId", "Duration", "GenreId", "Name", "Year" },
                values: new object[] { 2, null, 2, 2, 127, 2, "Jurassic Park", 1993 });

            migrationBuilder.CreateIndex(
                name: "IX_Actors_CastId",
                table: "Actors",
                column: "CastId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ActorId",
                table: "Movies",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CastId",
                table: "Movies",
                column: "CastId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DescriptionId",
                table: "Movies",
                column: "DescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Descriptions");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Casts");
        }
    }
}
