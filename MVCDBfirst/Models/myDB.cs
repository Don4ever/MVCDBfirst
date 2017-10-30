using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDBfirst.Models
{
    public class myDB : DbContext
    {

        public myDB() :base("DBConnection")
        {
            
        }
        public DbSet<user> users { get; set; }
        public DbSet<post> posts { get; set; }
    }
}