using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Models
{
    public class ApplicationDbContext : IdentityDbContext
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

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentEnrollment> StudentEnrollments { get; set; }

        public DbSet<Submission> Submissions { get; set; }

        public DbSet<Subscription> Subscriptions { get; set; }

        public DbSet<Transaction> Transactions { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Subscription>()
                .HasOne(sub => sub.Transaction)
                .WithOne(tra => tra.Subscription)
                .HasForeignKey<Transaction>(s => s.TransactionId);
            
            builder.Entity<Transaction>()
                .HasOne(sub => sub.Subscription)
                .WithOne(tra => tra.Transaction)
                .HasForeignKey<Subscription>(s => s.SubscriptionId);

            // Defining the foreign keys in associative @LevelGroup model
            builder.Entity<LevelGroup>().HasKey(lg => new
            {
                lg.LevelId,
                lg.GroupId
            });
            
            // Many-to-one relationship between @LevelGroup and @Level
            builder.Entity<LevelGroup>()
                .HasOne(levelGroup => levelGroup.Level)
                .WithMany(level => level.LevelGroups)
                .HasForeignKey(levelGroup => levelGroup.LevelId);
            
            // Many-to-one relationship between @LevelGroup and @Group
            builder.Entity<LevelGroup>()
                .HasOne(levelGroup => levelGroup.Group)
                .WithMany(level => level.LevelGroups)
                .HasForeignKey(levelGroup => levelGroup.GroupId);

            
            // // Defining the foreign keys in associative @UserRole model
            // builder.Entity<UserRole>().HasKey(UR => new
            // {
            //     UR.RoleId,
            //     UR.Id
            // });

            // // Many-to-one relationship between @UserRole and @User
            // builder.Entity<UserRole>()
            //     .HasOne(ur => ur.User)
            //     .WithMany(ur => ur.Roles)
            //     .HasForeignKey(ur => ur.RoleId);

            // // Many-to-one relationship between @UserRole and @Role
            // builder.Entity<UserRole>()
            //     .HasOne(ur => ur.Role)
            //     .WithMany(ur => ur.Roles)
            //     .HasForeignKey(ur => ur.Id);

        
            // Defining the foreign keys in associative @StudentEnrollment model
            builder.Entity<StudentEnrollment>().HasKey(se => new
            {
                se.StudentId,
                se.ClassroomId
            });

            // Many-to-one relationship between @StudentEnrollment and @Classroom
            builder.Entity<StudentEnrollment>()
                .HasOne(se => se.Classroom)
                .WithMany(se => se.StudentEnr)
                .HasForeignKey(se => se.StudentId);

            // Many-to-one relationship between @StudentEnrollment and @Student
            builder.Entity<StudentEnrollment>()
                .HasOne(se => se.Student)
                .WithMany(se => se.StudentEnr)
                .HasForeignKey(se => se.StudentId);
        

            // Defining the foreign keys in associative @ExpClass model
            builder.Entity<ExpClass>().HasKey(ec => new
            {
                ec.ExperimentId,
                ec.ClassroomId
            });

            // Many-to-one relationship between @ExpClass and @Classroom
            builder.Entity<ExpClass>()
                .HasOne(ec => ec.Classroom)
                .WithMany(ec => ec.ExpClass)
                .HasForeignKey(ec => ec.ClassroomId);

            // Many-to-one relationship between @ExpClass and @Experiment
            builder.Entity<ExpClass>()
                .HasOne(ec => ec.Experiment)
                .WithMany(ec => ec.ExpClass)
                .HasForeignKey(ec => ec.ExperimentId);


            // Defining the foreign keys in associative @InstLevelGroup model
            builder.Entity<InstLevelGroup>().HasKey(ilg => new
            {
                ilg.InstitutionId,
                ilg.LevelId,
                ilg.GroupId
            });

            // Many-to-one relationship between @InstLevelGroup and @Institution
            builder.Entity<InstLevelGroup>()
                .HasOne(ilg => ilg.Institution)
                .WithMany(ilg => ilg.InstLevelGroup)
                .HasForeignKey(ilg => ilg.InstitutionId);

            // Many-to-one relationship between @InstLevelGroup and @LevelGroup
            builder.Entity<InstLevelGroup>()
                .HasOne(ilg => ilg.LevelGroup)
                .WithMany(ilg => ilg.InstLevelGroups)
                .HasForeignKey(ilg => new
                {
                    ilg.LevelId,
                    ilg.GroupId
                });
        }
    }
}