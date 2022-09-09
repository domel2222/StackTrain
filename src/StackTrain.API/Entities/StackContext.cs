using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTrain.API.Entities
{
    public class StackContext : DbContext
    {
        public StackContext(DbContextOptions<StackContext> optionsBuilder) : base(optionsBuilder)
        {

        }

        public DbSet<Answer> Ansewrs { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Rate> Rates { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>(eb =>
            {
                eb.Property(x => x.Message).HasColumnType("nvarchar(5000)");

                eb.HasOne(x => x.Rate)
                        .WithOne(x => x.Answer)
                        .HasForeignKey<Rate>(x => x.AnswerId);
            });
        }

    }
}
