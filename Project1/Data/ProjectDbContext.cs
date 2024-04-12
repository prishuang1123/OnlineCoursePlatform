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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShoppingCart>().HasData(
                new ShoppingCart { CartID=1, CourseID=1, Quantity=1, CreatedAt=DateTime.UtcNow}
                );
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderID=1, MemberID=1, OrderDate=DateTime.Now, OrderStatus="Processing", TotalAmount=300, CreatedAt=DateTime.Now },
                new Order { OrderID = 2, MemberID = 2, OrderDate = DateTime.Now, OrderStatus = "Delivered", TotalAmount = 500, CreatedAt = DateTime.Now },
                new Order { OrderID = 3, MemberID = 3, OrderDate = DateTime.Now, OrderStatus = "Cancelled", TotalAmount = 200, CreatedAt = DateTime.Now },
                new Order { OrderID = 4, MemberID = 4, OrderDate = DateTime.Now, OrderStatus = "Processing", TotalAmount = 150, CreatedAt = DateTime.Now },
                new Order { OrderID = 5, MemberID = 5, OrderDate = DateTime.Now, OrderStatus = "Shipped", TotalAmount = 350, CreatedAt = DateTime.Now }
                );
            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { OrderDetailID = 1, OrderID = 1, CourseID = 1, Quantity = 1, UnitPrice=10, Subtotal=10},
                new OrderDetail { OrderDetailID = 2, OrderID = 1, CourseID = 2, Quantity = 2, UnitPrice = 20, Subtotal = 40 },
                new OrderDetail { OrderDetailID = 3, OrderID = 1, CourseID = 3, Quantity = 3, UnitPrice = 30, Subtotal = 90 },
                new OrderDetail { OrderDetailID = 4, OrderID = 2, CourseID = 4, Quantity = 4, UnitPrice = 40, Subtotal = 160 },
                new OrderDetail { OrderDetailID = 5, OrderID = 3, CourseID = 5, Quantity = 5, UnitPrice = 50, Subtotal = 250 },
                new OrderDetail { OrderDetailID = 6, OrderID = 3, CourseID = 6, Quantity = 6, UnitPrice = 60, Subtotal = 360 }

                );

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
        public object Courses { get; internal set; }

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
