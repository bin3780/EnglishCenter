namespace EnglishCenter.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhoaHoc")]
    public partial class KhoaHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhoaHoc()
        {
            LopHoc = new HashSet<LopHoc>();
        }

        public int id { get; set; }

        [StringLength(10)]
        public string ngaybatdau { get; set; }

        [StringLength(10)]
        public string ngayketthuc { get; set; }

        [StringLength(10)]
        public string gia { get; set; }

        [StringLength(100)]
        public string tenkhoahoc { get; set; }

        public int? capdo { get; set; }

        public virtual Level Level { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHoc> LopHoc { get; set; }
    }
}
