//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLThuPhiQuyenGop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThongKeQuyenGop
    {
        public int ThongKeQuyenGopID { get; set; }
        public Nullable<int> HoGiaDinhQuyenGop { get; set; }
        public Nullable<int> QuyenGopID { get; set; }
        public Nullable<int> HoGiaDinhID { get; set; }
        public Nullable<decimal> TongSoTienThu { get; set; }
        public Nullable<int> SoHoDaNop { get; set; }
    
        public virtual HoGiaDinhQuyenGop HoGiaDinhQuyenGop1 { get; set; }
    }
}
