using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Core.Entities.Models;

namespace OnlineStore.DAL.Context;

public partial class EShopDbContext : DbContext
{
    public EShopDbContext()
    {
    }

    public EShopDbContext(DbContextOptions<EShopDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddressesUser> AddressesUsers { get; set; }

    public virtual DbSet<Feature> Features { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductComment> ProductComments { get; set; }

    public virtual DbSet<ProductCount> ProductCounts { get; set; }

    public virtual DbSet<ProductFeature> ProductFeatures { get; set; }

    public virtual DbSet<ProductGallery> ProductGalleries { get; set; }

    public virtual DbSet<ProductGroup> ProductGroups { get; set; }

    public virtual DbSet<ProductInventory> ProductInventories { get; set; }

    public virtual DbSet<ProductSelectGroup> ProductSelectGroups { get; set; }

    public virtual DbSet<ProductTag> ProductTags { get; set; }

    public virtual DbSet<Rolse> Rolses { get; set; }

    public virtual DbSet<Seller> Sellers { get; set; }

    public virtual DbSet<ShippingMethod> ShippingMethods { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-EQ9BSEQ;Initial Catalog=EShop_DB;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddressesUser>(entity =>
        {
            entity.HasKey(e => e.AddressId);

            entity.ToTable("AddressesUser");

            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.Alley).HasMaxLength(400);
            entity.Property(e => e.Avenue).HasMaxLength(400);
            entity.Property(e => e.City).HasMaxLength(400);
            entity.Property(e => e.Code)
                .HasMaxLength(15)
                .IsFixedLength();
            entity.Property(e => e.Province).HasMaxLength(400);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.AddressesUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_AddressesUser_Users");
        });

        modelBuilder.Entity<Feature>(entity =>
        {
            entity.HasKey(e => e.FeatureId).HasName("PK_Product_Features");

            entity.Property(e => e.FeatureId).HasColumnName("FeatureID");
            entity.Property(e => e.FeatureTitle).HasMaxLength(150);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.CouponId).HasColumnName("CouponID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.FullAddress).HasMaxLength(800);
            entity.Property(e => e.FullName).HasMaxLength(350);
            entity.Property(e => e.OrderDescription).HasMaxLength(800);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsFixedLength();
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.ShippingMethodDNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ShippingMethodD)
                .HasConstraintName("FK_Orders_ShippingMethod");

            entity.HasOne(d => d.Status).WithMany(p => p.Orders)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Status");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Users");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.ToTable("Order_Details");

            entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Details_Order_Details");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Details_Products");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK_Product");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ImageName)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ShortDescription).HasMaxLength(500);
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.Title).HasMaxLength(350);

            entity.HasOne(d => d.Store).WithMany(p => p.Products)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_Products_Stores");
        });

        modelBuilder.Entity<ProductComment>(entity =>
        {
            entity.HasKey(e => e.CommentId);

            entity.ToTable("Product_Comments");

            entity.Property(e => e.CommentId).HasColumnName("CommentID");
            entity.Property(e => e.Comment).HasMaxLength(800);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(350);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_Product_Comments_Product_Comments");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductComments)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Comments_Products");

            entity.HasOne(d => d.User).WithMany(p => p.ProductComments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Product_Comments_Users");
        });

        modelBuilder.Entity<ProductCount>(entity =>
        {
            entity.ToTable("Product_Counts");

            entity.Property(e => e.ProductCountId).HasColumnName("ProductCountID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.PuductFeatureId).HasColumnName("Puduct_FeatureID");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductCounts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Counts_Products");
        });

        modelBuilder.Entity<ProductFeature>(entity =>
        {
            entity.HasKey(e => e.ProductFeatureId).HasName("PK_Product_Features_1");

            entity.ToTable("Product_Features");

            entity.Property(e => e.ProductFeatureId).HasColumnName("ProductFeatureID");
            entity.Property(e => e.FeatureId).HasColumnName("FeatureID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Value)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Feature).WithMany(p => p.ProductFeatures)
                .HasForeignKey(d => d.FeatureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Features_Features");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductFeatures)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Features_Products");
        });

        modelBuilder.Entity<ProductGallery>(entity =>
        {
            entity.HasKey(e => e.GalleryId);

            entity.ToTable("Product_Galleries");

            entity.Property(e => e.GalleryId).HasColumnName("GalleryID");
            entity.Property(e => e.ColorCode)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("colorCode");
            entity.Property(e => e.ImageName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Title).HasMaxLength(250);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductGalleries)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Galleries_Product");
        });

        modelBuilder.Entity<ProductGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("Product_Groups");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupTitle)
                .HasMaxLength(400)
                .IsFixedLength();
            entity.Property(e => e.ParentId).HasColumnName("ParentID");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_Product_Groups_Product_Groups1");
        });

        modelBuilder.Entity<ProductInventory>(entity =>
        {
            entity.HasKey(e => e.ProductInventoryId).HasName("PK_ProductInventories");

            entity.ToTable("Product_Inventories");

            entity.Property(e => e.ProductInventoryId).HasColumnName("ProductInventoryID");
        });

        modelBuilder.Entity<ProductSelectGroup>(entity =>
        {
            entity.HasKey(e => e.PgId);

            entity.ToTable("Product_Select_Groups");

            entity.Property(e => e.PgId).HasColumnName("PG_ID");
            entity.Property(e => e.ProductGroupId).HasColumnName("Product_GroupID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.ProductGroup).WithMany(p => p.ProductSelectGroups)
                .HasForeignKey(d => d.ProductGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Select_Groups_Product_Groups");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductSelectGroups)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Select_Groups_Product");
        });

        modelBuilder.Entity<ProductTag>(entity =>
        {
            entity.HasKey(e => e.TagId);

            entity.ToTable("Product_Tags");

            entity.Property(e => e.TagId).HasColumnName("TagID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Tag).HasMaxLength(250);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductTags)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Tags_Product");
        });

        modelBuilder.Entity<Rolse>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("Rolse");

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("RoleID");
            entity.Property(e => e.RoleTitle).HasMaxLength(250);
            entity.Property(e => e.RoleName).HasMaxLength(250);
        });

        modelBuilder.Entity<Seller>(entity =>
        {
            entity.Property(e => e.SellerId).HasColumnName("SellerID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.NationalId)
                .HasMaxLength(10)
                .HasColumnName("NationalID");
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsFixedLength();
        });

        modelBuilder.Entity<ShippingMethod>(entity =>
        {
            entity.HasKey(e => e.ShippingMethodId).HasName("PK_Posts");

            entity.ToTable("ShippingMethod");

            entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethodID");
            entity.Property(e => e.Name).HasMaxLength(250);
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.ToTable("Status");

            entity.Property(e => e.StatusId)
                .ValueGeneratedNever()
                .HasColumnName("StatusID");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .IsFixedLength();
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.Location)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SellerId).HasColumnName("SellerID");
            entity.Property(e => e.StoreName).HasMaxLength(50);

            entity.HasOne(d => d.Seller).WithMany(p => p.Stores)
                .HasForeignKey(d => d.SellerId)
                .HasConstraintName("FK_Stores_Sellers");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.ActiveCode)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsFixedLength();
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsFixedLength();
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsFixedLength();
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsFixedLength();

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Users");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
