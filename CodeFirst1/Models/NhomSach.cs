namespace CodeFirst1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomSach")]
    public partial class NhomSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhomSach()
        {
            DanhMucSaches = new HashSet<DanhMucSach>();
        }

        [Key]
        [StringLength(5)]
        public string MaNhom { get; set; }

        [StringLength(25)]
        public string TenNhom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhMucSach> DanhMucSaches { get; set; }
    }
}
