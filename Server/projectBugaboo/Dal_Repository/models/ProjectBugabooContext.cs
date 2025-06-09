using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal_Repository.models;

public partial class ProjectBugabooContext : DbContext
{
    public ProjectBugabooContext()
    {
    }

    public ProjectBugabooContext(DbContextOptions<ProjectBugabooContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Buy> Buys { get; set; }

    public virtual DbSet<BuyDetail> BuyDetails { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Model> Models { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-E0FAPSB\\SQLEXPRESS;Initial Catalog= projectBugaboo; Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Buy>(entity =>
        {
            entity.HasKey(e => e.BuyId).HasName("PK__Buys__BBB36FEC55A4A248");

            entity.Property(e => e.BuyId).HasColumnName("buyId");
            entity.Property(e => e.BuyDate)
                .HasColumnType("date")
                .HasColumnName("buyDate");
            entity.Property(e => e.CustomerId).HasColumnName("customerId");
            entity.Property(e => e.Payment).HasColumnName("payment");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("remark");

            entity.HasOne(d => d.Customer).WithMany(p => p.Buys)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Buys__customerId__412EB0B6");
        });

        modelBuilder.Entity<BuyDetail>(entity =>
        {
            entity.HasKey(e => e.BuyDetailsId).HasName("PK__BuyDetai__3D1FEED75376A385");

            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.BuyId).HasColumnName("buyId");
            entity.Property(e => e.ProductId).HasColumnName("productId");

            entity.HasOne(d => d.Buy).WithMany(p => p.BuyDetails)
                .HasForeignKey(d => d.BuyId)
                .HasConstraintName("FK__BuyDetail__buyId__440B1D61");

            entity.HasOne(d => d.Product).WithMany(p => p.BuyDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__BuyDetail__produ__44FF419A");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__23CAF1D8FC37F3E4");

            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.NameCategory)
                .HasColumnType("text")
                .HasColumnName("nameCategory");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__B611CB7D56DE711F");

            entity.Property(e => e.CustomerId).HasColumnName("customerId");
            entity.Property(e => e.DateBirth)
                .HasColumnType("date")
                .HasColumnName("dateBirth");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.NameCustomer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nameCustomer");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Model>(entity =>
        {
            entity.HasKey(e => e.ModelId).HasName("PK__Models__0215CC59530E2721");

            entity.Property(e => e.ModelId).HasColumnName("modelId");
            entity.Property(e => e.NameModel)
                .HasColumnType("text")
                .HasColumnName("nameModel");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__2D10D16AD67F707A");

            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.Descriptions)
                .HasColumnType("text")
                .HasColumnName("descriptions");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("date")
                .HasColumnName("lastUpdate");
            entity.Property(e => e.ModelId).HasColumnName("modelId");
            entity.Property(e => e.NameProduct)
                .HasColumnType("text")
                .HasColumnName("nameProduct");
            entity.Property(e => e.Picture)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("picture");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Products__catego__3C69FB99");

            entity.HasOne(d => d.Model).WithMany(p => p.Products)
                .HasForeignKey(d => d.ModelId)
                .HasConstraintName("FK__Products__modelI__3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
