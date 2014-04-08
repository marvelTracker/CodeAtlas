using System.Data.Entity.Migrations;
using ServiceMate.Common.Domain;

namespace ServiceMate.Repository.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ServiceMateContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ServiceMateContext context)
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

            User user4 = new User();
            user4.Email = "Cleaner.PAp@iclean.com";
            user4.Password = "MIX";
            user4.UserType = UserType.ServiceProvider;

            context.User.Add(user1);
            context.User.Add(user2);
            context.User.Add(user3);
            context.User.Add(user4);

            Consumer consumer = new Consumer();
            consumer.User = user3;
            consumer.PhoneNumber = "67777777";
            consumer.ConsumerName = "BOB Malli";
            
            context.Consumer.Add(consumer);

            ServiceProvider serviceProvider = new ServiceProvider();
            serviceProvider.ABN = "12345634643";
            serviceProvider.User = user4;
            serviceProvider.BusinessName = "Reality Cleaners Australia";

            context.ServiceProvider.Add(serviceProvider);
            
            context.SaveChanges();
        }
    }
}
