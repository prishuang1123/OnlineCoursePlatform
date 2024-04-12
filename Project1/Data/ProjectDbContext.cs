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
                new Order { OrderID=1, MemberID=1, OrderDate=DateTime.Now, OrderStatus="Processing", TotalAmount=100, CreatedAt=DateTime.Now },
                new Order { OrderID = 2, MemberID = 2, OrderDate = DateTime.Now, OrderStatus = "Delivered", TotalAmount = 200, CreatedAt = DateTime.Now },
                new Order { OrderID = 3, MemberID = 3, OrderDate = DateTime.Now, OrderStatus = "Cancelled", TotalAmount = 300, CreatedAt = DateTime.Now },
                new Order { OrderID = 4, MemberID = 4, OrderDate = DateTime.Now, OrderStatus = "Processing", TotalAmount = 800, CreatedAt = DateTime.Now },
                new Order { OrderID = 5, MemberID = 5, OrderDate = DateTime.Now, OrderStatus = "Shipped", TotalAmount = 1000, CreatedAt = DateTime.Now }
                );
            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { OrderDetailID=1, OrderID=1, CourseID=1, PaymentID= 1, Quantity=1, DiscountID=1, UnitPrice=100, Subtotal=100, CreatedAt=DateTime.UtcNow},
                new OrderDetail { OrderDetailID = 2, OrderID = 2, CourseID = 1, PaymentID = 2, Quantity = 2, DiscountID = 1, UnitPrice = 100, Subtotal = 200, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 3, OrderID = 3, CourseID = 1, PaymentID = 3, Quantity = 3, DiscountID = 1, UnitPrice = 100, Subtotal = 300, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 4, OrderID = 4, CourseID = 2, PaymentID = 4, Quantity = 4, DiscountID = 2, UnitPrice = 200, Subtotal = 800, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 5, OrderID = 5, CourseID = 2, PaymentID = 5, Quantity = 5, DiscountID = 2, UnitPrice = 200, Subtotal = 1000, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 6, OrderID = 6, CourseID = 2, PaymentID = 6, Quantity = 6, DiscountID = 2, UnitPrice = 200, Subtotal = 1200, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 7, OrderID = 7, CourseID = 3, PaymentID = 7, Quantity = 7, DiscountID = 3, UnitPrice = 300, Subtotal = 2100, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 8, OrderID = 8, CourseID = 3, PaymentID = 8, Quantity = 8, DiscountID = 3, UnitPrice = 300, Subtotal = 2400, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 9, OrderID = 9, CourseID = 3, PaymentID = 9, Quantity = 9, DiscountID = 3, UnitPrice = 300, Subtotal = 2700, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 10, OrderID = 10, CourseID = 6, PaymentID = 10, Quantity = 3, DiscountID = 6, UnitPrice = 150, Subtotal = 450, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 11, OrderID = 11, CourseID = 6, PaymentID = 11, Quantity = 3, DiscountID = 6, UnitPrice = 150, Subtotal = 450, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 12, OrderID = 12, CourseID = 9, PaymentID = 12, Quantity = 2, DiscountID = 9, UnitPrice = 250, Subtotal = 500, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 13, OrderID = 13, CourseID = 9, PaymentID = 13, Quantity = 3, DiscountID = 9, UnitPrice = 250, Subtotal = 750, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 14, OrderID = 14, CourseID = 10, PaymentID = 14, Quantity = 4, DiscountID = 10, UnitPrice = 300, Subtotal = 1200, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 15, OrderID = 15, CourseID = 10, PaymentID = 15, Quantity = 2, DiscountID = 10, UnitPrice = 300, Subtotal = 600, CreatedAt = DateTime.UtcNow }
                );

                modelBuilder.Entity<Course>().HasData(
                    new Course { CourseID = 1, CourseName = "Dog sit", TrainerID = 1, PetCategory = "dog", CourseCategory ="skill", CourseType = "1by1", Description = "Sitting for 1 hour", ApprovalStatus = "Approved", Price = 100, Location = "Taipei", MaxParticipants = 1, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow,Clicks = 0 },
                    new Course { CourseID = 2, CourseName = "Dog catch", TrainerID = 1, PetCategory = "dog", CourseCategory = "skill", CourseType = "1by1", Description = "catch ball for 1 hour", ApprovalStatus = "Approved", Price = 200, Location = "Taipei", MaxParticipants = 1, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, Clicks = 0 },
                    new Course { CourseID = 3, CourseName = "Dog shake hand", TrainerID = 1, PetCategory = "dog", CourseCategory = "skill", CourseType = "1by1", Description = "shake hand for 1 hour", ApprovalStatus = "Approved", Price = 300, Location = "Taipei", MaxParticipants = 1, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, Clicks = 0 }
                );

        }
        public virtual DbSet<Course> Course { get; set; }

        public virtual DbSet<Trainer> Trainer { get; set; }

        public virtual DbSet<Pet> Pet { get; set; }

        public virtual DbSet<TrainerServiceArea> TrainerServiceArea { get; set; }

        public virtual DbSet<Location> Location { get; set; }

        public virtual DbSet<CourseRating> CourseRating { get; set; }

        public virtual DbSet<Order> Order { get; set; }

        public virtual DbSet<OrderDetail> OrderDetail { get; set; }

        public virtual DbSet<Payment> Payment { get; set; }

        public virtual DbSet<ShoppingCart> Cart { get; set; }

        public virtual DbSet<Discount> Discount { get; set; }

        public virtual DbSet<ClassSchedule> ClassSchedule { get; set; }

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
