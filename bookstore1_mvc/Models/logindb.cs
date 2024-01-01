using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bookstore1_mvc.Models
{
    public class logindb
    {
        [Required(ErrorMessage = "enter user name")]
        public string username { get; set; }
        [Required(ErrorMessage = "enter password")]
        public string password { get; set; }
        public string msg { get; set; }
    }
}