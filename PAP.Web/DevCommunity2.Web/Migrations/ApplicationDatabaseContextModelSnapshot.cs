﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PAP.Business.DbContext;

namespace DevCommunity2.Web.Migrations
{
    [DbContext(typeof(ApplicationDatabaseContext))]
    partial class ApplicationDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PAP.DataBase.AccountNotification", b =>
                {
                    b.Property<int>("AccountNotificationsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId");

                    b.Property<int>("EventId");

                    b.Property<DateTime>("NotificationsDate")
                        .HasColumnType("date");

                    b.Property<Guid>("ReceiverNotificationAccountId");

                    b.Property<string>("RedirectUrl");

                    b.Property<bool>("Seen");

                    b.Property<Guid>("SenderNotificationAccountId");

                    b.Property<string>("Text")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .HasMaxLength(50);

                    b.HasKey("AccountNotificationsId");

                    b.HasIndex("EventId");

                    b.HasIndex("ReceiverNotificationAccountId");

                    b.HasIndex("SenderNotificationAccountId", "ReceiverNotificationAccountId")
                        .IsUnique();

                    b.ToTable("AccountNotifications");
                });

            modelBuilder.Entity("PAP.DataBase.AccountOnEvent", b =>
                {
                    b.Property<int>("AccountOnEventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("AccountId");

                    b.Property<int>("EventId");

                    b.HasKey("AccountOnEventId");

                    b.HasIndex("AccountId");

                    b.HasIndex("EventId");

                    b.ToTable("AccountOnEvent");
                });

            modelBuilder.Entity("PAP.DataBase.AccountPublish", b =>
                {
                    b.Property<int>("AccountPublishId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("AccountId");

                    b.Property<DateTime>("DatePublish");

                    b.HasKey("AccountPublishId");

                    b.HasIndex("AccountId");

                    b.ToTable("AccountPublish");
                });

            modelBuilder.Entity("PAP.DataBase.AccountRelationship", b =>
                {
                    b.Property<int>("AccountRelationshipId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Isfriend");

                    b.Property<Guid>("ReceiverAccountId");

                    b.Property<Guid>("SenderAccountId");

                    b.HasKey("AccountRelationshipId");

                    b.HasIndex("ReceiverAccountId");

                    b.HasIndex("SenderAccountId", "ReceiverAccountId")
                        .IsUnique();

                    b.ToTable("AccountRelationship");
                });

            modelBuilder.Entity("PAP.DataBase.Auth.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Country");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FistName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NickName");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PhotoUrl");

                    b.Property<string>("ProgrammingLanguages");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("Stars")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(3);

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("PAP.DataBase.Auth.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("PAP.DataBase.ContentPublishAccount", b =>
                {
                    b.Property<int>("ContentPublishAccountId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountPublishId");

                    b.Property<string>("GithubFile")
                        .HasMaxLength(500);

                    b.Property<string>("Tags");

                    b.Property<string>("TextContent");

                    b.HasKey("ContentPublishAccountId");

                    b.HasIndex("AccountPublishId")
                        .IsUnique();

                    b.ToTable("ContentPublishAccount");
                });

            modelBuilder.Entity("PAP.DataBase.ContentPublishEvent", b =>
                {
                    b.Property<int>("ContentPublishEventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GithubFile")
                        .HasMaxLength(500);

                    b.Property<int>("PublishEventId");

                    b.Property<string>("TextContent");

                    b.HasKey("ContentPublishEventId");

                    b.HasIndex("PublishEventId")
                        .IsUnique();

                    b.ToTable("ContentPublishEvent");
                });

            modelBuilder.Entity("PAP.DataBase.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("CreatedByUserID");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateEvent");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<bool>("IsEnabled")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("Location");

                    b.Property<string>("LocationWhat3words");

                    b.Property<string>("NameEvent")
                        .HasMaxLength(20);

                    b.Property<string>("PhotoUrl")
                        .HasMaxLength(500);

                    b.Property<int>("Stars")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(3);

                    b.Property<string>("TypeOfEvent")
                        .HasMaxLength(20);

                    b.HasKey("EventId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("PAP.DataBase.FeedBackContentAccount", b =>
                {
                    b.Property<int>("FeedBackContentAccountId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("AccountId");

                    b.Property<int>("AccountPublishId");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<int>("Stars")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(3);

                    b.HasKey("FeedBackContentAccountId");

                    b.HasIndex("AccountId");

                    b.HasIndex("AccountPublishId");

                    b.ToTable("FeedBackContentAccount");
                });

            modelBuilder.Entity("PAP.DataBase.FeedBackContentEvent", b =>
                {
                    b.Property<int>("IdFeedBackContent")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("AccountId");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<int>("EventPublishId");

                    b.Property<int>("Stars")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(3);

                    b.HasKey("IdFeedBackContent");

                    b.HasIndex("AccountId");

                    b.HasIndex("EventPublishId");

                    b.ToTable("FeedBackContentEvent");
                });

            modelBuilder.Entity("PAP.DataBase.PhotoContentPublishAccount", b =>
                {
                    b.Property<int>("PhotoContentPublishAccountId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContentPublishAccountId");

                    b.Property<string>("PhotoURl")
                        .HasMaxLength(500);

                    b.HasKey("PhotoContentPublishAccountId");

                    b.HasIndex("ContentPublishAccountId");

                    b.ToTable("PhotoContentPublishAccount");
                });

            modelBuilder.Entity("PAP.DataBase.PhotoContentPublishEvent", b =>
                {
                    b.Property<int>("PhotoContentPublishEventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContentPublishEventId");

                    b.Property<string>("PhotoURl")
                        .HasMaxLength(500);

                    b.HasKey("PhotoContentPublishEventId");

                    b.HasIndex("ContentPublishEventId");

                    b.ToTable("PhotoContentPublishEvent");
                });

            modelBuilder.Entity("PAP.DataBase.PublishEvent", b =>
                {
                    b.Property<int>("PublishEventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("AccountId");

                    b.Property<int>("EventId");

                    b.Property<DateTime>("PublishDate");

                    b.HasKey("PublishEventId");

                    b.HasIndex("AccountId");

                    b.HasIndex("EventId");

                    b.ToTable("PublishEvent");
                });

            modelBuilder.Entity("PAP.DataBase.VideoContentPublishAccount", b =>
                {
                    b.Property<int>("VideoContentPublishAccountId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContentPublishAccountId");

                    b.Property<string>("VideoURl")
                        .HasMaxLength(500);

                    b.HasKey("VideoContentPublishAccountId");

                    b.HasIndex("ContentPublishAccountId");

                    b.ToTable("VideoContentPublishAccount");
                });

            modelBuilder.Entity("PAP.DataBase.VideoContentPublishEvent", b =>
                {
                    b.Property<int>("VideoContentPublishEventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContentPublishEventId");

                    b.Property<string>("VideoUrl")
                        .HasMaxLength(500);

                    b.HasKey("VideoContentPublishEventId");

                    b.HasIndex("ContentPublishEventId");

                    b.ToTable("VideoContentPublishEvent");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("PAP.DataBase.Auth.UserRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("PAP.DataBase.Auth.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("PAP.DataBase.Auth.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("PAP.DataBase.Auth.UserRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PAP.DataBase.Auth.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("PAP.DataBase.Auth.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PAP.DataBase.AccountNotification", b =>
                {
                    b.HasOne("PAP.DataBase.Event", "Event")
                        .WithMany("AccountNotifications")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PAP.DataBase.Auth.User", "ReceiverNotificationAccount")
                        .WithMany("ReceiverNotificationAccounts")
                        .HasForeignKey("ReceiverNotificationAccountId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PAP.DataBase.Auth.User", "SenderNotificationAccount")
                        .WithMany("SenderNotificationAccounts")
                        .HasForeignKey("SenderNotificationAccountId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PAP.DataBase.AccountOnEvent", b =>
                {
                    b.HasOne("PAP.DataBase.Auth.User", "Account")
                        .WithMany("AccountOnEvents")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PAP.DataBase.Event", "Event")
                        .WithMany("AccountOnEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PAP.DataBase.AccountPublish", b =>
                {
                    b.HasOne("PAP.DataBase.Auth.User", "Account")
                        .WithMany("AccountPublishes")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PAP.DataBase.AccountRelationship", b =>
                {
                    b.HasOne("PAP.DataBase.Auth.User", "ReceiverAccount")
                        .WithMany("ReceiverAccountRelationships")
                        .HasForeignKey("ReceiverAccountId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PAP.DataBase.Auth.User", "SenderAccount")
                        .WithMany("SenderAccountRelationships")
                        .HasForeignKey("SenderAccountId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PAP.DataBase.ContentPublishAccount", b =>
                {
                    b.HasOne("PAP.DataBase.AccountPublish", "AccountPublish")
                        .WithOne("ContentPublishAccounts")
                        .HasForeignKey("PAP.DataBase.ContentPublishAccount", "AccountPublishId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PAP.DataBase.ContentPublishEvent", b =>
                {
                    b.HasOne("PAP.DataBase.PublishEvent", "PublishEvent")
                        .WithOne("ContentPublishEvent")
                        .HasForeignKey("PAP.DataBase.ContentPublishEvent", "PublishEventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PAP.DataBase.FeedBackContentAccount", b =>
                {
                    b.HasOne("PAP.DataBase.Auth.User", "Account")
                        .WithMany("FeedBackContentAccounts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PAP.DataBase.AccountPublish", "AccountPublish")
                        .WithMany("FeedBackContentAccounts")
                        .HasForeignKey("AccountPublishId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PAP.DataBase.FeedBackContentEvent", b =>
                {
                    b.HasOne("PAP.DataBase.Auth.User", "Account")
                        .WithMany("FeedBackContentEvents")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PAP.DataBase.PublishEvent", "PublishEvent")
                        .WithMany("FeedBackContentEvents")
                        .HasForeignKey("EventPublishId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PAP.DataBase.PhotoContentPublishAccount", b =>
                {
                    b.HasOne("PAP.DataBase.ContentPublishAccount", "ContentPublishAccount")
                        .WithMany("PhotoContentPublishAccounts")
                        .HasForeignKey("ContentPublishAccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PAP.DataBase.PhotoContentPublishEvent", b =>
                {
                    b.HasOne("PAP.DataBase.ContentPublishEvent", "ContentPublishEvent")
                        .WithMany("PhotoContentPublishEvents")
                        .HasForeignKey("ContentPublishEventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PAP.DataBase.PublishEvent", b =>
                {
                    b.HasOne("PAP.DataBase.Auth.User", "Account")
                        .WithMany("PublishEvents")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PAP.DataBase.Event", "Event")
                        .WithMany("PublishEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PAP.DataBase.VideoContentPublishAccount", b =>
                {
                    b.HasOne("PAP.DataBase.ContentPublishAccount", "ContentPublishAccount")
                        .WithMany("VideoContentPublishAccounts")
                        .HasForeignKey("ContentPublishAccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PAP.DataBase.VideoContentPublishEvent", b =>
                {
                    b.HasOne("PAP.DataBase.ContentPublishEvent", "ContentPublishEvent")
                        .WithMany("VideoContentPublishEvents")
                        .HasForeignKey("ContentPublishEventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
