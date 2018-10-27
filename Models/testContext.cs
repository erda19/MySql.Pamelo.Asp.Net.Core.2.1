using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace mysqlPamelo.Models
{
    public partial class testContext : DbContext
    {
        public testContext()
        {
        }

        public testContext(DbContextOptions<testContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pivot> Pivot { get; set; }

        // Unable to generate entity type for table 'table1'. Please see the warning messages.
        // Unable to generate entity type for table 'table2'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //             if (!optionsBuilder.IsConfigured)
            //             {
            // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //                 optionsBuilder.UseMySql("Server=localhost;Database=test;User=root;Password=erda19;");
            //             }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pivot>(entity =>
            {
                entity.ToTable("pivot");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Categoryid)
                    .HasColumnName("categoryid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Percentchange)
                    .HasColumnName("percentchange")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Processdate)
                    .HasColumnName("processdate")
                    .HasColumnType("date");
            });
        }
    }
}
