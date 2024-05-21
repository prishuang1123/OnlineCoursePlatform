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
            modelBuilder.Entity<Member>()
        .Property(b => b.IsTrainer)
        .IsRequired(false); // 設定為允許null


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
               new Course { CourseID = 1, CourseName = "幼犬初級訓練", TrainerID = 1, PetCategoryID = 1, CourseCategoryID = 1, CourseTypeID = 1, Description = "教您如何教導您的狗基本指令和技巧，如坐下、待命和走路等等。", ApprovalStatus = "通過", Price = 100, LocationID = 1, MaxParticipants = 1, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 21, ThumbnailUrl = "/Img/CourseThumbnail/course1.jpg" },
new Course { CourseID = 2, CourseName = "貓咪玩耍技巧", TrainerID = 2, PetCategoryID = 2, CourseCategoryID = 2, CourseTypeID = 1, Description = "教您如何培養貓咪的遊戲技巧和互動能力，以及運動與娛樂訓練。", ApprovalStatus = "通過", Price = 120, LocationID = 2, MaxParticipants = 1, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 17, ThumbnailUrl = "/Img/CourseThumbnail/course3.jpg" },
new Course { CourseID = 3, CourseName = "狗狗攝食指導", TrainerID = 3, PetCategoryID = 1, CourseCategoryID = 2, CourseTypeID = 2, Description = "教您如何給予狗狗均衡的飲食和營養，以維持健康和活力。", ApprovalStatus = "通過", Price = 90, LocationID = 3, MaxParticipants = 2, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 25, ThumbnailUrl = "/Img/CourseThumbnail/course4.jpg" },
new Course { CourseID = 4, CourseName = "狗狗社交訓練", TrainerID = 4, PetCategoryID = 1, CourseCategoryID = 2, CourseTypeID = 2, Description = "幫助您的狗與其他狗和人建立友好的關係，減少焦慮和攻擊行為。", ApprovalStatus = "通過", Price = 80, LocationID = 4, MaxParticipants = 3, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 14, ThumbnailUrl = "/Img/CourseThumbnail/course5.jpg" },
new Course { CourseID = 5, CourseName = "貓咪基礎訓練", TrainerID = 5, PetCategoryID = 2, CourseCategoryID = 1, CourseTypeID = 2, Description = "學習如何訓練您的貓咪做到基本的動作，例如使用貓砂盆和對聲音指令的回應。", ApprovalStatus = "通過", Price = 110, LocationID = 5, MaxParticipants = 2, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 19, ThumbnailUrl = "/Img/CourseThumbnail/course6.jpg" },
new Course { CourseID = 6, CourseName = "狗狗運動訓練", TrainerID = 6, PetCategoryID = 1, CourseCategoryID = 1, CourseTypeID = 2, Description = "訓練狗狗進行各種運動，如擲球、跑步和障礙訓練，以增強體力和耐力。", ApprovalStatus = "通過", Price = 70, LocationID = 6, MaxParticipants = 5, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 12, ThumbnailUrl = "/Img/CourseThumbnail/course1.jpg" },
new Course { CourseID = 7, CourseName = "貓咪心理療法", TrainerID = 7, PetCategoryID = 2, CourseCategoryID = 2, CourseTypeID = 2, Description = "介紹貓咪的心理狀態和行為問題，並提供治療和紓解方法。", ApprovalStatus = "通過", Price = 100, LocationID = 7, MaxParticipants = 3, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 23, ThumbnailUrl = "/Img/CourseThumbnail/course2.jpg" },
new Course { CourseID = 8, CourseName = "狗狗護理實務", TrainerID = 8, PetCategoryID = 1, CourseCategoryID = 2, CourseTypeID = 2, Description = "學習如何給予狗狗良好的護理，包括洗澡、梳毛、剪指甲等日常護理技巧。", ApprovalStatus = "通過", Price = 130, LocationID = 8, MaxParticipants = 2, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 18, ThumbnailUrl = "/Img/CourseThumbnail/course3.jpg" },
new Course { CourseID = 9, CourseName = "貓咪飲食指導", TrainerID = 9, PetCategoryID = 2, CourseCategoryID = 2, CourseTypeID = 2, Description = "指導您如何挑選合適的貓咪食品，以及如何處理貓咪的特殊飲食需求。", ApprovalStatus = "通過", Price = 95, LocationID = 9, MaxParticipants = 6, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 20, ThumbnailUrl = "/Img/CourseThumbnail/course4.jpg" },
new Course { CourseID = 10, CourseName = "狗狗心理訓練", TrainerID = 10, PetCategoryID = 1, CourseCategoryID = 2, CourseTypeID = 2, Description = "透過心理學原理，幫助您了解和解決狗狗的行為問題，提高狗狗的心理健康。", ApprovalStatus = "通過", Price = 85, LocationID = 15, MaxParticipants = 6, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 16, ThumbnailUrl = "/Img/CourseThumbnail/course1.jpg" },
new Course { CourseID = 11, CourseName = "貓咪攝食指南", TrainerID = 1, PetCategoryID = 2, CourseCategoryID = 2, CourseTypeID = 1, Description = "提供關於貓咪飲食、營養和餵食方式的專業指導和建議。", ApprovalStatus = "通過", Price = 85, LocationID = 10, MaxParticipants = 1, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 16, ThumbnailUrl = "/Img/CourseThumbnail/course4.jpg" },
new Course { CourseID = 12, CourseName = "狗狗訓練工具應用", TrainerID = 2, PetCategoryID = 1, CourseCategoryID = 2, CourseTypeID = 2, Description = "介紹和示範各種訓練工具的使用方法，如點擊器、項圈和玩具。", ApprovalStatus = "通過", Price = 75, LocationID = 11, MaxParticipants = 2, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 22, ThumbnailUrl = "/Img/CourseThumbnail/course2.jpg" },
new Course { CourseID = 13, CourseName = "貓咪健康檢查", TrainerID = 3, PetCategoryID = 2, CourseCategoryID = 2, CourseTypeID = 2, Description = "教您如何給貓咪進行基本的健康檢查，包括檢查牙齒、耳朵和毛皮。", ApprovalStatus = "通過", Price = 80, LocationID = 12, MaxParticipants = 3, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 23, ThumbnailUrl = "/Img/CourseThumbnail/course5.jpg" },
new Course { CourseID = 14, CourseName = "狗狗行為矯正", TrainerID = 4, PetCategoryID = 1, CourseCategoryID = 2, CourseTypeID = 1, Description = "幫助您了解狗狗的不良行為根源，並提供有效的矯正和改善方法。", ApprovalStatus = "通過", Price = 90, LocationID = 13, MaxParticipants = 1, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 19, ThumbnailUrl = "/Img/CourseThumbnail/course3.jpg" },
new Course { CourseID = 15, CourseName = "貓咪社交化培訓", TrainerID = 5, PetCategoryID = 2, CourseCategoryID = 2, CourseTypeID = 2, Description = "教您如何幫助貓咪建立社交技巧，與其他貓咪和人類和睦相處。", ApprovalStatus = "通過", Price = 100, LocationID = 14, MaxParticipants = 5, EnrollmentCount = 0, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Clicks = 20, ThumbnailUrl = "/Img/CourseThumbnail/course1.jpg" }
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
                   Name = "林宜萱",
                   Email = "wang@example.com",
                   Phone = "0987654321",
                   Birthday = new DateTime(1995, 8, 20),
                   RegistrationDate = DateTime.Now,
                   ResidenceArea = "臺北市",
                   IsTrainer = false,
                   IsAdministrator = false,
                   Address = "忠孝東路四段123號5樓"
			   },
  new Member
  {
      MemberID = 2,
      Name = "吳偉昌",
      Email = "lin@example.com",
      Phone = "0912345678",
      Birthday = new DateTime(1988, 3, 10),
      RegistrationDate = DateTime.Now,
      ResidenceArea = "新北市",
      IsTrainer = false,
      IsAdministrator = false,
	  Address = "和平西路三段45巷9號2樓"
  },
  new Member
  {
      MemberID = 3,
      Name = "黃文彥",
      Email = "zhang@example.com",
      Phone = "0922334455",
      Birthday = new DateTime(1992, 11, 5),
      RegistrationDate = DateTime.Now,
      ResidenceArea = "台中市",
      IsTrainer = false,
      IsAdministrator = false,
      Address = "中山北路一段89巷6弄15號"
  },
  new Member
  {
      MemberID = 4,
      Name = "張明志",
      Email = "chen@example.com",
      Phone = "0955667788",
      Birthday = new DateTime(1997, 6, 25),
      RegistrationDate = DateTime.Now,
      ResidenceArea = "高雄市",
      IsTrainer = false,
      IsAdministrator = false,
      Address = "民權東路六段78號3樓之1",
  },
  new Member
  {
      MemberID = 5,
      Name = "許淑惠",
      Email = "li@example.com",
      Phone = "0933123456",
      Birthday = new DateTime(1985, 9, 12),
      RegistrationDate = DateTime.Now,
      ResidenceArea = "桃園市",
      IsTrainer = false,
      IsAdministrator = false,
      Address = "南京東路五段300號12樓"
  },
  new Member
  {
      MemberID = 6,
      Name = "李志明",
      Email = "wu@example.com",
      Phone = "0977889900",
      Birthday = new DateTime(1980, 12, 30),
      RegistrationDate = DateTime.Now,
      ResidenceArea = "台南市",
      IsTrainer = false,
      IsAdministrator = false,
      Address = "仁愛路四段101號8樓"
  },
  new Member
  {
      MemberID = 7,
      Name = "徐宜真",
      Email = "xu@example.com",
      Phone = "0911223344",
      Birthday = new DateTime(1990, 7, 8),
      RegistrationDate = DateTime.Now,
      ResidenceArea = "基隆市",
      IsTrainer = false,
      IsAdministrator = false,
      Address = "新生南路二段38號4樓"
  },
  new Member
  {
      MemberID = 8,
      Name = "蔡文偉",
      Email = "cai@example.com",
      Phone = "0988777666",
      Birthday = new DateTime(1983, 2, 18),
      RegistrationDate = DateTime.Now,
      ResidenceArea = "新竹市",
      IsTrainer = false,
      IsAdministrator = false,
      Address = "信義路五段220巷16弄2號"
  },
  new Member
  {
      MemberID = 9,
      Name = "楊宜真",
      Email = "qiu@example.com",
      Phone = "0966888999",
      Birthday = new DateTime(1993, 4, 7),
      RegistrationDate = DateTime.Now,
      ResidenceArea = "嘉義市",
      IsTrainer = false,
      IsAdministrator = false,
      Address = "敦化南路二段123巷56弄4樓"
  },
  new Member
  {
      MemberID = 10,
      Name = "陳志宏",
      Email = "ye@example.com",
      Phone = "0944556677",
      Birthday = new DateTime(1998, 1, 15),
      RegistrationDate = DateTime.Now,
      ResidenceArea = "臺北市",
      IsTrainer = false,
      IsAdministrator = false,
      Address = "建國北路二段88號7樓"
  }

            );

            modelBuilder.Entity<Trainer>().HasData(
                 new Trainer
                 {
                     TrainerID = 1,
                     MemberID = 1,
                     TrainerName = "林宜萱",
                     SpecializationID = 1,
                     Experience = "具有10年專業犬隻訓練經驗",
                     Qualifications = "認證專業犬隻訓練師 (CPDT-KA)",
                     Status = "已審核"
                 },
   new Trainer
   {
       TrainerID = 2,
       MemberID = 2,
       TrainerName = "吳偉昌",
       SpecializationID = 2,
       Experience = "具有9年專業貓咪訓練經驗",
       Qualifications = "認證專業貓咪訓練與行為專家 (CFTBS)",
       Status = "已審核"
   },
  new Trainer
  {
      TrainerID = 3,
      MemberID = 3,
      TrainerName = "黃文彥",
      SpecializationID = 1,
      Experience = "擁有15年專業狗隻訓練經驗",
      Qualifications = "認證專業犬隻訓練師 (CPDT-KA)",
      Status = "已審核"
  },
   new Trainer
   {
       TrainerID = 4,
       MemberID = 4,
       TrainerName = "張明志",
       SpecializationID = 2,
       Experience = "具有12年專業貓咪訓練經驗",
       Qualifications = "認證專業貓咪訓練師 (CPT-KA)",
       Status = "已審核"
   },
   new Trainer
   {
       TrainerID = 5,
       MemberID = 5,
       TrainerName = "許淑惠",
       SpecializationID = 3,
       Experience = "擁有9年專業狗隻服從訓練經驗",
       Qualifications = "認證專業狗隻訓練師 (CPDT-KA)",
       Status = "已審核"
   },
   new Trainer
   {
       TrainerID = 6,
       MemberID = 6,
       TrainerName = "李志明",
       SpecializationID = 4,
       Experience = "擁有10年專業貓咪基礎訓練經驗",
       Qualifications = "認證專業貓咪訓練師 (CPT-KA)",
       Status = "已審核"
   },
   new Trainer
   {
       TrainerID = 7,
       MemberID = 7,
       TrainerName = "徐宜真",
       SpecializationID = 5,
       Experience = "擁有7年專業狗隻行為改善經驗",
       Qualifications = "認證專業狗隻訓練師 (CPDT-KA)",
       Status = "已審核"
   },
   new Trainer
   {
       TrainerID = 8,
       MemberID = 8,
       TrainerName = "蔡文偉",
       SpecializationID = 6,
       Experience = "擁有9年專業貓咪行為矯正經驗",
       Qualifications = "認證專業貓咪訓練師 (CPT-KA)",
       Status = "已審核"
   },
   new Trainer
   {
       TrainerID = 9,
       MemberID = 9,
       TrainerName = "楊宜真",
       SpecializationID = 7,
       Experience = "擁有6年專業狗隻服從訓練經驗",
       Qualifications = "認證專業狗隻訓練師 (CPDT-KA)",
       Status = "已審核"
   },
   new Trainer
   {
       TrainerID = 10,
       MemberID = 10,
       TrainerName = "陳志宏",
       SpecializationID = 4,
       Experience = "擁有5年專業貓咪基礎訓練經驗",
       Qualifications = "認證專業貓咪訓練師 (CPT-KA)",
       Status = "已審核"
   }
            );

            modelBuilder.Entity<CourseCategory>().HasData(
                    new CourseCategory
                    {
                        CourseCategoryID = 1,
                        CourseCategoryName = "運動"
                    },
                    new CourseCategory
                    {
                        CourseCategoryID = 2,
                        CourseCategoryName = "技能"
                    },
                    new CourseCategory
                    {
                        CourseCategoryID = 3,
                        CourseCategoryName = "陪玩"
                    }
                );

            // 生成台灣全縣市的假資料
            List<string> taiwanCities = new List<string>
        {
            "臺北市", "新北市", "桃園市", "臺中市", "臺南市", "高雄市",
            "基隆市", "新竹市", "嘉義市", "新竹縣", "苗栗縣", "彰化縣",
            "南投縣", "雲林縣", "嘉義縣", "屏東縣", "宜蘭縣", "花蓮縣",
            "臺東縣", "澎湖縣", "金門縣", "連江縣"
        };

            int id = 1;
            foreach (var city in taiwanCities)
            {
                modelBuilder.Entity<Location>().HasData(new Location
                {
                    LocationID = id++,
                    LocationName = city
                });
            }

            modelBuilder.Entity<CourseType>().HasData(
                new CourseType
                {
                    CourseTypeID = 1,
                    CourseTypeName = "一對一"
                },
                new CourseType
                {
                    CourseTypeID = 2,
                    CourseTypeName = "團課"
                }
            );

            modelBuilder.Entity<PetCategory>().HasData(
                new PetCategory
                {
                    PetCategoryID = 1,
                    PetCategoryName = "狗"
                },
                new PetCategory
                {
                    PetCategoryID = 2,
                    PetCategoryName = "貓"
                }
            );

            modelBuilder.Entity<Specialization>().HasData(
                new Specialization
                {
                    SpecializationID = 1,
                    SpecializationName="犬隻行為調教"
                },
                new Specialization
                {
                    SpecializationID = 2,
                    SpecializationName = "貓咪行為諮詢"
                },
                new Specialization
                {
                    SpecializationID = 3,
                    SpecializationName = "犬隻服從訓練"
                },
                new Specialization
                {
                    SpecializationID = 4,
                    SpecializationName = "貓咪基礎訓練"
                },
                new Specialization
                {
                    SpecializationID = 5,
                    SpecializationName = "犬隻行為改善"
                },
                new Specialization
                {
                    SpecializationID = 6,
                    SpecializationName = "貓咪行為矯正"
                },
                new Specialization
                {
                    SpecializationID = 7,
                    SpecializationName = "犬隻服從訓練"
                },
                new Specialization
                {
                    SpecializationID = 8,
                    SpecializationName = "犬隻基礎訓練"
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
		public virtual DbSet<FollowItem> FollowItem { get; set; }

        public virtual DbSet<Specialization> Specialization { get; set; }

        public virtual DbSet<PetCategory> PetCategory { get; set; }

        public virtual DbSet<CourseType> CourseType { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Database=ProjectDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }
    }
}
