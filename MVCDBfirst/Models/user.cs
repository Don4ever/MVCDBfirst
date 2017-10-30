using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDBfirst.Models
{
    public class user
    {
        [Key]
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
    }
}