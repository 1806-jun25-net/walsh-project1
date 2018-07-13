using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaProject.Library
{
    public partial class PizzaPizzaDBContext : DbContext
    {
        public PizzaPizzaDBContext()
        {
        }

        public PizzaPizzaDBContext(DbContextOptions<PizzaPizzaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserTest> UserTest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:walsh-1806.database.windows.net,1433;Initial Catalog=PizzaPizzaDB;Persist Security Info=False;User ID=walsh;Password=Aw4215aw!@#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserTest>(entity =>
            {
                entity.HasKey(e => e.UsersId);

                entity.ToTable("UserTest", "Pizzas");

                entity.Property(e => e.UsersId).HasColumnName("UsersID");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(100);
            });
        }
    }
}
