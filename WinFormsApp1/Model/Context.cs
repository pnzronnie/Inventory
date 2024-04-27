using Microsoft.EntityFrameworkCore;
using System.Net;

namespace WinFormsApp1.Model
{
    internal class Context : DbContext
    {
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Master> Masters => Set<Master>();
        public DbSet<TypeTechnic> TypeTechnices => Set<TypeTechnic>();
        public DbSet<BrandTechnic> BrandTechnices => Set<BrandTechnic>();
        public DbSet<Order> Orders => Set<Order>();
        
        public DbSet<Details> Details => Set<Details>();

        public Context() => Database.EnsureCreatedAsync();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandTechnic>().HasIndex(n => n.NameBrandTechnic).IsUnique();
            modelBuilder.Entity<TypeTechnic>().HasIndex(n => n.NameTypeTechnic).IsUnique();

            modelBuilder.Entity<Order>()
                .HasOne(b => b.Master)
                .WithMany(a => a.Order)
                .HasForeignKey(b => b.MasterId);

            modelBuilder.Entity<Order>()
                .HasOne(b => b.Client)
                .WithMany(a => a.Order)
                .HasForeignKey(b => b.ClientId);

            modelBuilder.Entity<Order>()
                .HasOne(b => b.BrandTechnic)
                .WithMany(a => a.Order)
                .HasForeignKey(b => b.BrandTechnicId);

            modelBuilder.Entity<Order>()
                .HasOne(b => b.TypeTechnic)
                .WithMany(a => a.Order)
                .HasForeignKey(b => b.TypeTechnicId);

            /*modelBuilder.Entity<Order>()
                .HasOne(b => b.Details)
                .WithOne(a => a.Order)
                .HasForeignKey(b => b.)*/
 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=computerservice.db");
        }



    }
}
