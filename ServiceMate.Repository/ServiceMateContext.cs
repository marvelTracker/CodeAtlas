using System.Data.Entity;



namespace ServiceMate.Repository
{
    public class ServiceMateContext : DbContext
    {
       public ServiceMateContext()
          : base("ServiceMateConnection")
       {

      }
        //public DbSet<Consumer> Consumer { get; set; }
        //public DbSet<User> User { get; set; }
        //public DbSet<Profile> Profile { get; set; }



        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //    modelBuilder.Entity<Course>()
        //        .HasMany(c => c.Instructors).WithMany(i => i.Courses)
        //        .Map(t => t.MapLeftKey("CourseID")
        //            .MapRightKey("InstructorID")
        //            .ToTable("CourseInstructor"));
        //    modelBuilder.Entity<Department>().MapToStoredProcedures();
        //} 
    }
}
