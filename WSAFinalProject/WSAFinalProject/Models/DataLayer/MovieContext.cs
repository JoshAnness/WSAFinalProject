using Microsoft.EntityFrameworkCore;

namespace WSAFinalProject.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
           : base(options)
        { }

         public DbSet<Movie> Movies { get; set; }
         public DbSet<Genre> Genres { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GenreConfig());
            modelBuilder.ApplyConfiguration(new MovieConfig());
            

            modelBuilder.Entity<Genre>().HasMany(g => g.Movies).WithOne(m => m.Genre);
        }

    }
}
