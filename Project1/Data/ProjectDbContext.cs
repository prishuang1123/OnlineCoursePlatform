using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Data
{
    public class ProjectDbContext : DbContext
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
                new ShoppingCart { CartID = 1, CourseID = 1, Quantity = 1, CreatedAt = DateTime.UtcNow }
                );

            modelBuilder.Entity<Order>().HasData(
                new Order { OrderID = 1, MemberID = 1, OrderDate = DateTime.Now, OrderStatus = "Processing", TotalAmount = 100, CreatedAt = DateTime.Now, },
                new Order { OrderID = 2, MemberID = 2, OrderDate = DateTime.Now, OrderStatus = "Delivered", TotalAmount = 200, CreatedAt = DateTime.Now },
                new Order { OrderID = 3, MemberID = 3, OrderDate = DateTime.Now, OrderStatus = "Cancelled", TotalAmount = 300, CreatedAt = DateTime.Now },
                new Order { OrderID = 4, MemberID = 4, OrderDate = DateTime.Now, OrderStatus = "Processing", TotalAmount = 800, CreatedAt = DateTime.Now },
                new Order { OrderID = 5, MemberID = 5, OrderDate = DateTime.Now, OrderStatus = "Shipped", TotalAmount = 1000, CreatedAt = DateTime.Now }
                );

            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { OrderDetailID = 1, OrderID = 1, CourseID = 1, Quantity = 2, UnitPrice = 100, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 2, OrderID = 1, CourseID = 2, Quantity = 4, UnitPrice = 100, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 3, OrderID = 1, CourseID = 3, Quantity = 3, UnitPrice = 100, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 4, OrderID = 2, CourseID = 4, Quantity = 3, UnitPrice = 100, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 5, OrderID = 2, CourseID = 5, Quantity = 3, UnitPrice = 100, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 6, OrderID = 2, CourseID = 3, Quantity = 2, UnitPrice = 100, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 7, OrderID = 3, CourseID = 3, Quantity = 5, UnitPrice = 100, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 8, OrderID = 3, CourseID = 4, Quantity = 7, UnitPrice = 100, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 9, OrderID = 4, CourseID = 2, Quantity = 6, UnitPrice = 100, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 10, OrderID = 4, CourseID = 3, Quantity = 8, UnitPrice = 100, CreatedAt = DateTime.UtcNow },
                new OrderDetail { OrderDetailID = 11, OrderID = 4, CourseID = 3, Quantity = 8, UnitPrice = 100, CreatedAt = DateTime.UtcNow }




                );

            modelBuilder.Entity<Course>().HasData(
               new Course { CourseID = 1, CourseName = "幼犬訓練", TrainerID = 1, PetCategory = "狗", CourseCategoryID = 1, CourseType = "一對一", Description = "幼犬基本訓練", ApprovalStatus = "通過", Price = 100, LocationID = 1, MaxParticipants = 1, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 21 },
               new Course { CourseID = 2, CourseName = "幼犬訓練", TrainerID = 1, PetCategory = "狗", CourseCategoryID = 1, CourseType = "一對一", Description = "幼犬基本訓練", ApprovalStatus = "通過", Price = 100, LocationID = 1, MaxParticipants = 1, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 21 },
               new Course { CourseID = 3, CourseName = "幼犬訓練", TrainerID = 1, PetCategory = "狗", CourseCategoryID = 1, CourseType = "一對一", Description = "幼犬基本訓練", ApprovalStatus = "通過", Price = 100, LocationID = 1, MaxParticipants = 1, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 21 },
               new Course { CourseID = 4, CourseName = "幼犬訓練", TrainerID = 1, PetCategory = "狗", CourseCategoryID = 1, CourseType = "一對一", Description = "幼犬基本訓練", ApprovalStatus = "通過", Price = 100, LocationID = 1, MaxParticipants = 1, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 21 },
               new Course { CourseID = 5, CourseName = "幼犬訓練", TrainerID = 1, PetCategory = "狗", CourseCategoryID = 1, CourseType = "一對一", Description = "幼犬基本訓練", ApprovalStatus = "通過", Price = 100, LocationID = 1, MaxParticipants = 1, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 21 }
            );

            modelBuilder.Entity<CourseRating>().HasData(
                new CourseRating { CourseRatingID = 1, CourseID = 1, TrainerID = 1, UserID = 1, Rating = 5, Comment = "好學習", RatingDate = DateTime.UtcNow },
                new CourseRating { CourseRatingID = 2, CourseID = 1, TrainerID = 1, UserID = 3, Rating = 4, Comment = "好學習", RatingDate = DateTime.UtcNow },
                new CourseRating { CourseRatingID = 3, CourseID = 1, TrainerID = 1, UserID = 2, Rating = 3, Comment = "好學習", RatingDate = DateTime.UtcNow },
                new CourseRating { CourseRatingID = 4, CourseID = 2, TrainerID = 1, UserID = 1, Rating = 4, Comment = "好學習", RatingDate = DateTime.UtcNow },
                new CourseRating { CourseRatingID = 5, CourseID = 2, TrainerID = 1, UserID = 3, Rating = 5, Comment = "好學習", RatingDate = DateTime.UtcNow },
                new CourseRating { CourseRatingID = 6, CourseID = 2, TrainerID = 1, UserID = 2, Rating = 5, Comment = "好學習", RatingDate = DateTime.UtcNow },
                new CourseRating { CourseRatingID = 7, CourseID = 3, TrainerID = 1, UserID = 1, Rating = 5, Comment = "好學習", RatingDate = DateTime.UtcNow },
                new CourseRating { CourseRatingID = 8, CourseID = 3, TrainerID = 1, UserID = 3, Rating = 5, Comment = "好學習", RatingDate = DateTime.UtcNow },
                new CourseRating { CourseRatingID = 9, CourseID = 3, TrainerID = 1, UserID = 2, Rating = 3, Comment = "好學習", RatingDate = DateTime.UtcNow },
                new CourseRating { CourseRatingID = 10, CourseID = 4, TrainerID = 1, UserID = 1, Rating = 3, Comment = "好學習", RatingDate = DateTime.UtcNow },
                new CourseRating { CourseRatingID = 11, CourseID = 4, TrainerID = 1, UserID = 3, Rating = 3, Comment = "好學習", RatingDate = DateTime.UtcNow },
                new CourseRating { CourseRatingID = 12, CourseID = 4, TrainerID = 1, UserID = 2, Rating = 4, Comment = "好學習", RatingDate = DateTime.UtcNow },
                new CourseRating { CourseRatingID = 13, CourseID = 5, TrainerID = 1, UserID = 1, Rating = 5, Comment = "好學習", RatingDate = DateTime.UtcNow },
                new CourseRating { CourseRatingID = 14, CourseID = 5, TrainerID = 1, UserID = 3, Rating = 5, Comment = "好學習", RatingDate = DateTime.UtcNow },
                new CourseRating { CourseRatingID = 15, CourseID = 5, TrainerID = 1, UserID = 2, Rating = 5, Comment = "好學習", RatingDate = DateTime.UtcNow }
                );

            modelBuilder.Entity<Member>().HasData(
               new Member
               {
                   MemberID = 1,
                   Name = "John Doe",
                   Email = "john@example.com",
                   Phone = "1234567890",
                   Birthday = new DateTime(1990, 5, 15),
                   RegistrationDate = DateTime.Now,
                   ResidenceArea = "Taipei",
                   IsTrainer = false,
                   IsAdministrator = false
               },
               new Member
               {
                   MemberID = 2,
                   Name = "Jane Smith",
                   Email = "jane@example.com",
                   Phone = "0987654321",
                   Birthday = new DateTime(1985, 8, 20),
                   RegistrationDate = DateTime.Now,
                   ResidenceArea = "New York",
                   IsTrainer = false,
                   IsAdministrator = false
               },
               new Member
               {
                   MemberID = 3,
                   Name = "Emily Johnson",
                   Email = "emily@example.com",
                   Phone = "1357924680",
                   Birthday = new DateTime(1988, 10, 8),
                   RegistrationDate = DateTime.Now,
                   ResidenceArea = "Los Angeles",
                   IsTrainer = false,
                   IsAdministrator = false
               },
               new Member
               {
                   MemberID = 4,
                   Name = "Michael Brown",
                   Email = "michael@example.com",
                   Phone = "1122334455",
                   Birthday = new DateTime(1975, 3, 25),
                   RegistrationDate = DateTime.Now,
                   ResidenceArea = "London",
                   IsTrainer = true,
                   IsAdministrator = false
               },
               new Member
               {
                   MemberID = 5,
                   Name = "Sophia Wilson",
                   Email = "sophia@example.com",
                   Phone = "9988776655",
                   Birthday = new DateTime(1995, 12, 12),
                   RegistrationDate = DateTime.Now,
                   ResidenceArea = "Paris",
                   IsTrainer = false,
                   IsAdministrator = true
               }


            );

            modelBuilder.Entity<Trainer>().HasData(
                new Trainer
                {
                    TrainerID = 1,
                    MemberID = 4, 
                    TrainerName = "張三",
                    Specialization = "舉重",
                    Experience = "10年舉重訓練經驗",
                    Qualifications = "認證個人教練",
                    Status = "已審核"
                },
                new Trainer
                {
                    TrainerID = 2,
                    MemberID = 7,
                    TrainerName = "李四",
                    Specialization = "瑜伽",
                    Experience = "8年瑜伽教學經驗",
                    Qualifications = "註冊瑜伽導師",
                    Status = "已審核"
                },
                new Trainer
                {
                    TrainerID = 3,
                    MemberID = 2,
                    TrainerName = "王五",
                    Specialization = "游泳",
                    Experience = "15年游泳教學經驗",
                    Qualifications = "國家游泳教練證書",
                    Status = "已審核"
                },
                new Trainer
                {
                    TrainerID = 4,
                    MemberID = 5,
                    TrainerName = "劉六",
                    Specialization = "有氧運動",
                    Experience = "12年有氧運動指導經驗",
                    Qualifications = "健身教練證書",
                    Status = "已審核"
                },
                new Trainer
                {
                    TrainerID = 5,
                    MemberID = 8,
                    TrainerName = "陳七",
                    Specialization = "網球",
                    Experience = "20年網球教學經驗",
                    Qualifications = "國際網球協會認證",
                    Status = "已審核"
                },
                new Trainer
                {
                    TrainerID = 6,
                    MemberID = 9,
                    TrainerName = "林八",
                    Specialization = "拳擊",
                    Experience = "專業拳擊手",
                    Qualifications = "拳擊教練證書",
                    Status = "已審核"
                },
                new Trainer
                {
                    TrainerID = 7,
                    MemberID = 10,
                    TrainerName = "黃九",
                    Specialization = "武術",
                    Experience = "多年武術修煉經驗",
                    Qualifications = "武術大師",
                    Status = "已審核"
                },
                new Trainer
                {
                    TrainerID = 8,
                    MemberID = 3,
                    TrainerName = "蔡十",
                    Specialization = "瑜伽",
                    Experience = "5年瑜伽教學經驗",
                    Qualifications = "瑜伽教練執照",
                    Status = "已審核"
                },
                new Trainer
                {
                    TrainerID = 9,
                    MemberID = 6,
                    TrainerName = "許十一",
                    Specialization = "慢跑",
                    Experience = "馬拉松選手",
                    Qualifications = "專業跑者",
                    Status = "已審核"
                },
                new Trainer
                {
                    TrainerID = 10,
                    MemberID = 1,
                    TrainerName = "余十二",
                    Specialization = "籃球",
                    Experience = "校隊隊長",
                    Qualifications = "籃球教練執照",
                    Status = "已審核"
                }
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
        //public object Courses { get; internal set; }

        public virtual DbSet<Blog> Blog { get; set; }  

        public virtual DbSet<CourseCategory> CourseCategory { get; set; }

        public virtual DbSet<Images> Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Database=ProjectDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }
    }
}
