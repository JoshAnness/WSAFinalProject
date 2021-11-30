using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSAFinalProject.Models
{
    public class DescriptionConfig : IEntityTypeConfiguration<Description>
    {
        public void Configure(EntityTypeBuilder<Description> entity)
        {
            entity.HasData(
                    new Description { DescriptionId = "1", DescriptionText = "A rescue crew investigates a spaceship that disappeared into a black hole and has now returned....with osmeone or something new on-board" },
                    new Description { DescriptionId = "2", DescriptionText = "A pragmatic paleontologist touring an almost complete theme park on an island in Central America is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose." }
                );
        }
    }
}
