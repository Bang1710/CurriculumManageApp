namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DamNhiemMon")]
    public partial class DamNhiemMon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaChuongTrinh { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaMonHoc { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MaGiaoVien { get; set; }

        public int CoLaDamNhiemChinh { get; set; }

        public virtual ChuongTrinh ChuongTrinh { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual MonHoc MonHoc { get; set; }
    }
}
