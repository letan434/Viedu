using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ViEdu.Data.Migrations
{
    public partial class DbInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DEPT_CD = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    DEPT_NAME = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    POSITION_CD = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NAME = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    DESC = table.Column<string>(nullable: true),
                    JOB_REQUIRED = table.Column<string>(nullable: true),
                    DEPT_CD = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    RANK = table.Column<int>(nullable: false),
                    BENEFIT = table.Column<string>(nullable: true),
                    JOB_TYPE_DESC = table.Column<string>(nullable: true),
                    CREATED_DATE = table.Column<DateTime>(nullable: false),
                    CREATED_BY = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    MODIFIED_DATE = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    NOTE = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: true),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "DEPT_CD", "DEPT_NAME" },
                values: new object[,]
                {
                    { 1, "TEACHER", "Chuyên môn giảng dạy" },
                    { 2, "SALE", "Kinh doanh" },
                    { 5, "MK", "Marketing & Support" },
                    { 3, "OP", "Operation" },
                    { 4, "TRA", "Training" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "ID", "BENEFIT", "CREATED_BY", "CREATED_DATE", "DEPT_CD", "DESC", "JOB_REQUIRED", "JOB_TYPE_DESC", "MODIFIED_BY", "MODIFIED_DATE", "NAME", "NOTE", "POSITION_CD", "RANK" },
                values: new object[,]
                {
                    { 2172, null, "0000001", new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "OP", "Nhân viên văn phòng", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ADMIN", null, "0015", 8 },
                    { 2173, null, "0000001", new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "TEACHER", "Giáo viên bán thời gian", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TEACHER-PARTTIME", null, "0003", 8 },
                    { 2174, null, "0000001", new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "TEACHER", "Giáo viên Fulltime", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TEACHER-FULLTIME", null, "0004", 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTokens");
        }
    }
}
