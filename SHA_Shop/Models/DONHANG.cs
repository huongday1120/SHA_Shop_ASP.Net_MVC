namespace SHA_Shop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONHANG")]
    public partial class DONHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONHANG()
        {
            CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();
        }

        [Key]
        public int MaDH { get; set; }

        public DateTime? NgayDatHang { get; set; }

        public DateTime? NgayGiaoHang { get; set; }

        public bool? TrangThai { get; set; }

        public int IDNguoiDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
    }
}
