using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataAPI.Models
{
    public class WebApiContext : DbContext
    {

        public WebApiContext() : base("DatabaseLocal")
        { 
           
        }

        public DbSet<User> Users { get; set; }
    }
}