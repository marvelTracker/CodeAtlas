using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiceMate.Common.Domain;
using ServiceMate.Repository.Repository;

namespace ServiceMate.API.Controllers
{
    public class UserController : ApiController
    {
        private IUserRepository _userRepository { get; set; }

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            var test = _userRepository.GetAll();

            User user = new User();
            user.Email = "Dean.c.TESTE@gmail.com";
            user.Password = "XXXX";
            user.UserType = UserType.Consumer;

            _userRepository.InsertAsync(user);
           

            return new string[] { "value1", "value2" };
        }
    }
}
