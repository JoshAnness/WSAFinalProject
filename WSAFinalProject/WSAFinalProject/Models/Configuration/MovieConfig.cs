using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSAFinalProject.Models
{
    public class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> entity)
        {
            entity.HasData(
                    new Movie { MovieId = 1, Name = "Event Horizon", Year = 1997, GenreId = 2, Duration = 96, Description = "A rescue crew investigates a spaceship that disappeared into a black hole and has now returned...with someone or something new on-board." },
                    new Movie { MovieId = 2, Name = "Jurassic Park", Year = 1993, GenreId = 2, Duration = 127, Description = "A pragmatic paleontologist touring an almost complete theme park on an island in Central America is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose." }
                );
        }
    }
}
