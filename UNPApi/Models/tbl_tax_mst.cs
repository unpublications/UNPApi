//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoctorPortalApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_tax_mst
    {
        public int uniq_id { get; set; }
        public Nullable<decimal> tbl_tax_usd { get; set; }
        public Nullable<decimal> tbl_tax_gbp { get; set; }
        public Nullable<decimal> tbl_tax_euro { get; set; }
        public System.DateTime tr_date { get; set; }
    }
}
