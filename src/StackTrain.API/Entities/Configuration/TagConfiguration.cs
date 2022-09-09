using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTrain.API.Entities.Configuration
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasData(
                    new Tag() { Id = 1, Value = "Angular" },
                    new Tag() { Id = 2, Value = "Api" },
                    new Tag() { Id = 3, Value = "Csharp" },
                    new Tag() { Id = 4, Value = "TypeScipt" },
                    new Tag() { Id = 5, Value = "Azure" }
                    );
        }
    }
}
