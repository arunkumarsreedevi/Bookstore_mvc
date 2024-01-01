using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bookstore1_mvc.Models
{
    public class insertdb
    {
        public int id { get; set; }
        [Required(ErrorMessage="enter name")]
        public string name { get; set; }
        [Required(ErrorMessage = "enter book details")]
        public string details { get; set; }

        [Required(ErrorMessage = "enter  price")]
        public string price { get; set; }
        [Required(ErrorMessage = "enter user name")]
        public string username { get; set; }
        public string password { get; set; }
        [Compare("password", ErrorMessage ="password mismatch")]
        public string cpassword { get; set; }
        public string msg { get; set; }
    }
}