using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace shipping_demo.Models
{
    public class User
    {
        public int Id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public string password { get; set; }
    }
}