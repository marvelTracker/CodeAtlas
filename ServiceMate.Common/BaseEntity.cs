using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceMate.Common.Domain;

namespace ServiceMate.Common
{
   public class BaseEntity:IEntity
    {
       public int Id { get; set; }
       public bool IsDeleted { get; set; }
       public EntityStatusType EntityStatus { get; set; }
    }
}
