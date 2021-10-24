namespace CodeFirst1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMucSach")]
    public partial class DanhMucSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMucSach()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        [StringLength(5)]
        public string MaSach { get; set; }

        [StringLength(40)]
        public string TenSach { get; set; }

        [StringLength(20)]
        public string TacGia { get; set; }

        [StringLength(5)]
        public string MaNhom { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DonGia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SLTon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual NhomSach NhomSach { get; set; }
    }
}
