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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Defining the foreign keys in associative @LevelGroup model
            builder.Entity<LevelGroup>().HasKey(LG => new
            {
                LG.LevelId,
                LG.GroupId
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

            
            // Defining the foreign keys in associative @UserRole model
            builder.Entity<UserRole>().HasKey(UR => new
            {
                UR.RoleId,
                UR.Id
            });

            // Many-to-one relationship between @UserRole and @User
            builder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(ur => ur.Roles)
                .HasForeignKey(ur => ur.RoleId);

            // Many-to-one relationship between @UserRole and @Role
            builder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(ur => ur.Roles)
                .HasForeignKey(ur => ur.Id);

        
            // Defining the foreign keys in associative @StudentEnrollment model
            builder.Entity<StudentEnrollment>().HasKey(SE => new
            {
                SE.StudentId,
                SE.ClassroomId
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
            builder.Entity<ExpClass>().HasKey(EC => new
            {
                EC.ExperimentId,
                EC.ClassroomId
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
            builder.Entity<InstLevelGroup>().HasKey(ILG => new
            {
                ILG.InstitutionId,
                ILG.LevelGroup.LevelId,
                ILG.LevelGroup.GroupId
            });

            // Many-to-one relationship between @InstLevelGroup and @Institution
            builder.Entity<InstLevelGroup>()
                .HasOne(Ilg => Ilg.Institution)
                .WithMany(Ilg => Ilg.InstLevelGroup)
                .HasForeignKey(Ilg => Ilg.InstitutionId);

            // Many-to-one relationship between @InstLevelGroup and @LevelGroup
            builder.Entity<InstLevelGroup>()
                .HasOne(Ilg => Ilg.LevelGroup)
                .WithMany(Ilg => Ilg.InstLevelGroup)
                .HasForeignKey(Ilg => Ilg.LevelGroup.LevelId)
                .HasForeignKey(Ilg => Ilg.LevelGroup.GroupId);

        }
    }
}