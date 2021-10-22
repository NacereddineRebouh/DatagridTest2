using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DatagridTest2.EFramework
{
    public partial class DatagridTest2Context : DbContext
    {
        public DatagridTest2Context()
        {
        }

        public DatagridTest2Context(DbContextOptions<DatagridTest2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Filename=./DatagridTest2.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.HasIndex(e => e.ProductName, "IX_Product_ProductName")
                    .IsUnique();//creating non-Clustered Index(uses a secondary key) for ProductName Column

                entity.Property(e => e.BoughtFor)
                    .IsRequired()
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.ProductName).IsRequired();

                entity.Property(e => e.SoldFor)
                    .HasColumnType("NUMERIC")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Record>(entity =>
            {
                entity.ToTable("Record");

                entity.HasOne(d => d.Product)//one record has one product 
                    .WithMany(p => p.Records)//one product has one or many Records
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);//set productId(in Record) to null when the Product is deleted 

                entity.HasOne(d => d.User)//one record has one User (One seller) 
                    .WithMany(p => p.Records)//one User has one or many selling records
                    .HasForeignKey(d => d.SelledBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);//set selledBy(in Record) to null when the User is deleted 
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleName).IsRequired();
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("Team");

                entity.HasIndex(e => e.Leader, "IX_Team_Leader")
                    .IsUnique();

                entity.Property(e => e.MembersCount).HasDefaultValueSql("0");

                entity.Property(e => e.TotalContribution).HasDefaultValueSql("0");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Team)
                    .HasForeignKey<Team>(d => d.Leader)//i used the casting bcz it is mandatory to use it when creating one-to-one relationship.
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.Job).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.HasOne(d => d.Team)
                    .WithOne(p => p.User)
                    .HasForeignKey<User>(d => d.MemberOf)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
