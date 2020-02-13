using Microsoft.EntityFrameworkCore;

namespace CombatReports.DAL.Models
{
    public partial class OrdersDbContext : DbContext
    {
        public OrdersDbContext()
        {
        }

        public OrdersDbContext(DbContextOptions<OrdersDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hash>(entity =>
            {
                entity.ToTable("HASH");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HashValue)
                    .IsRequired()
                    .HasColumnName("HASH_VALUE");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.ToTable("ORDERS");

                entity.HasIndex(e => e.FileName)
                    .HasName("UQ_FileName")
                    .IsUnique();

                entity.Property(e => e.FileData).IsRequired();

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
