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
        public int id { get; set; }

        [StringLength(10)]
        public string id_gv { get; set; }

        [StringLength(10)]
        public string ngaybatdau { get; set; }

        [StringLength(10)]
        public string ngayketthuc { get; set; }

        [StringLength(10)]
        public string gia { get; set; }

        public int id_level { get; set; }

        public virtual Level Level { get; set; }
    }
}
