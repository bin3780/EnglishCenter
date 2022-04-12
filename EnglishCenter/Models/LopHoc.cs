namespace EnglishCenter.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHoc")]
    public partial class LopHoc
    {
        public int id { get; set; }

        [StringLength(10)]
        public string tenlophoc { get; set; }

        [StringLength(50)]
        public string giohoc { get; set; }

        public int? idkhoahoc { get; set; }

        public virtual KhoaHoc KhoaHoc { get; set; }
    }
}
