using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceMate.Common.Domain;

namespace ServiceMate.API.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string EmailId { get; set; }
        public string Name { get; set; }
        public UserType UserType { get; set; }
        
    }
} 