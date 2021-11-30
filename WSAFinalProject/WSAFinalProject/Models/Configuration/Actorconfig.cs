using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSAFinalProject.Models
{
    public class Actorconfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> entity)
        {
            entity.HasData(
                    new Actor { ActorId = "1", Name = "Laurence Fishburne", BirthYear = "1961"},
                    new Actor { ActorId = "2", Name = "Sam Neil", BirthYear = "1947"},
                    new Actor { ActorId = "3", Name = "Kathleen Quinlan", BirthYear = "1954"},
                    new Actor { ActorId = "4", Name = "Laura Dern", BirthYear = "1967"},
                    new Actor { ActorId = "5", Name = "Jeff Goldblum", BirthYear = "1952"}
                );
        }
    }
}
