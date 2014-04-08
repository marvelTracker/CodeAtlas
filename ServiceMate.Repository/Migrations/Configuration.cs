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

            context.User.Add(user1);
            context.User.Add(user2);
            context.User.Add(user3);

            context.SaveChanges();
        }
    }
}
