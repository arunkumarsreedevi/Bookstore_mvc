using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bookstore1_mvc.Models
{
    public class profileviewandedit
    {
        public string name { get; set; }
        public string details { get; set; }
        public string price { get; set; }
        public string username { get; set; }
        public string msg { get; set; }
    }
}