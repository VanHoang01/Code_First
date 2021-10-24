namespace CodeFirst1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaSach { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SoLuong { get; set; }

        public virtual DanhMucSach DanhMucSach { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
