using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAPI.Models;

namespace DataAPI.Controllers
{
    public class UserController : ApiController
    {
        // rest api have many constraints
        // they're cacheable , stateless , based on client - server 
        // they're http based service made on top of .net framework

        [HttpGet]
        public void Get()
        {
            
        }
    }
}
