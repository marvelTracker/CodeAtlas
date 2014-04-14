using ServiceMate.Common.Domain;

namespace ServiceMate.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ServiceMate.Repository.ServiceMateContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ServiceMate.Repository.ServiceMateContext context)
        {
            User user1 = new User();
            user1.Email = "Dinesh.Ranasinghe@gmail.com";
            user1.Password = "XXXX";
            user1.UserType = UserType.Admin;

            User user2 = new User();
            user2.Email = "Kumara@gmail.com";
            user2.Password = "TEST";
            user2.UserType = UserType.Admin;

            User user3 = new User();
            user3.Email = "BOB.John@gmail.com";
            user3.Password = "XXXX";
            user3.UserType = UserType.Consumer;

            context.User.Add(user1);
            context.User.Add(user2);
            context.User.Add(user3);

            ServiceCategory serviceCategory1 = new ServiceCategory { Category = ServiceCategoryEnum.Cleaning, Description = "House Cleaning", ServiceCategoryCode = 100 };
            ServiceCategory serviceCategory2 = new ServiceCategory { Category = ServiceCategoryEnum.Cleaning, Description = "Carpet Steam Cleaning", ServiceCategoryCode = 101 };
            ServiceCategory serviceCategory3 = new ServiceCategory { Category = ServiceCategoryEnum.Cleaning, Description = "End of Lease Cleaning", ServiceCategoryCode = 102 };
            ServiceCategory serviceCategory4 = new ServiceCategory { Category = ServiceCategoryEnum.Cleaning, Description = "Office Cleaning", ServiceCategoryCode = 103 };
            ServiceCategory serviceCategory5 = new ServiceCategory { Category = ServiceCategoryEnum.Cleaning, Description = "Outdoor Cleaning", ServiceCategoryCode = 104 };
            ServiceCategory serviceCategory6 = new ServiceCategory { Category = ServiceCategoryEnum.Cleaning, Description = "Pool Cleaning", ServiceCategoryCode = 105 };
            ServiceCategory serviceCategory7 = new ServiceCategory { Category = ServiceCategoryEnum.Cleaning, Description = "Windows Cleaning", ServiceCategoryCode = 106 };
            ServiceCategory serviceCategory8 = new ServiceCategory { Category = ServiceCategoryEnum.Cleaning, Description = "Oven Cleaning", ServiceCategoryCode = 107 };
            ServiceCategory serviceCategory9 = new ServiceCategory { Category = ServiceCategoryEnum.Cleaning, Description = "Hard Floor Cleaning", ServiceCategoryCode = 108 };
            ServiceCategory serviceCategory10 = new ServiceCategory { Category = ServiceCategoryEnum.Cleaning, Description = "Duct Cleaning", ServiceCategoryCode = 109 };



            context.ServiceCategory.Add(serviceCategory1);
            context.ServiceCategory.Add(serviceCategory2);
            context.ServiceCategory.Add(serviceCategory3);
            context.ServiceCategory.Add(serviceCategory4);
            context.ServiceCategory.Add(serviceCategory5);
            context.ServiceCategory.Add(serviceCategory6);
            context.ServiceCategory.Add(serviceCategory7);
            context.ServiceCategory.Add(serviceCategory8);
            context.ServiceCategory.Add(serviceCategory9);
            context.ServiceCategory.Add(serviceCategory10);            
            context.SaveChanges();

        }
    }
}
