using Microsoft.EntityFrameworkCore.Migrations;

namespace WSAFinalProject.Migrations
{
    public partial class Moviedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Description", "Duration", "GenreId", "Name", "Year" },
                values: new object[,]
                {
                    { 3, "Frank Abagnale, Jr. (Leonardo DiCaprio) worked as a doctor, a lawyer, and as a co-pilot for a major airline -- all before his 18th birthday. A master of deception, he was also a brilliant forger, whose skill gave him his first real claim to fame: At the age of 17, Frank Abagnale, Jr. became the most successful bank robber in the history of the U.S. FBI Agent Carl Hanratty (Tom Hanks) makes it his prime mission to capture Frank and bring him to justice, but Frank is always one step ahead of him.", 141, 6, "Catch me if you can", 2002 },
                    { 4, "South Boston cop Billy Costigan (Leonardo DiCaprio) goes under cover to infiltrate the organization of gangland chief Frank Costello (Jack Nicholson). As Billy gains the mobster's trust, a career criminal named Colin Sullivan (Matt Damon) infiltrates the police department and reports on its activities to his syndicate bosses. When both organizations learn they have a mole in their midst, Billy and Colin must figure out each other's identities to save their own lives.", 151, 6, "The Departed", 2006 },
                    { 5, "Captain John Miller (Tom Hanks) takes his men behind enemy lines to find Private James Ryan, whose three brothers have been killed in combat. Surrounded by the brutal realties of war, while searching for Ryan, each man embarks upon a personal journey and discovers their own strength to triumph over an uncertain future with honor, decency and courage.", 169, 6, "Saving Private Ryan", 1998 },
                    { 6, "On the way to a tryout with the Chicago Cubs, young baseball phenom Roy Hobbs (Robert Redford) is shot by the unstable Harriet Bird (Barbara Hershey). After 16 years, Hobbs returns to pro baseball as a rookie for the last-place New York Knights. Despite early arguments with his manager, Pop Fisher (Wilford Brimley), Hobbs becomes one of the best players in the league, and the Knights start winning. But this upsets the Judge (Robert Prosky), their owner, who wants Hobbs to lose games, not win.", 144, 3, "The Natural", 1984 },
                    { 7, "The culmination of nearly 10 years' work and conclusion to Peter Jackson's epic trilogy based on the timeless J.R.R. Tolkien classic, The Lord of the Rings: The Return of the King presents the final confrontation between the forces of good and evil fighting for control of the future of Middle-earth. Hobbits Frodo and Sam reach Mordor in their quest to destroy the `one ring', while Aragorn leads the forces of good against Sauron's evil army at the stone city of Minas Tirith.", 263, 6, "Lord of the Rings: Return of the King Extended Edition", 2003 },
                    { 8, "In the 14th century, the harmony that humans, animals and gods have enjoyed begins to crumble. The protagonist, young Ashitaka - infected by an animal attack, seeks a cure from the deer-like god Shishigami. In his travels, he sees humans ravaging the earth, bringing down the wrath of wolf god Moro and his human companion Princess Mononoke. Hiskattempts to broker peace between her and the humans brings only conflict.", 133, 6, "Princess Mononoke", 1997 },
                    { 9, "A teenage hacker finds himself framed for the theft of millions of dollars from a major corporation. Master hacker Dade Murphy, aka Zero Cool, aka Crash Override, has been banned from touching a keyboard for seven years after crashing over 1,500 Wall Street computers at the age of 11. Now keen to get back in front of a monitor, he finds himself in more trouble than ever.", 107, 6, "Hackers", 1995 },
                    { 10, "This acclaimed biographical drama presents major events in the life of Mohandas Gandhi (Ben Kingsley), the beloved Indian leader who stood against British rule over his country. Dedicated to the concept of nonviolent resistance, Gandhi is initially dismissed by English officials, including the influential Lord Irwin (John Gielgud), but eventually he and his cause become internationally renowned, and his gatherings of passive protest move India towards independence.", 191, 3, "Gandhi", 1982 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10);
        }
    }
}
