using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSAFinalProject.Models
{
    public class CastConfig : IEntityTypeConfiguration<Cast>
    {
        public void Configure(EntityTypeBuilder<Cast> entity)
        {
            entity.HasData(
                new Cast { CastId = 1 },
                new Cast { CastId = 2 }
            );
        }
    }
}
