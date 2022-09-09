using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTrain.API.Entities.Configuration
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> eb)
        {
            eb.Property(x => x.Message).HasColumnType("nvarchar(5000)");

            eb.HasOne(x => x.Rate)
                    .WithOne(x => x.Answer)
                    .HasForeignKey<Rate>(x => x.AnswerId);

            eb.HasMany(x => x.Comments)
                .WithOne(c => c.Answer)
                .HasForeignKey(c => c.AnswerId);
        }
    }
}
