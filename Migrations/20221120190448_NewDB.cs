using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SystemWebDorms.Migrations
{
    public partial class NewDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterDormitories",
                columns: table => new
                {
                    MasterDormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterDormName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterDormBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterDormLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterDormLinkMap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterDormImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterDormitories", x => x.MasterDormId);
                });

            migrationBuilder.CreateTable(
                name: "MasterMenus",
                columns: table => new
                {
                    MasterMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterMenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterMenuLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterMenuDropMenu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterMenus", x => x.MasterMenuId);
                });

            migrationBuilder.CreateTable(
                name: "MasterSliders",
                columns: table => new
                {
                    MasterSliderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterSliderImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterSliderTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterSliders", x => x.MasterSliderId);
                });

            migrationBuilder.CreateTable(
                name: "MasterSocialMedia",
                columns: table => new
                {
                    MasterSocialMediumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterSocialMediaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterSocialMediaLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterSocialMediaIconUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterSocialMedia", x => x.MasterSocialMediumId);
                });

            migrationBuilder.CreateTable(
                name: "SystemSettings",
                columns: table => new
                {
                    SystemSettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemSettingLogoNav = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemSettingLogoFooter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemSettingTitleDorm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemSettingBriefDorm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemSettingBriefFooter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemSettingZahraaDorm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemSettingAndalusDorm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemSettingJerashDorm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemSettingAmmonDorm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemSettings", x => x.SystemSettingId);
                });

            migrationBuilder.CreateTable(
                name: "TransContactUss",
                columns: table => new
                {
                    TransContactUsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransContactUsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransContactUsFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransContactUsLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransContactUsStudentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransContactUsDiscrption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransContactUsDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransContactUrlImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransContactLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransContactUss", x => x.TransContactUsId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransInnerDormDoubleRooms",
                columns: table => new
                {
                    TransInnerDormDoubleRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterDormId = table.Column<int>(type: "int", nullable: false),
                    TransZahraaDormDoubleRoomTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransZahraaDormDoubleRoomBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransZahraaDormDoubleRoomImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransZahraaDormDoubleRoomLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAndalusDormDoubleRoomTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAndalusDormDoubleRoomBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAndalusDormDoubleRoomImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAndalusDormDoubleRoomLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransInnerDormDoubleRooms", x => x.TransInnerDormDoubleRoomId);
                    table.ForeignKey(
                        name: "FK_TransInnerDormDoubleRooms_MasterDormitories_MasterDormId",
                        column: x => x.MasterDormId,
                        principalTable: "MasterDormitories",
                        principalColumn: "MasterDormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransInnerDormNights",
                columns: table => new
                {
                    TransInnerDormNightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterDormId = table.Column<int>(type: "int", nullable: false),
                    TransZahraaDormNightRoomTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransZahraaDormNightRoomBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransZahraaDormNightRoomImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransZahraaDormNightRoomLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAndalusDormNightRoomTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAndalusDormNightRoomBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAndalusDormNightRoomImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAndalusDormNightRoomLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransInnerDormNights", x => x.TransInnerDormNightId);
                    table.ForeignKey(
                        name: "FK_TransInnerDormNights_MasterDormitories_MasterDormId",
                        column: x => x.MasterDormId,
                        principalTable: "MasterDormitories",
                        principalColumn: "MasterDormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransInnerDormTripleRooms",
                columns: table => new
                {
                    TransInnerDormTripleRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterDormId = table.Column<int>(type: "int", nullable: false),
                    TransZahraaDormTripleRoomTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransZahraaDormTripleRoomBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransZahraaDormTripleRoomImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransZahraaDormTripleRoomLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAndalusDormTripleRoomTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAndalusDormTripleRoomBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAndalusDormTripleRoomImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAndalusDormTripleRoomLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransInnerDormTripleRooms", x => x.TransInnerDormTripleRoomId);
                    table.ForeignKey(
                        name: "FK_TransInnerDormTripleRooms_MasterDormitories_MasterDormId",
                        column: x => x.MasterDormId,
                        principalTable: "MasterDormitories",
                        principalColumn: "MasterDormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransInternationalDormDoubleRooms",
                columns: table => new
                {
                    TransInternationalDormDoubleRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterDormId = table.Column<int>(type: "int", nullable: false),
                    TransJarashDormDoubleRoomTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransJerashDormDoubleRoomBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransJerashDormDoubleRoomImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransJerashDormDoubleRoomLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormDoubleRoomTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormDoubleRoomBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormDoubleRoomImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormDoubleRoomLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransInternationalDormDoubleRooms", x => x.TransInternationalDormDoubleRoomId);
                    table.ForeignKey(
                        name: "FK_TransInternationalDormDoubleRooms_MasterDormitories_MasterDormId",
                        column: x => x.MasterDormId,
                        principalTable: "MasterDormitories",
                        principalColumn: "MasterDormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransInternationalDormDoubleRoomSisters",
                columns: table => new
                {
                    TransInternationalDormDoubleRoomSisterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterDormId = table.Column<int>(type: "int", nullable: false),
                    TransJarashDormDoubleRoomSistersTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransJerashDormDoubleRoomSistersBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransJerashDormDoubleRoomSistersImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransJerashDormDoubleRoomSistersLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormDoubleRoomSistersTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormDoubleRoomSistersBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormDoubleRoomSistersImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormDoubleRoomSistersLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransInternationalDormDoubleRoomSisters", x => x.TransInternationalDormDoubleRoomSisterId);
                    table.ForeignKey(
                        name: "FK_TransInternationalDormDoubleRoomSisters_MasterDormitories_MasterDormId",
                        column: x => x.MasterDormId,
                        principalTable: "MasterDormitories",
                        principalColumn: "MasterDormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransInternationalDormNightRooms",
                columns: table => new
                {
                    TransInternationalDormNightRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterDormId = table.Column<int>(type: "int", nullable: false),
                    TransJarashDormNightRoomTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransJerashDormNightRoomBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransJerashDormNightRoomImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransJerashDormNightRoomLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormNightRoomTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormNightRoomBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormNightRoomImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormNightRoomLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransInternationalDormNightRooms", x => x.TransInternationalDormNightRoomId);
                    table.ForeignKey(
                        name: "FK_TransInternationalDormNightRooms_MasterDormitories_MasterDormId",
                        column: x => x.MasterDormId,
                        principalTable: "MasterDormitories",
                        principalColumn: "MasterDormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransInternationalDormSingleRooms",
                columns: table => new
                {
                    TransInternationalDormSingleRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterDormId = table.Column<int>(type: "int", nullable: false),
                    TransJarashDormSingleRoomTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransJerashDormSingleRoomBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransJerashDormSingleRoomImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransJerashDormSingleRoomLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormSingleRoomTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormSingleRoomBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormSingleRoomImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormSingleRoomLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransInternationalDormSingleRooms", x => x.TransInternationalDormSingleRoomId);
                    table.ForeignKey(
                        name: "FK_TransInternationalDormSingleRooms_MasterDormitories_MasterDormId",
                        column: x => x.MasterDormId,
                        principalTable: "MasterDormitories",
                        principalColumn: "MasterDormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransInternationalDormTripleRooms",
                columns: table => new
                {
                    TransInternationalDormTripleRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterDormId = table.Column<int>(type: "int", nullable: false),
                    TransJarashDormTripleRoomTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransJerashDormTripleRoomBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransJerashDormTripleRoomImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransJerashDormTripleRoomLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormTripleRoomTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormTripleRoomBrief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormTripleRoomImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmmonDormTripleRoomLinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransInternationalDormTripleRooms", x => x.TransInternationalDormTripleRoomId);
                    table.ForeignKey(
                        name: "FK_TransInternationalDormTripleRooms_MasterDormitories_MasterDormId",
                        column: x => x.MasterDormId,
                        principalTable: "MasterDormitories",
                        principalColumn: "MasterDormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TransInnerDormDoubleRooms_MasterDormId",
                table: "TransInnerDormDoubleRooms",
                column: "MasterDormId");

            migrationBuilder.CreateIndex(
                name: "IX_TransInnerDormNights_MasterDormId",
                table: "TransInnerDormNights",
                column: "MasterDormId");

            migrationBuilder.CreateIndex(
                name: "IX_TransInnerDormTripleRooms_MasterDormId",
                table: "TransInnerDormTripleRooms",
                column: "MasterDormId");

            migrationBuilder.CreateIndex(
                name: "IX_TransInternationalDormDoubleRooms_MasterDormId",
                table: "TransInternationalDormDoubleRooms",
                column: "MasterDormId");

            migrationBuilder.CreateIndex(
                name: "IX_TransInternationalDormDoubleRoomSisters_MasterDormId",
                table: "TransInternationalDormDoubleRoomSisters",
                column: "MasterDormId");

            migrationBuilder.CreateIndex(
                name: "IX_TransInternationalDormNightRooms_MasterDormId",
                table: "TransInternationalDormNightRooms",
                column: "MasterDormId");

            migrationBuilder.CreateIndex(
                name: "IX_TransInternationalDormSingleRooms_MasterDormId",
                table: "TransInternationalDormSingleRooms",
                column: "MasterDormId");

            migrationBuilder.CreateIndex(
                name: "IX_TransInternationalDormTripleRooms_MasterDormId",
                table: "TransInternationalDormTripleRooms",
                column: "MasterDormId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MasterMenus");

            migrationBuilder.DropTable(
                name: "MasterSliders");

            migrationBuilder.DropTable(
                name: "MasterSocialMedia");

            migrationBuilder.DropTable(
                name: "SystemSettings");

            migrationBuilder.DropTable(
                name: "TransContactUss");

            migrationBuilder.DropTable(
                name: "TransInnerDormDoubleRooms");

            migrationBuilder.DropTable(
                name: "TransInnerDormNights");

            migrationBuilder.DropTable(
                name: "TransInnerDormTripleRooms");

            migrationBuilder.DropTable(
                name: "TransInternationalDormDoubleRooms");

            migrationBuilder.DropTable(
                name: "TransInternationalDormDoubleRoomSisters");

            migrationBuilder.DropTable(
                name: "TransInternationalDormNightRooms");

            migrationBuilder.DropTable(
                name: "TransInternationalDormSingleRooms");

            migrationBuilder.DropTable(
                name: "TransInternationalDormTripleRooms");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MasterDormitories");
        }
    }
}
