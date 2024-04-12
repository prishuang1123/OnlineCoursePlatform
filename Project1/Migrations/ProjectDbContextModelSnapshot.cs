﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project1.Data;

#nullable disable

namespace Project1.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    partial class ProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project1.Models.ClassSchedule", b =>
                {
                    b.Property<int>("SchedulerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchedulerID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Scheduler")
                        .HasColumnType("datetime2");

                    b.HasKey("SchedulerID");

                    b.ToTable("ClassSchedule");
                });

            modelBuilder.Entity("Project1.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"));

                    b.Property<string>("ApprovalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Clicks")
                        .HasColumnType("int");

                    b.Property<string>("CourseCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DiscountID")
                        .HasColumnType("int");

                    b.Property<int?>("EnrollmentCount")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaxParticipants")
                        .HasColumnType("int");

                    b.Property<string>("PetCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TrainerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CourseID");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            CourseID = 1,
                            ApprovalStatus = "Approved",
                            Clicks = 0,
                            CourseCategory = "skill",
                            CourseName = "Dog sit",
                            CourseType = "1by1",
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(894),
                            Description = "Sitting for 1 hour",
                            EnrollmentCount = 0,
                            Location = "Taipei",
                            MaxParticipants = 1,
                            PetCategory = "dog",
                            Price = 100m,
                            TrainerID = 1,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CourseID = 2,
                            ApprovalStatus = "Approved",
                            Clicks = 0,
                            CourseCategory = "skill",
                            CourseName = "Dog catch",
                            CourseType = "1by1",
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(897),
                            Description = "catch ball for 1 hour",
                            EnrollmentCount = 0,
                            Location = "Taipei",
                            MaxParticipants = 1,
                            PetCategory = "dog",
                            Price = 200m,
                            TrainerID = 1,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CourseID = 3,
                            ApprovalStatus = "Approved",
                            Clicks = 0,
                            CourseCategory = "skill",
                            CourseName = "Dog shake hand",
                            CourseType = "1by1",
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(899),
                            Description = "shake hand for 1 hour",
                            EnrollmentCount = 0,
                            Location = "Taipei",
                            MaxParticipants = 1,
                            PetCategory = "dog",
                            Price = 300m,
                            TrainerID = 1,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Project1.Models.CourseRating", b =>
                {
                    b.Property<int>("CourseRatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseRatingID"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("RatingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrainerID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CourseRatingID");

                    b.ToTable("CourseRating");
                });

            modelBuilder.Entity("Project1.Models.Discount", b =>
                {
                    b.Property<int>("DiscountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiscountID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiscountDESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiscountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountPercentage")
                        .HasColumnType("float");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DiscountID");

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("Project1.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationID"));

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Project1.Models.Member", b =>
                {
                    b.Property<int>("MemberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberID"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdministrator")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTrainer")
                        .HasColumnType("bit");

                    b.Property<string>("MemberType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResidenceArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberID");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("Project1.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderID");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            OrderID = 1,
                            CreatedAt = new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(821),
                            MemberID = 1,
                            OrderDate = new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(811),
                            OrderStatus = "Processing",
                            TotalAmount = 100m
                        },
                        new
                        {
                            OrderID = 2,
                            CreatedAt = new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(823),
                            MemberID = 2,
                            OrderDate = new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(822),
                            OrderStatus = "Delivered",
                            TotalAmount = 200m
                        },
                        new
                        {
                            OrderID = 3,
                            CreatedAt = new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(825),
                            MemberID = 3,
                            OrderDate = new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(824),
                            OrderStatus = "Cancelled",
                            TotalAmount = 300m
                        },
                        new
                        {
                            OrderID = 4,
                            CreatedAt = new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(826),
                            MemberID = 4,
                            OrderDate = new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(825),
                            OrderStatus = "Processing",
                            TotalAmount = 800m
                        },
                        new
                        {
                            OrderID = 5,
                            CreatedAt = new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(828),
                            MemberID = 5,
                            OrderDate = new DateTime(2024, 4, 12, 11, 22, 12, 240, DateTimeKind.Local).AddTicks(827),
                            OrderStatus = "Shipped",
                            TotalAmount = 1000m
                        });
                });

            modelBuilder.Entity("Project1.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DiscountID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailID");

                    b.ToTable("OrderDetail");

                    b.HasData(
                        new
                        {
                            OrderDetailID = 1,
                            CourseID = 1,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(847),
                            DiscountID = 1,
                            OrderID = 1,
                            PaymentID = 1,
                            Quantity = 1,
                            Subtotal = 100m,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 2,
                            CourseID = 1,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(849),
                            DiscountID = 1,
                            OrderID = 2,
                            PaymentID = 2,
                            Quantity = 2,
                            Subtotal = 200m,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 3,
                            CourseID = 1,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(851),
                            DiscountID = 1,
                            OrderID = 3,
                            PaymentID = 3,
                            Quantity = 3,
                            Subtotal = 300m,
                            UnitPrice = 100m
                        },
                        new
                        {
                            OrderDetailID = 4,
                            CourseID = 2,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(853),
                            DiscountID = 2,
                            OrderID = 4,
                            PaymentID = 4,
                            Quantity = 4,
                            Subtotal = 800m,
                            UnitPrice = 200m
                        },
                        new
                        {
                            OrderDetailID = 5,
                            CourseID = 2,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(855),
                            DiscountID = 2,
                            OrderID = 5,
                            PaymentID = 5,
                            Quantity = 5,
                            Subtotal = 1000m,
                            UnitPrice = 200m
                        },
                        new
                        {
                            OrderDetailID = 6,
                            CourseID = 2,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(857),
                            DiscountID = 2,
                            OrderID = 6,
                            PaymentID = 6,
                            Quantity = 6,
                            Subtotal = 1200m,
                            UnitPrice = 200m
                        },
                        new
                        {
                            OrderDetailID = 7,
                            CourseID = 3,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(859),
                            DiscountID = 3,
                            OrderID = 7,
                            PaymentID = 7,
                            Quantity = 7,
                            Subtotal = 2100m,
                            UnitPrice = 300m
                        },
                        new
                        {
                            OrderDetailID = 8,
                            CourseID = 3,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(861),
                            DiscountID = 3,
                            OrderID = 8,
                            PaymentID = 8,
                            Quantity = 8,
                            Subtotal = 2400m,
                            UnitPrice = 300m
                        },
                        new
                        {
                            OrderDetailID = 9,
                            CourseID = 3,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(862),
                            DiscountID = 3,
                            OrderID = 9,
                            PaymentID = 9,
                            Quantity = 9,
                            Subtotal = 2700m,
                            UnitPrice = 300m
                        },
                        new
                        {
                            OrderDetailID = 10,
                            CourseID = 6,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(864),
                            DiscountID = 6,
                            OrderID = 10,
                            PaymentID = 10,
                            Quantity = 3,
                            Subtotal = 450m,
                            UnitPrice = 150m
                        },
                        new
                        {
                            OrderDetailID = 11,
                            CourseID = 6,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(866),
                            DiscountID = 6,
                            OrderID = 11,
                            PaymentID = 11,
                            Quantity = 3,
                            Subtotal = 450m,
                            UnitPrice = 150m
                        },
                        new
                        {
                            OrderDetailID = 12,
                            CourseID = 9,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(867),
                            DiscountID = 9,
                            OrderID = 12,
                            PaymentID = 12,
                            Quantity = 2,
                            Subtotal = 500m,
                            UnitPrice = 250m
                        },
                        new
                        {
                            OrderDetailID = 13,
                            CourseID = 9,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(869),
                            DiscountID = 9,
                            OrderID = 13,
                            PaymentID = 13,
                            Quantity = 3,
                            Subtotal = 750m,
                            UnitPrice = 250m
                        },
                        new
                        {
                            OrderDetailID = 14,
                            CourseID = 10,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(871),
                            DiscountID = 10,
                            OrderID = 14,
                            PaymentID = 14,
                            Quantity = 4,
                            Subtotal = 1200m,
                            UnitPrice = 300m
                        },
                        new
                        {
                            OrderDetailID = 15,
                            CourseID = 10,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(872),
                            DiscountID = 10,
                            OrderID = 15,
                            PaymentID = 15,
                            Quantity = 2,
                            Subtotal = 600m,
                            UnitPrice = 300m
                        });
                });

            modelBuilder.Entity("Project1.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentID");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Project1.Models.Pet", b =>
                {
                    b.Property<int>("PetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PetID"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<string>("PetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PetType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("PetID");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("Project1.Models.ShoppingCart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartID");

                    b.ToTable("Cart");

                    b.HasData(
                        new
                        {
                            CartID = 1,
                            CourseID = 1,
                            CreatedAt = new DateTime(2024, 4, 12, 3, 22, 12, 240, DateTimeKind.Utc).AddTicks(723),
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("Project1.Models.Trainer", b =>
                {
                    b.Property<int>("TrainerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainerID"));

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<string>("Qualifications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainerID");

                    b.ToTable("Trainer");
                });

            modelBuilder.Entity("Project1.Models.TrainerServiceArea", b =>
                {
                    b.Property<int>("TeachingAreaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeachingAreaID"));

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<int>("TrainerID")
                        .HasColumnType("int");

                    b.HasKey("TeachingAreaID");

                    b.ToTable("TrainerServiceArea");
                });
#pragma warning restore 612, 618
        }
    }
}
