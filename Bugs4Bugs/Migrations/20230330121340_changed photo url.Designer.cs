﻿// <auto-generated />
using System;
using Bugs4Bugs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bugs4Bugs.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230330121340_changed photo url")]
    partial class changedphotourl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bugs4Bugs.Models.BugType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BuggTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Program crash"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Visual glitch"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Performance issue"
                        },
                        new
                        {
                            Id = 4,
                            Type = "Unexpected behaviour"
                        });
                });

            modelBuilder.Entity("Bugs4Bugs.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Visual Studio",
                            PhotoURL = "Images/VisualStudio.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Visual Studio Code",
                            PhotoURL = "Images/VSCode.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Firefox",
                            PhotoURL = "Images/Firefox.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Chrome",
                            PhotoURL = "Images/chrome.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Skynet",
                            PhotoURL = "Images/Skynet.png"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Spotify",
                            PhotoURL = "Images/Spotify.png"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Netflix",
                            PhotoURL = "Images/Netflix.png"
                        },
                        new
                        {
                            Id = 8,
                            Name = "BookBeat",
                            PhotoURL = "Images/BookBeat.png"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Blocket",
                            PhotoURL = "Images/Blocket.png"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Ebay",
                            PhotoURL = "Images/Ebay.png"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Microsoft Teams",
                            PhotoURL = "Images/Teams.jpg"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Youtube",
                            PhotoURL = "Images/Youtube.png"
                        });
                });

            modelBuilder.Entity("Bugs4Bugs.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Bugs4Bugs.Models.SiteUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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
                            Id = "DefaultId",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dba4e99a-ec28-4f6d-9f18-40e12e3ea6d5",
                            EmailConfirmed = false,
                            FirstName = "John",
                            LastName = "Connor",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "53f013e3-9d57-49f6-b9b1-3bb64a0e2542",
                            TwoFactorEnabled = false,
                            UserName = "JohnConnor"
                        });
                });

            modelBuilder.Entity("Bugs4Bugs.Models.SiteUserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("RoleInProductId")
                        .HasColumnType("int");

                    b.Property<string>("SiteUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("RoleInProductId");

                    b.HasIndex("SiteUserId");

                    b.ToTable("SiteUserRole");
                });

            modelBuilder.Entity("Bugs4Bugs.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TicketStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This ticket is open and currently waiting to be assigned to a developer.",
                            TicketStatus = "Closed"
                        },
                        new
                        {
                            Id = 2,
                            Description = "This ticket is open and currently waiting to be assigned to a developer.",
                            TicketStatus = "Resolved"
                        },
                        new
                        {
                            Id = 3,
                            Description = "This ticket is open and currently waiting to be assigned to a developer.",
                            TicketStatus = "Opened"
                        },
                        new
                        {
                            Id = 4,
                            Description = "This ticket is open and currently waiting to be assigned to a developer.",
                            TicketStatus = "Pending"
                        },
                        new
                        {
                            Id = 5,
                            Description = "This ticket is open and currently waiting to be assigned to a developer.",
                            TicketStatus = "Assigned"
                        });
                });

            modelBuilder.Entity("Bugs4Bugs.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SubmittedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubmitterId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TicketBugTypeId")
                        .HasColumnType("int");

                    b.Property<int>("TicketProductId")
                        .HasColumnType("int");

                    b.Property<int>("TicketStatusId")
                        .HasColumnType("int");

                    b.Property<int>("TicketUrgencyId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SubmitterId");

                    b.HasIndex("TicketBugTypeId");

                    b.HasIndex("TicketProductId");

                    b.HasIndex("TicketStatusId");

                    b.HasIndex("TicketUrgencyId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "En smältande polis jagar mig och en Österrikisk bodybuilder säger att jag ska rädda framtiden",
                            LastUpdated = new DateTime(2023, 4, 6, 14, 13, 40, 278, DateTimeKind.Local).AddTicks(338),
                            SubmittedDate = new DateTime(2023, 4, 2, 14, 13, 40, 278, DateTimeKind.Local).AddTicks(266),
                            SubmitterId = "DefaultId",
                            TicketBugTypeId = 1,
                            TicketProductId = 5,
                            TicketStatusId = 1,
                            TicketUrgencyId = 1,
                            Title = "Mördarrobotar"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Jag gjorde min matteläxa när programmet plötsligt",
                            LastUpdated = new DateTime(2023, 3, 30, 14, 13, 40, 278, DateTimeKind.Local).AddTicks(354),
                            SubmittedDate = new DateTime(2023, 3, 30, 14, 13, 40, 278, DateTimeKind.Local).AddTicks(352),
                            SubmitterId = "DefaultId",
                            TicketBugTypeId = 3,
                            TicketProductId = 1,
                            TicketStatusId = 3,
                            TicketUrgencyId = 2,
                            Title = "Programmet åt min läxa"
                        });
                });

            modelBuilder.Entity("Bugs4Bugs.Models.Urgency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Urgencies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Level = "Low"
                        },
                        new
                        {
                            Id = 2,
                            Level = "Medium"
                        },
                        new
                        {
                            Id = 3,
                            Level = "High"
                        },
                        new
                        {
                            Id = 4,
                            Level = "Critical"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Bugs4Bugs.Models.SiteUserRole", b =>
                {
                    b.HasOne("Bugs4Bugs.Models.Product", null)
                        .WithMany("ProductTeam")
                        .HasForeignKey("ProductId");

                    b.HasOne("Bugs4Bugs.Models.Role", "RoleInProduct")
                        .WithMany()
                        .HasForeignKey("RoleInProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bugs4Bugs.Models.SiteUser", "SiteUser")
                        .WithMany()
                        .HasForeignKey("SiteUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoleInProduct");

                    b.Navigation("SiteUser");
                });

            modelBuilder.Entity("Bugs4Bugs.Models.Ticket", b =>
                {
                    b.HasOne("Bugs4Bugs.Models.SiteUser", "Submitter")
                        .WithMany()
                        .HasForeignKey("SubmitterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bugs4Bugs.Models.BugType", "TicketBugType")
                        .WithMany()
                        .HasForeignKey("TicketBugTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bugs4Bugs.Models.Product", "TicketProduct")
                        .WithMany()
                        .HasForeignKey("TicketProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bugs4Bugs.Models.Status", "TicketStatus")
                        .WithMany()
                        .HasForeignKey("TicketStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bugs4Bugs.Models.Urgency", "TicketUrgency")
                        .WithMany()
                        .HasForeignKey("TicketUrgencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Submitter");

                    b.Navigation("TicketBugType");

                    b.Navigation("TicketProduct");

                    b.Navigation("TicketStatus");

                    b.Navigation("TicketUrgency");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Bugs4Bugs.Models.SiteUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Bugs4Bugs.Models.SiteUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bugs4Bugs.Models.SiteUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Bugs4Bugs.Models.SiteUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bugs4Bugs.Models.Product", b =>
                {
                    b.Navigation("ProductTeam");
                });
#pragma warning restore 612, 618
        }
    }
}
