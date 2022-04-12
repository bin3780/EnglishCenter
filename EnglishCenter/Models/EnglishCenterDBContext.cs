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
        //public virtual DbSet<Level> Level { get; set; }
        public virtual DbSet<LopHoc> LopHoc { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhoaHoc>()
                .Property(e => e.ngaybatdau)
                .IsFixedLength();

            modelBuilder.Entity<KhoaHoc>()
                .Property(e => e.ngayketthuc)
                .IsFixedLength();

            modelBuilder.Entity<KhoaHoc>()
                .Property(e => e.gia)
                .IsFixedLength();

            modelBuilder.Entity<KhoaHoc>()
                .HasMany(e => e.LopHoc)
                .WithOptional(e => e.KhoaHoc)
                .HasForeignKey(e => e.idkhoahoc);

            /*modelBuilder.Entity<Level>()
                .HasMany(e => e.KhoaHoc)
                .WithOptional(e => e.capdo)
                .HasForeignKey(e => e.id);*/

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.tenlophoc)
                .IsFixedLength();
        }
    }
}

