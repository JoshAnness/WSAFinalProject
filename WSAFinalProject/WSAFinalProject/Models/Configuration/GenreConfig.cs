using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSAFinalProject.Models
{
    public class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> entity)
        {
            entity.HasData(
                    new Genre { GenreId = "1", Name = "Horror" },
                    new Genre { GenreId = "2", Name = "SciFi" },
                    new Genre { GenreId = "3", Name = "Drama" },
                    new Genre { GenreId = "4", Name = "Comedy" },
                    new Genre { GenreId = "5", Name = "RomCom" },
                    new Genre { GenreId = "6", Name = "Action" },
                    new Genre { GenreId = "7", Name = "SuperHero" },
                    new Genre { GenreId = "8", Name = "Musical" },
                    new Genre { GenreId = "9", Name = "Documentary" }
                );
        }
    }
}
