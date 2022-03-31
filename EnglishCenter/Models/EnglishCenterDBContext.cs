using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EnglishCenter.Models
{
    public partial class EnglishCenterDBContext : DbContext
    {
        public EnglishCenterDBContext()
            : base("name=EnglishCenterDBContext")
        {
        }

        public virtual DbSet<KhoaHoc> KhoaHoc { get; set; }
        public virtual DbSet<Level> Level { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhoaHoc>()
                .Property(e => e.id_gv)
                .IsFixedLength();

            modelBuilder.Entity<KhoaHoc>()
                .Property(e => e.ngaybatdau)
                .IsFixedLength();

            modelBuilder.Entity<KhoaHoc>()
                .Property(e => e.ngayketthuc)
                .IsFixedLength();

            modelBuilder.Entity<KhoaHoc>()
                .Property(e => e.gia)
                .IsFixedLength();

            modelBuilder.Entity<Level>()
                .HasMany(e => e.KhoaHoc)
                .WithRequired(e => e.Level)
                .HasForeignKey(e => e.id_level)
                .WillCascadeOnDelete(false);
        }
    }
}
