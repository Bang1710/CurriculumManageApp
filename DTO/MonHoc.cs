namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonHoc")]
    public partial class MonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonHoc()
        {
            ChuongTrinhMonHocs = new HashSet<ChuongTrinhMonHoc>();
            DamNhiemMons = new HashSet<DamNhiemMon>();
            KhoaHocMons = new HashSet<KhoaHocMon>();
        }

        [Key]
        [StringLength(5)]
        public string MaMonHoc { get; set; }

        [Required]
        [StringLength(50)]
        public string TenMonHoc { get; set; }

        public int SoTinChi { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKhoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuongTrinhMonHoc> ChuongTrinhMonHocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DamNhiemMon> DamNhiemMons { get; set; }

        public virtual Khoa Khoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhoaHocMon> KhoaHocMons { get; set; }
    }
}
