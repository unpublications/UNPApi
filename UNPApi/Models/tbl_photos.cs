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
    
    public partial class tbl_photos
    {
        public int uniq_id { get; set; }
        public string ph_title { get; set; }
        public string ph_desc { get; set; }
        public string ph_image { get; set; }
        public string ph_conference { get; set; }
        public string tbl_conf { get; set; }
        public string tbl_conf_id { get; set; }
        public System.DateTime tr_date { get; set; }
        public int Id_new { get; set; }
    }
}