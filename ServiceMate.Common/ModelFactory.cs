using System.Collections.Generic;
using System.Linq;
using ServiceMate.Common.Domain;

namespace ServiceMate.Models
{
    public class ModelFactory
    {
        public UserModel GetUserModel(User user)
        {
            return new UserModel() {UserId = user.Id, EmailId = user.Email, UserType = GetUserTypeModel(user.UserType)};
        }

        public UserTypeModel GetUserTypeModel(UserType userType)
        {
            UserTypeModel result;

            UserTypeModel.TryParse(userType.ToString(), out result);

            return result;
        }


        public IEnumerable<UserModel> GetUserModels(IList<User> users)
        {
            IList<UserModel> userModels = new List<UserModel>();

            foreach (var user in users.ToList())
            {
                userModels.Add(GetUserModel(user));
            }

            return userModels;
        }
    }
}