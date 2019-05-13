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
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string token { get; set; }
    }
}