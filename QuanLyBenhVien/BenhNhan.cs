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
    
    public partial class BenhNhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BenhNhan()
        {
            this.BenhBenhNhans = new HashSet<BenhBenhNhan>();
            this.DonThuocs = new HashSet<DonThuoc>();
        }
    
        public string CMND { get; set; }
        public string CMNDBS { get; set; }
        public string Ten { get; set; }
        public byte[] Hinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string QuocTich { get; set; }
        public Nullable<int> BaoHiem { get; set; }
        public Nullable<System.DateTime> NhapVien { get; set; }
        public string Benh { get; set; }
        public string Thuoc { get; set; }
        public Nullable<int> IDThuoc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BenhBenhNhan> BenhBenhNhans { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonThuoc> DonThuocs { get; set; }
    }
}