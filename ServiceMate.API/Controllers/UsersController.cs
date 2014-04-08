using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiceMate.Common.Domain;
using ServiceMate.Models;
using ServiceMate.Repository.Repository;

namespace ServiceMate.API.Controllers
{
    public class UserController : ApiController
    {
        private ModelFactory _modelFactory;
        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository, ModelFactory modelFactory)
        {
            _userRepository = userRepository;
            _modelFactory = modelFactory;
        }

        // GET api/values
        public IEnumerable<UserModel> Get()
        {
            return  _modelFactory.GetUserModels(_userRepository.GetAll().ToList());
        }
    }
}
