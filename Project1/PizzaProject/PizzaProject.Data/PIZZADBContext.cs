using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace PizzaProject.Data
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

        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Pizzas> Pizzas { get; set; }
        public virtual DbSet<Users> Users { get; set; }

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
            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("Locations", "Pizzas");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.Orderid);

                entity.ToTable("Orders", "Pizzas");

                entity.Property(e => e.Orderid).HasColumnName("ORDERID");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Pizzas>(entity =>
            {
                entity.HasKey(e => e.PizzaId);

                entity.ToTable("Pizzas", "Pizzas");

                entity.Property(e => e.PizzaId).HasColumnName("PizzaID");

                entity.Property(e => e.Cheese).HasDefaultValueSql("((1))");

                entity.Property(e => e.Large).HasDefaultValueSql("((0))");

                entity.Property(e => e.Medium).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pepperoni).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sauce).HasDefaultValueSql("((1))");

                entity.Property(e => e.Sausage).HasDefaultValueSql("((0))");

                entity.Property(e => e.Small).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Users", "Pizzas");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(128);
            });
        }
    }
}
