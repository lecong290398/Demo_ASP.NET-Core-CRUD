using System;
using ASP.NET_CRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASP.NET_CRUD.Contexts
{
    public partial class GameStoreContext : DbContext
    {
        public GameStoreContext()
        {
        }

        public GameStoreContext(DbContextOptions<GameStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TetsLogin> TetsLogin { get; set; }
        public virtual DbSet<W_Blog> W_Blog { get; set; }
        public virtual DbSet<W_BlogCaterogy> W_BlogCaterogy { get; set; }
        public virtual DbSet<W_Category> W_Category { get; set; }
        public virtual DbSet<W_ColorOfProduct> W_ColorOfProduct { get; set; }
        public virtual DbSet<W_CommerceWebsite> W_CommerceWebsite { get; set; }
        public virtual DbSet<W_Contact> W_Contact { get; set; }
        public virtual DbSet<W_Customer> W_Customer { get; set; }
        public virtual DbSet<W_Email> W_Email { get; set; }
        public virtual DbSet<W_Faq> W_Faq { get; set; }
        public virtual DbSet<W_Order> W_Order { get; set; }
        public virtual DbSet<W_PostService> W_PostService { get; set; }
        public virtual DbSet<W_Product> W_Product { get; set; }
        public virtual DbSet<W_ProductAndTag> W_ProductAndTag { get; set; }
        public virtual DbSet<W_ProductHotSale> W_ProductHotSale { get; set; }
        public virtual DbSet<W_ProductImage> W_ProductImage { get; set; }
        public virtual DbSet<W_ProductOption> W_ProductOption { get; set; }
        public virtual DbSet<W_ProductOptionAndProduct> W_ProductOptionAndProduct { get; set; }
        public virtual DbSet<W_ReviewOfProduct> W_ReviewOfProduct { get; set; }
        public virtual DbSet<W_Setting> W_Setting { get; set; }
        public virtual DbSet<W_SlideShow> W_SlideShow { get; set; }
        public virtual DbSet<W_SlideShowGroup> W_SlideShowGroup { get; set; }
        public virtual DbSet<W_SubMenu> W_SubMenu { get; set; }
        public virtual DbSet<W_SubMenuGroup> W_SubMenuGroup { get; set; }
        public virtual DbSet<W_User> W_User { get; set; }
        public virtual DbSet<W_UserGroup> W_UserGroup { get; set; }
        public virtual DbSet<WeightUnit> WeightUnit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=;Database=;User Id=sa;Password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<W_Contact>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);
            });

            modelBuilder.Entity<W_ProductAndTag>(entity =>
            {
                entity.HasKey(e => new { e.FK_WProduct, e.FK_Tag })
                    .HasName("PK_W_ProductTag");
            });

            modelBuilder.Entity<W_ProductOptionAndProduct>(entity =>
            {
                entity.HasKey(e => new { e.FK_ProductOptionID, e.FK_ProductID });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
