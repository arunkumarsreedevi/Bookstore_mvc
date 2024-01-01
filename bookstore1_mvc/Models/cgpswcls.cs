using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bookstore1_mvc.Models
{
    public class cgpswcls
    {
        public string username { get; set; }
        [Required(ErrorMessage = "password mismatch")]
        public string oldpsw { get; set; }
        public string newpsw { get; set; }
        [Compare("newpsw", ErrorMessage = "password mismatch")]
        public string cpassword { get; set;}
        public string msg { get; set; }
    }
}