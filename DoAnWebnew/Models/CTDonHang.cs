//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnWebnew.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTDonHang
    {
        public int ID_CTDH { get; set; }
        public Nullable<int> ID_DH { get; set; }
        public Nullable<int> ID_SP { get; set; }
        public Nullable<int> SOLUONG { get; set; }
        public Nullable<double> TONGTIEN { get; set; }
    
        public virtual DonHang DonHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
