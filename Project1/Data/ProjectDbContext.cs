using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Data
{
    public class ProjectDbContext: DbContext
    {
        public ProjectDbContext()
        {
            
        }

        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Trainer> Trainer { get; set; }

        public virtual DbSet<Pet> Pet { get; set; }

        public virtual DbSet<PTDetail> PTDetail { get; set; }

        public virtual DbSet<TrainerServiceArea> TrainerServiceArea { get; set; }

        public virtual DbSet<Location> Location { get; set; }

        public virtual DbSet<CourseRating> CourseRating { get; set; }

        public virtual DbSet<CourseRanking> CourseRanking { get; set; }

        public virtual DbSet<CourseClicksRanking> CourseClicksRanking { get; set; }

        public virtual DbSet<InstructorRanking> InstructorRanking { get; set; }

        public virtual DbSet<Order> Order { get; set; }

        public virtual DbSet<OrderDetail> OrderDetail { get; set; }

        public virtual DbSet<Payment> Payment { get; set; }

        public virtual DbSet<ShoppingCart> Cart { get; set; }

        public virtual DbSet<Discount> Discount { get; set; }

        public virtual DbSet<ClassSchedule> ClassSchedule { get; set; }

        public virtual DbSet<EnrollmentRanking> EnrollmentRanking { get; set; }

        public virtual DbSet<Member> Member { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Database=ProjectDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<Course>(entity =>
    //        {
    //            entity.ToTable("Course");
    //        });

    //        modelBuilder.Entity<Trainer>(entity => 
    //        { 
    //            entity.ToTable("Trainer");
    //        });

    //        modelBuilder.Entity<Pet>(entity =>
    //        {
				//entity.ToTable("Pet");
    //        });

    //        modelBuilder.Entity<PTDetail>(entity => 
    //        {
    //            entity.ToTable("PTDetail");
    //        });

    //        modelBuilder.Entity<TrainerServiceArea>(entity =>
    //        {
    //            entity.ToTable("TrainerServiceArea");
    //        });

    //        modelBuilder.Entity<Location>(entity =>
    //        {
    //            entity.ToTable("Location");
    //        });

    //        modelBuilder.Entity<CourseRating>(entity =>
    //        {
    //            entity.ToTable("CourseRating");
    //        });

    //        modelBuilder.Entity<CourseRanking>(entity =>
    //        {
    //            entity.ToTable("CourseRanking");
    //        });

    //        modelBuilder.Entity<CourseClicksRanking>(entity =>
    //        {
    //            entity.ToTable("CourseClicksRanking");
    //        });

    //        modelBuilder.Entity<InstructorRanking>(entity =>
    //        {
				//entity.ToTable("InstructorRanking");
    //        });

    //        modelBuilder.Entity<Order>(entity =>
    //        {
    //            entity.ToTable("Order");
    //        });

    //        modelBuilder.Entity<OrderDetail>(entity =>
    //        {
    //            entity.ToTable("OrderDetail");
    //        });

    //        modelBuilder.Entity<Payment>(entity =>
    //        {
    //            entity.ToTable("Payment");
    //        });

    //        modelBuilder.Entity<ShoppingCart>(entity =>
    //        {
    //            entity.ToTable("ShoppingCart");
    //        });

    //        modelBuilder.Entity<Discount>(entity =>
    //        {
    //            entity.ToTable("Discount");
    //        });

    //        modelBuilder.Entity<ClassSchedule>(entity =>
    //        {
    //            entity.ToTable("ClassSchedule");
    //        });

    //        modelBuilder.Entity<EnrollmentRanking>(entity =>
    //        {
    //            entity.ToTable("EnrollmentRanking");
    //        });

    //        modelBuilder.Entity<Member>(entity =>
    //        {
    //            entity.ToTable("Member");
    //        });
    //    }
    }
}
