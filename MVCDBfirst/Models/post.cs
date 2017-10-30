using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDBfirst.Models
{
    public class post
    {
        [Key]
        public int post_id { get; set; }
        public string post_title { get; set; }
        public string author { get; set; }
    }
}