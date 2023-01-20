using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
using System.Collections.Generic;

#nullable disable

namespace NykaaDemoWeb.Data
{
    public partial class NykaaDemoContext : DbContext
    {
        public NykaaDemoContext()
        {
        }

        public NykaaDemoContext(DbContextOptions<NykaaDemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=USBLRANANYDHAR2\\MSSQLSERVER1;Database=NykaaDemo; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK__Category__6A1C8ADA962504B9");

                entity.ToTable("Category");

                entity.Property(e => e.CatId)
                    .ValueGeneratedNever()
                    .HasColumnName("CatID");

                entity.Property(e => e.CatName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TotalProductPrice).HasColumnType("money");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Order_Product");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrdersDetailsId);

                entity.Property(e => e.OrdersDetailsId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrdersDetailsID");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.TotalOrderPrice).HasColumnType("money");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderDetails_Order");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_OrderDetails_OrderDetails");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Product__C57755201B7CC5F5");

                entity.ToTable("Product");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("PID");

                entity.Property(e => e.Pbrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PBrand");

                entity.Property(e => e.Pdescription)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PDescription");

                entity.Property(e => e.Pimg)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("PImg");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PName");

                entity.Property(e => e.Pprice).HasColumnName("PPrice");

                entity.Property(e => e.ScatId).HasColumnName("SCatID");

                entity.HasOne(d => d.Scat)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ScatId)
                    .HasConstraintName("FK__Product__SCatID__32E0915F");
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.HasKey(e => e.ScatId)
                    .HasName("PK__SubCateg__57402CD95C25AEF7");

                entity.ToTable("SubCategory");

                entity.Property(e => e.ScatId)
                    .ValueGeneratedNever()
                    .HasColumnName("SCatID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.ScatName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SCatName");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.SubCategories)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK__SubCatego__CatID__300424B4");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.PassWrd)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserType)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        public Product GetProductsByProductName(string PName, out int status)
        {
            Product products = Products.FromSqlRaw("SelectPnameProc {0}", PName)
                .ToList()
                .FirstOrDefault();
            status = 1;
            return products;
        }
        public List<Product> GetProduct()
        {
            var product1 = Products.Select(e=>e.Pid) as List<Product>;
            return product1;
        }
    }
}
