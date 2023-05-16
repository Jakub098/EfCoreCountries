using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace CountryApp.Models
{
    public class MyProjectContext : DbContext
    {

        public MyProjectContext(DbContextOptions<MyProjectContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Capital> Capitals { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(
                eb =>
                {
                    eb.Property(prop => prop.Id).HasColumnName("id_country");
                    eb.Property(prop => prop.Name).HasColumnName("countryName").HasColumnType("varchar(64)").IsRequired();
                    eb.HasOne(coun => coun.Capital)
                        .WithOne(cap => cap.Country)
                        .HasForeignKey<Capital>(cap => cap.CountryId);
                });

            modelBuilder.Entity<Capital>(
                eb =>
                {
                    eb.Property(prop => prop.Id).HasColumnName("id_capital");
                    eb.Property(prop => prop.Name).HasColumnName("capitalName").HasColumnType("varchar(64)").IsRequired();
                });

        }

    }
}
