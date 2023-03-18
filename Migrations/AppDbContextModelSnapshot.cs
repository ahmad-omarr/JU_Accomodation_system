﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SystemWebDorms.Models;

namespace SystemWebDorms.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SystemWebDorms.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dis_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.Property<string>("User_image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SystemWebDorms.Models.MasterDorm", b =>
                {
                    b.Property<int>("MasterDormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("MasterDormBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MasterDormImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MasterDormLinkMap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MasterDormLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MasterDormName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MasterMenuId")
                        .HasColumnType("int");

                    b.HasKey("MasterDormId");

                    b.HasIndex("MasterMenuId");

                    b.ToTable("MasterDormitories");
                });

            modelBuilder.Entity("SystemWebDorms.Models.MasterMenu", b =>
                {
                    b.Property<int>("MasterMenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("MasterDormId")
                        .HasColumnType("int");

                    b.Property<string>("MasterMenuDropMenu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MasterMenuDropMenuLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MasterMenuLinkUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MasterMenuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MasterMenuId");

                    b.HasIndex("MasterDormId");

                    b.ToTable("MasterMenus");
                });

            modelBuilder.Entity("SystemWebDorms.Models.MasterSlider", b =>
                {
                    b.Property<int>("MasterSliderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("MasterSliderImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MasterSliderTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MasterSliderId");

                    b.ToTable("MasterSliders");
                });

            modelBuilder.Entity("SystemWebDorms.Models.MasterSocialMedium", b =>
                {
                    b.Property<int>("MasterSocialMediumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("MasterSocialMediaIconUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MasterSocialMediaLinkUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MasterSocialMediaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MasterSocialMediumId");

                    b.ToTable("MasterSocialMedia");
                });

            modelBuilder.Entity("SystemWebDorms.Models.SystemSetting", b =>
                {
                    b.Property<int>("SystemSettingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("SystemSettingAmmonDorm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SystemSettingAndalusDorm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SystemSettingBriefDorm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SystemSettingBriefFooter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SystemSettingJerashDorm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SystemSettingLogoFooter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SystemSettingLogoNav")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SystemSettingTitleDorm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SystemSettingZahraaDorm")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SystemSettingId");

                    b.ToTable("SystemSettings");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransContactUs", b =>
                {
                    b.Property<int>("TransContactUsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("TransContactLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransContactUrlImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TransContactUsDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TransContactUsDiscrption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransContactUsFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransContactUsLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransContactUsStudentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransContactUsTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransContactUsId");

                    b.ToTable("TransContactUss");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInnerDormDoubleRoom", b =>
                {
                    b.Property<int>("TransInnerDormDoubleRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("MasterDormId")
                        .HasColumnType("int");

                    b.Property<string>("TransAndalusDormDoubleRoomBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAndalusDormDoubleRoomImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAndalusDormDoubleRoomLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAndalusDormDoubleRoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransZahraaDormDoubleRoomBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransZahraaDormDoubleRoomImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransZahraaDormDoubleRoomLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransZahraaDormDoubleRoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransInnerDormDoubleRoomId");

                    b.HasIndex("MasterDormId");

                    b.ToTable("TransInnerDormDoubleRooms");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInnerDormNight", b =>
                {
                    b.Property<int>("TransInnerDormNightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("MasterDormId")
                        .HasColumnType("int");

                    b.Property<string>("TransAndalusDormNightRoomBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAndalusDormNightRoomImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAndalusDormNightRoomLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAndalusDormNightRoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransZahraaDormNightRoomBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransZahraaDormNightRoomImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransZahraaDormNightRoomLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransZahraaDormNightRoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransInnerDormNightId");

                    b.HasIndex("MasterDormId");

                    b.ToTable("TransInnerDormNights");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInnerDormTripleRoom", b =>
                {
                    b.Property<int>("TransInnerDormTripleRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("MasterDormId")
                        .HasColumnType("int");

                    b.Property<string>("TransAndalusDormTripleRoomBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAndalusDormTripleRoomImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAndalusDormTripleRoomLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAndalusDormTripleRoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransZahraaDormTripleRoomBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransZahraaDormTripleRoomImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransZahraaDormTripleRoomLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransZahraaDormTripleRoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransInnerDormTripleRoomId");

                    b.HasIndex("MasterDormId");

                    b.ToTable("TransInnerDormTripleRooms");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInternationalDormDoubleRoom", b =>
                {
                    b.Property<int>("TransInternationalDormDoubleRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("MasterDormId")
                        .HasColumnType("int");

                    b.Property<string>("TransAmmonDormDoubleRoomBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmmonDormDoubleRoomImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmmonDormDoubleRoomLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmmonDormDoubleRoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJarashDormDoubleRoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJerashDormDoubleRoomBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJerashDormDoubleRoomImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJerashDormDoubleRoomLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransInternationalDormDoubleRoomId");

                    b.HasIndex("MasterDormId");

                    b.ToTable("TransInternationalDormDoubleRooms");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInternationalDormDoubleRoomSister", b =>
                {
                    b.Property<int>("TransInternationalDormDoubleRoomSisterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("MasterDormId")
                        .HasColumnType("int");

                    b.Property<string>("TransAmmonDormDoubleRoomSistersBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmmonDormDoubleRoomSistersImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmmonDormDoubleRoomSistersLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmmonDormDoubleRoomSistersTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJarashDormDoubleRoomSistersTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJerashDormDoubleRoomSistersBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJerashDormDoubleRoomSistersImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJerashDormDoubleRoomSistersLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransInternationalDormDoubleRoomSisterId");

                    b.HasIndex("MasterDormId");

                    b.ToTable("TransInternationalDormDoubleRoomSisters");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInternationalDormNightRoom", b =>
                {
                    b.Property<int>("TransInternationalDormNightRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("MasterDormId")
                        .HasColumnType("int");

                    b.Property<string>("TransAmmonDormNightRoomBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmmonDormNightRoomImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmmonDormNightRoomLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmmonDormNightRoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJarashDormNightRoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJerashDormNightRoomBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJerashDormNightRoomImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJerashDormNightRoomLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransInternationalDormNightRoomId");

                    b.HasIndex("MasterDormId");

                    b.ToTable("TransInternationalDormNightRooms");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInternationalDormSingleRoom", b =>
                {
                    b.Property<int>("TransInternationalDormSingleRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("MasterDormId")
                        .HasColumnType("int");

                    b.Property<string>("TransAmmonDormSingleRoomBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmmonDormSingleRoomImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmmonDormSingleRoomLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmmonDormSingleRoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJarashDormSingleRoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJerashDormSingleRoomBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJerashDormSingleRoomImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJerashDormSingleRoomLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransInternationalDormSingleRoomId");

                    b.HasIndex("MasterDormId");

                    b.ToTable("TransInternationalDormSingleRooms");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInternationalDormTripleRoom", b =>
                {
                    b.Property<int>("TransInternationalDormTripleRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("MasterDormId")
                        .HasColumnType("int");

                    b.Property<string>("TransAmmonDormTripleRoomBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmmonDormTripleRoomImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmmonDormTripleRoomLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransAmmonDormTripleRoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJarashDormTripleRoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJerashDormTripleRoomBrief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJerashDormTripleRoomImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransJerashDormTripleRoomLinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransInternationalDormTripleRoomId");

                    b.HasIndex("MasterDormId");

                    b.ToTable("TransInternationalDormTripleRooms");
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
                    b.HasOne("SystemWebDorms.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SystemWebDorms.Models.ApplicationUser", null)
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

                    b.HasOne("SystemWebDorms.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SystemWebDorms.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SystemWebDorms.Models.MasterDorm", b =>
                {
                    b.HasOne("SystemWebDorms.Models.MasterMenu", null)
                        .WithMany("ListMasterDorm")
                        .HasForeignKey("MasterMenuId");
                });

            modelBuilder.Entity("SystemWebDorms.Models.MasterMenu", b =>
                {
                    b.HasOne("SystemWebDorms.Models.MasterDorm", "MasterDorm")
                        .WithMany()
                        .HasForeignKey("MasterDormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MasterDorm");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInnerDormDoubleRoom", b =>
                {
                    b.HasOne("SystemWebDorms.Models.MasterDorm", "MasterDorm")
                        .WithMany()
                        .HasForeignKey("MasterDormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MasterDorm");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInnerDormNight", b =>
                {
                    b.HasOne("SystemWebDorms.Models.MasterDorm", "MasterDorm")
                        .WithMany()
                        .HasForeignKey("MasterDormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MasterDorm");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInnerDormTripleRoom", b =>
                {
                    b.HasOne("SystemWebDorms.Models.MasterDorm", "MasterDorm")
                        .WithMany()
                        .HasForeignKey("MasterDormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MasterDorm");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInternationalDormDoubleRoom", b =>
                {
                    b.HasOne("SystemWebDorms.Models.MasterDorm", "MasterDorm")
                        .WithMany()
                        .HasForeignKey("MasterDormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MasterDorm");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInternationalDormDoubleRoomSister", b =>
                {
                    b.HasOne("SystemWebDorms.Models.MasterDorm", "MasterDorm")
                        .WithMany()
                        .HasForeignKey("MasterDormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MasterDorm");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInternationalDormNightRoom", b =>
                {
                    b.HasOne("SystemWebDorms.Models.MasterDorm", "MasterDorm")
                        .WithMany()
                        .HasForeignKey("MasterDormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MasterDorm");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInternationalDormSingleRoom", b =>
                {
                    b.HasOne("SystemWebDorms.Models.MasterDorm", "MasterDorm")
                        .WithMany()
                        .HasForeignKey("MasterDormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MasterDorm");
                });

            modelBuilder.Entity("SystemWebDorms.Models.TransInternationalDormTripleRoom", b =>
                {
                    b.HasOne("SystemWebDorms.Models.MasterDorm", "MasterDorm")
                        .WithMany()
                        .HasForeignKey("MasterDormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MasterDorm");
                });

            modelBuilder.Entity("SystemWebDorms.Models.MasterMenu", b =>
                {
                    b.Navigation("ListMasterDorm");
                });
#pragma warning restore 612, 618
        }
    }
}
