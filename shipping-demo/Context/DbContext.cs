using shipping_demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace shipping_demo.Context
{
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbSet<User> User { get; set; }
    }
}