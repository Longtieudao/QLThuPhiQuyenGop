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
    
    public partial class ThongKeThuPhiHangThang
    {
        public int ThongKeThuPhiID { get; set; }
        public Nullable<int> ThuPhiID { get; set; }
        public Nullable<System.DateTime> NgayVanDong { get; set; }
        public Nullable<decimal> TongSoTienThu { get; set; }
        public Nullable<int> SoHoDaNop { get; set; }
    
        public virtual ThuPhi ThuPhi { get; set; }
    }
}
