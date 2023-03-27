namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuongTrinh")]
    public partial class ChuongTrinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuongTrinh()
        {
            ChuongTrinhMonHocs = new HashSet<ChuongTrinhMonHoc>();
            DamNhiemMons = new HashSet<DamNhiemMon>();
            KhoaHocs = new HashSet<KhoaHoc>();
        }

        [Key]
        [StringLength(5)]
        public string MaChuongTrinh { get; set; }

        [Required]
        [StringLength(50)]
        public string TenChuongTrinh { get; set; }

        [Required]
        [StringLength(2)]
        public string MaBacHoc { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKhoa { get; set; }

        [Required]
        [StringLength(10)]
        public string MaGiaoVien_GiamDocCT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuongTrinhMonHoc> ChuongTrinhMonHocs { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual Khoa Khoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DamNhiemMon> DamNhiemMons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhoaHoc> KhoaHocs { get; set; }
    }
}
