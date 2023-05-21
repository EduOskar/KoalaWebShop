﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppMVC.Data;

#nullable disable

namespace WebAppMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebAppMVC.Models.Cart", b =>
                {
                    b.Property<int>("cartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cartId"));

                    b.Property<int>("FkCustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("KoalaIdId")
                        .HasColumnType("int");

                    b.HasKey("cartId");

                    b.HasIndex("KoalaIdId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("WebAppMVC.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 5,
                            Content = "Everything used in sports can be found in this category",
                            Title = "Sport"
                        },
                        new
                        {
                            CategoryId = 6,
                            Content = "Everything used in fashion can be found in this category",
                            Title = "Fashion"
                        },
                        new
                        {
                            CategoryId = 7,
                            Content = "Everything used in outdoor life can be found in this category",
                            Title = "Outdoor life"
                        },
                        new
                        {
                            CategoryId = 8,
                            Content = "Everything used in Electronic can be found in this category",
                            Title = "Electronic"
                        });
                });

            modelBuilder.Entity("WebAppMVC.Models.KoalaCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 11,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet101",
                            ConcurrencyStamp = "779a7cd8-130e-4aa7-93e5-446aed4e8152",
                            Email = "jon.westman@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Jon",
                            LastName = "Westman",
                            LockoutEnabled = true,
                            NormalizedEmail = "JON.WESTMAN@MAIL.COM",
                            NormalizedUserName = "JON.WESTMAN@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6114),
                            SecurityStamp = "OYOPO3Q3X7Z3D65G4A5RIJRWMGE2WPMPKPWKT7JIBJF3VG6VJ4NA",
                            TwoFactorEnabled = false,
                            UserName = "jon.westman@mail.com"
                        },
                        new
                        {
                            Id = 12,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet102",
                            ConcurrencyStamp = "2d518292-ad86-4797-ad33-05ab0047d2db",
                            Email = "bjorn.agnemo@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Björn",
                            LastName = "Agnemo",
                            LockoutEnabled = true,
                            NormalizedEmail = "BJORN.AGNEMO@MAIL.COM",
                            NormalizedUserName = "BJORN.AGNEMO@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6210),
                            SecurityStamp = "JQUPMFAP5OFMWVEU25IWA7IHY4YG7SQTVDUI7VU3ARUHZBBZPN5A",
                            TwoFactorEnabled = false,
                            UserName = "bjorn.agnemo@mail.com"
                        },
                        new
                        {
                            Id = 13,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet103",
                            ConcurrencyStamp = "73b919fe-426d-4175-be51-8d1e5d123715",
                            Email = "Oskar.Ahling@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Oskar",
                            LastName = "Åhling",
                            LockoutEnabled = true,
                            NormalizedEmail = "OSKAR.AHLING@MAIL.COM",
                            NormalizedUserName = "OSKAR.AHLING@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6220),
                            SecurityStamp = "F33ZIG3LMMNCGSETL2AN4JTJN2657BASY4J72A6NGDOSRBYH5UZA",
                            TwoFactorEnabled = false,
                            UserName = "Oskar.Ahling@mail.com"
                        },
                        new
                        {
                            Id = 14,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet104",
                            ConcurrencyStamp = "25734deb-ae93-4b1d-9ecf-e58065f22c7e",
                            Email = "Reidar.Nilsen@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Reidar",
                            LastName = "Nilsen",
                            LockoutEnabled = true,
                            NormalizedEmail = "REIDAR.NILSEN@MAIL.COM",
                            NormalizedUserName = "REIDAR.NILSEN@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6229),
                            SecurityStamp = "622VTMMPQULDRA5V4QQ47HRHIB6HKR5ZHVMHOH3YS5KPK6ESBJOA",
                            TwoFactorEnabled = false,
                            UserName = "Reidar.Nilsen@mail.com"
                        },
                        new
                        {
                            Id = 15,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet105",
                            ConcurrencyStamp = "e45422da-ed53-44cc-addb-83bf2b988c58",
                            Email = "Ina.Nilsson@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Ina",
                            LastName = "Nilsson",
                            LockoutEnabled = true,
                            NormalizedEmail = "INA.NILSSON@MAIL.COM",
                            NormalizedUserName = "INA.NILSSON@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6247),
                            SecurityStamp = "ZO5ERT2XTU2GFEPVJMJNZSPFDLFGVBPA4XWTMGVSU243MZXMH3JQ",
                            TwoFactorEnabled = false,
                            UserName = "Ina.Nilsson@mail.com"
                        },
                        new
                        {
                            Id = 16,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet106",
                            ConcurrencyStamp = "ad09a618-48a4-48c7-99da-af493cfc5808",
                            Email = "Martin.Petersson@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Martin",
                            LastName = "Petersson",
                            LockoutEnabled = true,
                            NormalizedEmail = "MARTIN.PETERSSON@MAIL.COM",
                            NormalizedUserName = "MARTIN.PETERSSON@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6255),
                            SecurityStamp = "RXAPWF6FKIFML4GGSI4RQ3X5YSUD7ZG3NHXRPG4KGJKSGGRX5NDQ",
                            TwoFactorEnabled = false,
                            UserName = "Martin.Petersson@mail.com"
                        },
                        new
                        {
                            Id = 17,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet107",
                            ConcurrencyStamp = "299896ca-c437-4519-8842-f1d3ad229ac5",
                            Email = "Steve.Carell@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Steve",
                            LastName = "Carell",
                            LockoutEnabled = true,
                            NormalizedEmail = "STEVE.CARELL@MAIL.COM",
                            NormalizedUserName = "STEVE.CARELL@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6264),
                            SecurityStamp = "T3YLAN3BGKZG6HU42UUX3HJPJH5SKEF4C24K3KV4VFHSRJFWJEGA",
                            TwoFactorEnabled = false,
                            UserName = "Steve.Carell@mail.com"
                        },
                        new
                        {
                            Id = 18,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet108",
                            ConcurrencyStamp = "24fa530b-6e01-4111-8e72-a25e455db50d",
                            Email = "Grogu.Mandelorian@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Grogu",
                            LastName = "Mandelorian",
                            LockoutEnabled = true,
                            NormalizedEmail = "GROGU.MANDELORIAN@MAIL.COM",
                            NormalizedUserName = "GROGU.MANDELORIAN@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6274),
                            SecurityStamp = "VDE4J6M7XV2DVQOJD3S3NOKJVBS5NXTG7VRQLR2WWKFACB3BPIKQ",
                            TwoFactorEnabled = false,
                            UserName = "Grogu.Mandelorian@mail.com"
                        },
                        new
                        {
                            Id = 19,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet109",
                            ConcurrencyStamp = "8092b283-c362-4e42-b9fa-2e9fcaca8799",
                            Email = "Lotta.Svensson@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Lotta",
                            LastName = "Svensson",
                            LockoutEnabled = true,
                            NormalizedEmail = "LOTTA.SVENSSON@MAIL.COM",
                            NormalizedUserName = "LOTTA.SVENSSON@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6283),
                            SecurityStamp = "UYZME6OAWYCNHQ7ZLW4YGDXRTHSEGZ7TD2IQIKQXIZYSPLJXDCSQ",
                            TwoFactorEnabled = false,
                            UserName = "Lotta.Svensson@mail.com"
                        },
                        new
                        {
                            Id = 20,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet110",
                            ConcurrencyStamp = "88916175-1e2b-417a-b7cc-c662b00fc072",
                            Email = "Emilia.Ristersson@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Emilia",
                            LastName = "Ristersson",
                            LockoutEnabled = true,
                            NormalizedEmail = "EMILIA.RISTERSSON@MAIL.COM",
                            NormalizedUserName = "EMILIA.RISTERSSON@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEL1wizaAIe0HinHm7p6EHzjsaalFaiuitoPS+DMVtiUtUPK8L7Qy2ddKEmGiKvmxA==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 21, 11, 7, 55, 405, DateTimeKind.Local).AddTicks(6291),
                            SecurityStamp = "XUXRNDZAC5V27IWEWCJZR2STN7TGHINGRNG4KJSRS6AKYL6GWXIA",
                            TwoFactorEnabled = false,
                            UserName = "Emilia.Ristersson@mail.com"
                        });
                });

            modelBuilder.Entity("WebAppMVC.Models.Order", b =>
                {
                    b.Property<int>("cartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cartId"));

                    b.Property<int>("FkCustomerId")
                        .HasColumnType("int");

                    b.HasKey("cartId");

                    b.HasIndex("FkCustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebAppMVC.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int?>("FkCategory")
                        .HasColumnType("int");

                    b.Property<string>("ImgURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrdercartId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int?>("cartId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("FkCategory");

                    b.HasIndex("OrdercartId");

                    b.HasIndex("cartId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 11,
                            Price = 599m,
                            Quantity = 5,
                            Title = "Jacket"
                        },
                        new
                        {
                            ProductId = 12,
                            Price = 499m,
                            Quantity = 6,
                            Title = "Pants"
                        },
                        new
                        {
                            ProductId = 13,
                            Price = 1299m,
                            Quantity = 11,
                            Title = "HockeyStick"
                        },
                        new
                        {
                            ProductId = 14,
                            Price = 399m,
                            Quantity = 12,
                            Title = "Football"
                        },
                        new
                        {
                            ProductId = 15,
                            Price = 2099m,
                            Quantity = 10,
                            Title = "Snowboard"
                        },
                        new
                        {
                            ProductId = 16,
                            Price = 1199m,
                            Quantity = 5,
                            Title = "HeadPhones"
                        },
                        new
                        {
                            ProductId = 17,
                            Price = 649m,
                            Quantity = 3,
                            Title = "GamingMouse"
                        },
                        new
                        {
                            ProductId = 18,
                            Price = 1799m,
                            Quantity = 7,
                            Title = "Mechanicle Keyboard"
                        },
                        new
                        {
                            ProductId = 19,
                            Price = 2199m,
                            Quantity = 2,
                            Title = "ComputerScreen"
                        },
                        new
                        {
                            ProductId = 20,
                            Price = 99m,
                            Quantity = 15,
                            Title = "MousePad"
                        });
                });

            modelBuilder.Entity("WebAppMVC.Models.Review", b =>
                {
                    b.Property<int>("ProductReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductReviewId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("FK_ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductReviewId");

                    b.HasIndex("FK_ProductId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("WebAppMVC.Models.KoalaCustomer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("WebAppMVC.Models.KoalaCustomer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppMVC.Models.KoalaCustomer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("WebAppMVC.Models.KoalaCustomer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAppMVC.Models.Cart", b =>
                {
                    b.HasOne("WebAppMVC.Models.KoalaCustomer", "KoalaId")
                        .WithMany()
                        .HasForeignKey("KoalaIdId");

                    b.Navigation("KoalaId");
                });

            modelBuilder.Entity("WebAppMVC.Models.Order", b =>
                {
                    b.HasOne("WebAppMVC.Models.KoalaCustomer", "koalaId")
                        .WithMany()
                        .HasForeignKey("FkCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("koalaId");
                });

            modelBuilder.Entity("WebAppMVC.Models.Product", b =>
                {
                    b.HasOne("WebAppMVC.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("FkCategory");

                    b.HasOne("WebAppMVC.Models.Order", null)
                        .WithMany("products")
                        .HasForeignKey("OrdercartId");

                    b.HasOne("WebAppMVC.Models.Cart", null)
                        .WithMany("Products")
                        .HasForeignKey("cartId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebAppMVC.Models.Review", b =>
                {
                    b.HasOne("WebAppMVC.Models.Product", "Products")
                        .WithMany()
                        .HasForeignKey("FK_ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebAppMVC.Models.Cart", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebAppMVC.Models.Order", b =>
                {
                    b.Navigation("products");
                });
#pragma warning restore 612, 618
        }
    }
}
