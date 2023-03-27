namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuongTrinhMonHoc")]
    public partial class ChuongTrinhMonHoc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaChuongTrinh { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaMonHoc { get; set; }

        public int HocKy { get; set; }

        public virtual ChuongTrinh ChuongTrinh { get; set; }

        public virtual MonHoc MonHoc { get; set; }
    }
}
