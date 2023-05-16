using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace CountryApp.Models
{
    public class MyProjectContext : DbContext
    {
        public MyProjectContext()
        {

        }

        public MyProjectContext(DbContextOptions<MyProjectContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Capital> Capitals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-3LCARMF;Initial Catalog=country_db;Integrated Security=True;TrustServerCertificate=True");
            }
        }

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
