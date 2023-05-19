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
                            ConcurrencyStamp = "7d16478c-80ec-43fe-94e3-07ab13c38cf1",
                            Email = "jon.westman@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Jon",
                            LastName = "Westman",
                            LockoutEnabled = true,
                            NormalizedEmail = "JON.WESTMAN@MAIL.COM",
                            NormalizedUserName = "JON.WESTMAN@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8453),
                            SecurityStamp = "YVMQM56ICOUIV5F2OTMNZEU7H5HJCMXINV2OVSATBYNOTQV4LQHA",
                            TwoFactorEnabled = false,
                            UserName = "jon.westman@mail.com"
                        },
                        new
                        {
                            Id = 12,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet102",
                            ConcurrencyStamp = "36752463-45e4-449b-b456-08ab7afeb9eb",
                            Email = "bjorn.agnemo@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Björn",
                            LastName = "Agnemo",
                            LockoutEnabled = true,
                            NormalizedEmail = "BJORN.AGNEMO@MAIL.COM",
                            NormalizedUserName = "BJORN.AGNEMO@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8503),
                            SecurityStamp = "YWIHECMCFSWL4BGOB252Z47U4VKFPRKFZ6A4UAZ4GPU6I4QILVRQ",
                            TwoFactorEnabled = false,
                            UserName = "bjorn.agnemo@mail.com"
                        },
                        new
                        {
                            Id = 13,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet103",
                            ConcurrencyStamp = "5a025181-5ac6-463a-ac89-86223b236f54",
                            Email = "Oskar.Ahling@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Oskar",
                            LastName = "Åhling",
                            LockoutEnabled = true,
                            NormalizedEmail = "OSKAR.AHLING@MAIL.COM",
                            NormalizedUserName = "OSKAR.AHLING@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8512),
                            SecurityStamp = "NA7K6GWHHX65PQFBVTFFN7OSUOFVAM4JVLQVBODJ6JEWOYC545VA",
                            TwoFactorEnabled = false,
                            UserName = "Oskar.Ahling@mail.com"
                        },
                        new
                        {
                            Id = 14,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet104",
                            ConcurrencyStamp = "0a60cf9a-0cd3-4753-b5a7-a1ff2da7a7a1",
                            Email = "Reidar.Nilsen@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Reidar",
                            LastName = "Nilsen",
                            LockoutEnabled = true,
                            NormalizedEmail = "REIDAR.NILSEN@MAIL.COM",
                            NormalizedUserName = "REIDAR.NILSEN@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8520),
                            SecurityStamp = "7HV7D4HPGACVN2LNYY4M62SVYGDTP5FODUBDAZXGVMMTP572XR7A",
                            TwoFactorEnabled = false,
                            UserName = "Reidar.Nilsen@mail.com"
                        },
                        new
                        {
                            Id = 15,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet105",
                            ConcurrencyStamp = "28668eee-bded-457b-a357-74bf2069e455",
                            Email = "Ina.Nilsson@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Ina",
                            LastName = "Nilsson",
                            LockoutEnabled = true,
                            NormalizedEmail = "INA.NILSSON@MAIL.COM",
                            NormalizedUserName = "INA.NILSSON@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8529),
                            SecurityStamp = "MCFK7TKJXNZ3NYJFD4GOCGPM4FCTOG3RN26JIJD4COMHGFXSLBDQ",
                            TwoFactorEnabled = false,
                            UserName = "Ina.Nilsson@mail.com"
                        },
                        new
                        {
                            Id = 16,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet106",
                            ConcurrencyStamp = "7f22b9ba-550b-4a7b-ba46-5cf12c6694f5",
                            Email = "Martin.Petersson@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Martin",
                            LastName = "Petersson",
                            LockoutEnabled = true,
                            NormalizedEmail = "MARTIN.PETERSSON@MAIL.COM",
                            NormalizedUserName = "MARTIN.PETERSSON@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8536),
                            SecurityStamp = "UKU22CFLDWTSV46BP37CLQVBOWMLW4M3I36HBRVDNTP7ZN3DH7LA",
                            TwoFactorEnabled = false,
                            UserName = "Martin.Petersson@mail.com"
                        },
                        new
                        {
                            Id = 17,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet107",
                            ConcurrencyStamp = "ae454e74-aa4a-4e85-ac28-0a93be9fcb4b",
                            Email = "Steve.Carell@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Steve",
                            LastName = "Carell",
                            LockoutEnabled = true,
                            NormalizedEmail = "STEVE.CARELL@MAIL.COM",
                            NormalizedUserName = "STEVE.CARELL@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8554),
                            SecurityStamp = "Z4GZ6RD6AVH63PUB3AL5LTEDYRVMJGV2T2UWH4I3OL5PD7NGOBDQ",
                            TwoFactorEnabled = false,
                            UserName = "Steve.Carell@mail.com"
                        },
                        new
                        {
                            Id = 18,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet108",
                            ConcurrencyStamp = "618e149c-aa8a-4b54-8d23-eea6849428fd",
                            Email = "Grogu.Mandelorian@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Grogu",
                            LastName = "Mandelorian",
                            LockoutEnabled = true,
                            NormalizedEmail = "GROGU.MANDELORIAN@MAIL.COM",
                            NormalizedUserName = "GROGU.MANDELORIAN@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8579),
                            SecurityStamp = "7234TR6OXKDKU5JGXAZXCTCWCDODEF4BIYOUJCUI4AFCXSPHJ4CQ",
                            TwoFactorEnabled = false,
                            UserName = "Grogu.Mandelorian@mail.com"
                        },
                        new
                        {
                            Id = 19,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet109",
                            ConcurrencyStamp = "89b3e1c0-5507-4551-9211-9314311e7d09",
                            Email = "Lotta.Svensson@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Lotta",
                            LastName = "Svensson",
                            LockoutEnabled = true,
                            NormalizedEmail = "LOTTA.SVENSSON@MAIL.COM",
                            NormalizedUserName = "LOTTA.SVENSSON@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8587),
                            SecurityStamp = "CDJ6YGPKEGLGTHRLUH5QNSGMD2UEYXK3SZMZ6TUULH5Y4HQFIXBA",
                            TwoFactorEnabled = false,
                            UserName = "Lotta.Svensson@mail.com"
                        },
                        new
                        {
                            Id = 20,
                            AccessFailedCount = 0,
                            Adress = "Fakestreet110",
                            ConcurrencyStamp = "798de012-b68c-438e-b653-cb2c92a8aa6b",
                            Email = "Emilia.Ristersson@mail.com",
                            EmailConfirmed = true,
                            FirstMidName = "Emilia",
                            LastName = "Ristersson",
                            LockoutEnabled = true,
                            NormalizedEmail = "EMILIA.RISTERSSON@MAIL.COM",
                            NormalizedUserName = "EMILIA.RISTERSSON@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==",
                            PhoneNumberConfirmed = false,
                            RegisteredAt = new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8596),
                            SecurityStamp = "5DPYZVILA2FNVUHR4PQWR5ZX4GYRFTTZZDEMGHFUNAA6SRNP3EYQ",
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
