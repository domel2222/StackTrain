using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTrain.API.Entities.Configuration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> eb)
        {
            eb.Property(x => x.Subject).HasColumnType("nvarchar(200)");
            eb.Property(x => x.Message).HasColumnType("nvarchar(3000)");

            eb.HasMany(a => a.Answers)
                .WithOne(x => x.Question)
                .HasForeignKey(x => x.QuestionId);

            eb.HasMany(c => c.Comments)
                .WithOne(x => x.Question)
                .HasForeignKey(x => x.QuestionId);

            eb.HasMany(x => x.Tags)
                .WithMany(x => x.Questions);    
        }
    }
}
