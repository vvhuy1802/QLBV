//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBenhVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.BenhNhans = new HashSet<BenhNhan>();
        }
    
        public string CMND { get; set; }
        public string Ten { get; set; }
        public byte[] Hinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<int> Ex { get; set; }
        public string DiaChi { get; set; }
        public string QuocTich { get; set; }
        public string SDT { get; set; }
        public int IDchucvu { get; set; }
        public string Hang { get; set; }
        public Nullable<short> Bac { get; set; }
    
        public virtual BangLuong BangLuong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BenhNhan> BenhNhans { get; set; }
        public virtual ChucVu ChucVu { get; set; }
        public virtual User User { get; set; }
    }
}
