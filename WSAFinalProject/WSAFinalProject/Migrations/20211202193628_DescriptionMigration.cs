using Microsoft.EntityFrameworkCore.Migrations;

namespace WSAFinalProject.Migrations
{
    public partial class DescriptionMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "DescriptionId", "DescriptionText" },
                values: new object[] { 1, "A rescue crew investigates a spaceship that disappeared into a black hole and has now returned....with osmeone or something new on-board" });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "DescriptionId", "DescriptionText" },
                values: new object[] { 2, "A pragmatic paleontologist touring an almost complete theme park on an island in Central America is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Descriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "CastId", "DescriptionId", "Duration", "GenreId", "Name", "Year" },
                values: new object[] { 2, 2, 2, 127, 2, "Jurassic Park", 1993 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "CastId", "DescriptionId", "Duration", "GenreId", "Name", "Year" },
                values: new object[] { 1, 1, 1, 96, 2, "Event Horizon", 1997 });
        }
    }
}
