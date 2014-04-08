using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceMate.Common.Domain;

namespace ServiceMate.API.Models
{
    public class ModelFactory
    {
        public UserModel GetUserModel(User user)
        {
            return new UserModel() {UserId = user.Id, EmailId = user.Email, UserType = user.UserType};
        }
    }
}