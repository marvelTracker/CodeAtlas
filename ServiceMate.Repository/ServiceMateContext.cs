using System.Data.Entity;
using ServiceMate.Common.Domain;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace ServiceMate.Repository
{
    public class ServiceMateContext : DbContext
    {
       public ServiceMateContext()
          : base("ServiceMateConnection")
       {

      }
       public DbSet<Consumer> Consumer { get; set; }
       public DbSet<User> User { get; set; }
       public DbSet<Profile> Profile { get; set; }
       public DbSet<ServiceProvider> ServiceProvider { get; set; }
       public DbSet<ServiceCategory> ServiceCategory { get; set; }
       public DbSet<Service> Service { get; set; }


       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
          // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

           //modelBuilder.Entity<Course>()
           //    .HasMany(c => c.Instructors).WithMany(i => i.Courses)
           //    .Map(t => t.MapLeftKey("CourseID")
           //        .MapRightKey("InstructorID")
           //        .ToTable("CourseInstructor"));
           //modelBuilder.Entity<Department>().MapToStoredProcedures();
       } 
    }
}
