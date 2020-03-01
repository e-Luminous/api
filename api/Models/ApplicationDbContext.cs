using Microsoft.EntityFrameworkCore;

namespace api.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Classroom> Classrooms { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<ExpClass> ExpClasses { get; set; }

        public DbSet<Experiment> Experiments { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Institution> Institutions { get; set; }
        
        public DbSet<InstLevelGroup> InstLevelGroups { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Level> Levels { get; set; }

        public DbSet<LevelGroup> LevelGroups { get; set; }

        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        public DbSet<PreAuthList> PreAuthLists { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentEnrollment> StudentEnrollments { get; set; }

        public DbSet<Submission> Submissions { get; set; }

        public DbSet<Subscription> Subscriptions { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

    }
}