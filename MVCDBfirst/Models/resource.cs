using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDBfirst.Models
{
    public class resource
    {
        [Key]
        public int res_id { get; set; }
        public int res_type { get; set; }
        public string res_desc { get; set; }
    }
}