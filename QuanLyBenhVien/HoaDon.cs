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
    
    public partial class HoaDon
    {
        public int ID { get; set; }
        public string CMNDBN { get; set; }
        public string phuongthuctt { get; set; }
        public Nullable<System.DateTime> NhapVien { get; set; }
        public Nullable<decimal> TienNhap { get; set; }
        public Nullable<decimal> TienDichVu { get; set; }
        public Nullable<decimal> TongTien { get; set; }
    
        public virtual BenhNhan BenhNhan { get; set; }
    }
}
