using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceMate.Common.Domain;

namespace ServiceMate.Repository.Repository
{
    public class UserRepository:GenericRepository<User>, IUserRepository
    {
        public UserRepository(ServiceMateContext serviceMateContext):base(serviceMateContext)
        {
            
        }
    }
}
