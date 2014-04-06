using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiceMate.Repository.Repository;

namespace ServiceMate.API.Controllers
{
    public class UserController : ApiController
    {
        private  IUserRepository Repository { get; set; }

        public UserController(IUserRepository repository)
        {
            Repository = repository;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            var test = Repository.GetAll();

            return new string[] { "value1", "value2" };
        }
    }
}
