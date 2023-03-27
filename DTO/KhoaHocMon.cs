namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhoaHocMon")]
    public partial class KhoaHocMon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaKhoaHoc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaMonHoc { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MaGiaoVien_day { get; set; }

        [Required]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [Required]
        [StringLength(2)]
        public string MaThu { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual KhoaHoc KhoaHoc { get; set; }

        public virtual MonHoc MonHoc { get; set; }
    }
}
