using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNPApi.Models
{
    ///<Summary>
    /// Login Model
    ///</Summary>
    public class LoginModel
    {
        public int userid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int access { get; set; }
        public string conf_name { get; set; }
        public string conf_id { get; set; }
        public string user_mail { get; set; }
        public string token { get; set; }
    }
}