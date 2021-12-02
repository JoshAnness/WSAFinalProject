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
         public DbSet<Description> Descriptions { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cast> Casts { get; set; }

        public DbSet<ActorMovie> ActorMovies { get; set; }

        //public DbSet<ActorCast> ActorCasts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Actorconfig());
            modelBuilder.ApplyConfiguration(new DescriptionConfig());
            modelBuilder.ApplyConfiguration(new GenreConfig());
            modelBuilder.ApplyConfiguration(new MovieConfig());
            modelBuilder.ApplyConfiguration(new CastConfig());
            

            modelBuilder.Entity<Genre>().HasMany(g => g.Movies).WithOne(m => m.Genre);
            modelBuilder.Entity<Cast>().HasOne(c => c.Movie).WithOne(m => m.Cast);
            modelBuilder.Entity<Description>().HasOne(d => d.Movie).WithOne(m => m.Description);

            modelBuilder.Entity<ActorMovie>().HasKey(am => new { am.ActorId, am.MovieId });
            modelBuilder.Entity<ActorMovie>().HasOne(am => am.Actor).WithMany(a => a.ActorMovies).HasForeignKey(am => am.ActorId);
            modelBuilder.Entity<ActorMovie>().HasOne(am => am.Movie).WithMany(m => m.ActorMovies).HasForeignKey(am => am.MovieId);

        }

    }
}
