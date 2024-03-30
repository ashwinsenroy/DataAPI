using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataAPI.Repositories
{
    public class GenericRepository<T> 
    {
        private DbContext dbContext { get; set; }

        public GenericRepository() 
        {
            
        }

    }
}