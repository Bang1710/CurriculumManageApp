namespace DTO
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
            KhoaHocMons = new HashSet<KhoaHocMon>();
        }

        [Key]
        [StringLength(10)]
        public string MaKhoaHoc { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKhoaHoc { get; set; }

        public int NamBatDau { get; set; }

        public int NamKetThuc { get; set; }

        [Required]
        [StringLength(5)]
        public string MaChuongTrinh { get; set; }

        public virtual ChuongTrinh ChuongTrinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhoaHocMon> KhoaHocMons { get; set; }
    }
}
