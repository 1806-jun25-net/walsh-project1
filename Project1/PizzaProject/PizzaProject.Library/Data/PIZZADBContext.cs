using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaProject.Library
{
    public partial class PIZZADBContext : DbContext
    {
        public PIZZADBContext()
        {
        }

        public PIZZADBContext(DbContextOptions<PIZZADBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pizza> Pizza { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:walsh-1806.database.windows.net,1433;Initial Catalog=PIZZADB;Persist Security Info=False;User ID=walsh;Password=Aw4215aw!@#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.ToTable("Pizza", "Pizzas");

                entity.Property(e => e.PizzaId).HasColumnName("PizzaID");

                entity.Property(e => e.Cheese).HasDefaultValueSql("((1))");

                entity.Property(e => e.Large).HasDefaultValueSql("((0))");

                entity.Property(e => e.Medium).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pepperoni).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sauce).HasDefaultValueSql("((1))");

                entity.Property(e => e.Sausage).HasDefaultValueSql("((0))");

                entity.Property(e => e.Small).HasDefaultValueSql("((0))");
            });
        }
    }
}
