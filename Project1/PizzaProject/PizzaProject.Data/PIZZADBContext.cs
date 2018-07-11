using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaProject.Data
{
    public partial class PizzaDBContext : DbContext
    {
        public PizzaDBContext()
        {
        }

        public PizzaDBContext(DbContextOptions<PizzaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Pizzas> Pizzas { get; set; }
        public virtual DbSet<PizzaToppings> PizzaToppings { get; set; }
        public virtual DbSet<Toppings> Toppings { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:walsh-1806.database.windows.net,1433;Initial Catalog=PizzaDB;Persist Security Info=False;User ID=walsh;Password=Aw4215aw!@#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Locations>(entity =>
            {
                entity.ToTable("Locations", "Pizzas");

                entity.Property(e => e.LocationsId).HasColumnName("LocationsID");

                entity.Property(e => e.OrdersId).HasColumnName("OrdersID");

                entity.Property(e => e.UsersId).HasColumnName("UsersID");

                entity.HasOne(d => d.Orders)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.OrdersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_Locations_OrdersID");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.UsersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersID");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.ToTable("Orders", "Pizzas");

                entity.Property(e => e.OrdersId).HasColumnName("OrdersID");

                entity.Property(e => e.LocationsId).HasColumnName("LocationsID");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.PizzasId).HasColumnName("PizzasID");

                entity.Property(e => e.ToppingsId).HasColumnName("ToppingsID");

                entity.Property(e => e.UsersId).HasColumnName("UsersID");

                entity.HasOne(d => d.LocationsNavigation)
                    .WithMany(p => p.OrdersNavigation)
                    .HasForeignKey(d => d.LocationsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationsID");

                entity.HasOne(d => d.Pizzas)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PizzasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PizzasID");

                entity.HasOne(d => d.Toppings)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ToppingsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ToppingsID");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UsersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_UsersID");
            });

            modelBuilder.Entity<Pizzas>(entity =>
            {
                entity.ToTable("Pizzas", "Pizzas");

                entity.Property(e => e.PizzasId).HasColumnName("PizzasID");
            });

            modelBuilder.Entity<PizzaToppings>(entity =>
            {
                entity.HasKey(e => new { e.PizzasId, e.ToppingsId });

                entity.ToTable("Pizza_Toppings", "Pizzas");

                entity.Property(e => e.PizzasId).HasColumnName("PizzasID");

                entity.Property(e => e.ToppingsId).HasColumnName("ToppingsID");

                entity.HasOne(d => d.Pizzas)
                    .WithMany(p => p.PizzaToppings)
                    .HasForeignKey(d => d.PizzasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pizzas");

                entity.HasOne(d => d.Toppings)
                    .WithMany(p => p.PizzaToppings)
                    .HasForeignKey(d => d.ToppingsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Toppings");
            });

            modelBuilder.Entity<Toppings>(entity =>
            {
                entity.ToTable("Toppings", "Pizzas");

                entity.Property(e => e.ToppingsId).HasColumnName("ToppingsID");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users", "Pizzas");

                entity.Property(e => e.UsersId).HasColumnName("UsersID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LocationsId).HasColumnName("LocationsID");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.LocationsNavigation)
                    .WithMany(p => p.UsersNavigation)
                    .HasForeignKey(d => d.LocationsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_Users_Locations");
            });
        }
    }
}
