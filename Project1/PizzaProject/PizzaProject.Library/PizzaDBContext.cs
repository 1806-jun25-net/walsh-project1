using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaProject.Library
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
        public virtual DbSet<PizzaOrders> PizzaOrders { get; set; }
        public virtual DbSet<Pizzas> Pizzas { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
              
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
                    .HasConstraintName("FK_OrdersID");

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

                entity.Property(e => e.UsersId).HasColumnName("UsersID");

                entity.HasOne(d => d.LocationsNavigation)
                    .WithMany(p => p.OrdersNavigation)
                    .HasForeignKey(d => d.LocationsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationsID");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UsersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_UsersID");
            });

            modelBuilder.Entity<PizzaOrders>(entity =>
            {
                entity.HasKey(e => new { e.OrdersId, e.PizzasId });

                entity.ToTable("Pizza_Orders", "Pizzas");

                entity.Property(e => e.OrdersId).HasColumnName("OrdersID");

                entity.Property(e => e.PizzasId).HasColumnName("PizzasID");

                entity.HasOne(d => d.Orders)
                    .WithMany(p => p.PizzaOrders)
                    .HasForeignKey(d => d.OrdersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PO_OrdersID");

                entity.HasOne(d => d.Pizzas)
                    .WithMany(p => p.PizzaOrders)
                    .HasForeignKey(d => d.PizzasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PO_PizzasID");
            });

            modelBuilder.Entity<Pizzas>(entity =>
            {
                entity.ToTable("Pizzas", "Pizzas");

                entity.Property(e => e.PizzasId).HasColumnName("PizzasID");
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
            });
        }
    }
}
