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
                    new Movie { MovieId = "1", Name = "Event Horizon", Year = 1997, GenreId = "2", Duration = 96, DescriptionId = "1", CastId = "1"},
                    new Movie { MovieId = "2", Name = "Jurassic Park", Year = 1993, GenreId = "2", Duration = 127, DescriptionId = "2", CastId = "2"}
                );
        }
    }
}
