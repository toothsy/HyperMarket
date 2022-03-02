using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HyperMarket.Data.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblActivityType",
                columns: table => new
                {
                    ActivityTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ActivityTypeName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblActivityType", x => x.ActivityTypeId);
                });

            migrationBuilder.CreateTable(
                name: "tblBlog",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlogTitle = table.Column<string>(type: "TEXT", nullable: false),
                    BlogContent = table.Column<string>(type: "TEXT", nullable: false),
                    BlogAuthor = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedById = table.Column<int>(type: "INTEGER", nullable: false),
                    UpdatedById = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBlog", x => x.BlogId);
                });

            migrationBuilder.CreateTable(
                name: "tblBusinessDetail",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    BusinessName = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<string>(type: "TEXT", nullable: false),
                    BusinessDescription = table.Column<string>(type: "TEXT", nullable: false),
                    TopBrands = table.Column<bool>(type: "INTEGER", nullable: false),
                    ProductsSold = table.Column<int>(type: "INTEGER", nullable: false),
                    LocationId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBusinessDetail", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "tblCategory",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    Commission = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategory", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "tblConfig",
                columns: table => new
                {
                    ConfigId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ConfigName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ConfigValue = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedById = table.Column<int>(type: "INTEGER", nullable: false),
                    UpdatedById = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblConfig", x => x.ConfigId);
                });

            migrationBuilder.CreateTable(
                name: "tblCutomerDetail",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReferalCode = table.Column<string>(type: "TEXT", nullable: false),
                    MyCredits = table.Column<int>(type: "INTEGER", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCutomerDetail", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "tblErrorType",
                columns: table => new
                {
                    ErrorTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ErrorTypeName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblErrorType", x => x.ErrorTypeId);
                });

            migrationBuilder.CreateTable(
                name: "tblFaq",
                columns: table => new
                {
                    FaqId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FaqTitle = table.Column<string>(type: "TEXT", nullable: false),
                    FaqSolution = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedById = table.Column<int>(type: "INTEGER", nullable: false),
                    UpdatedById = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFaq", x => x.FaqId);
                });

            migrationBuilder.CreateTable(
                name: "tblImage",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImageLink = table.Column<string>(type: "TEXT", nullable: false),
                    Product_Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblImage", x => x.ImageId);
                });

            migrationBuilder.CreateTable(
                name: "tblLocation",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LocationName = table.Column<string>(type: "TEXT", nullable: false),
                    IsLocationActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLocation", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "tblOrder",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BusinessName = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<string>(type: "TEXT", nullable: false),
                    MyOrderCredits = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentId = table.Column<string>(type: "TEXT", nullable: false),
                    UderId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrder", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "tblPayment",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PaymentType = table.Column<string>(type: "TEXT", nullable: false),
                    CreditsUsed = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPayment", x => x.PaymentId);
                });

            migrationBuilder.CreateTable(
                name: "tblProduct",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    ProductDescription = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<string>(type: "TEXT", nullable: false),
                    SubCategoryId = table.Column<string>(type: "TEXT", nullable: false),
                    Image = table.Column<bool>(type: "INTEGER", nullable: false),
                    Discount = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    AddressLine1 = table.Column<string>(type: "TEXT", nullable: false),
                    AddressLine2 = table.Column<string>(type: "TEXT", nullable: false),
                    AddressLine3 = table.Column<string>(type: "TEXT", nullable: false),
                    Pin = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: false),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProduct", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "tblRequest",
                columns: table => new
                {
                    RequestId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductsId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRequest", x => x.RequestId);
                });

            migrationBuilder.CreateTable(
                name: "tblRole",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRole", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "tblSubCategory",
                columns: table => new
                {
                    SubCategoryId = table.Column<string>(type: "TEXT", nullable: false),
                    SubCategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSubCategory", x => x.SubCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "tblUser",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmailId = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    ReferredBy = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<int>(type: "INTEGER", nullable: false),
                    UpdatedBy = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUser", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "tblUserRole",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUserRole", x => x.UserRoleId);
                });

            migrationBuilder.CreateTable(
                name: "tblActivityLog",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    UrlOrModule = table.Column<string>(type: "TEXT", nullable: false),
                    ActivityTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblActivityLog", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_tblActivityLog_tblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblErrorLog",
                columns: table => new
                {
                    ErrorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    UrlOrModule = table.Column<string>(type: "TEXT", nullable: false),
                    ErrorTimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    ErrorTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsResolved = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblErrorLog", x => x.ErrorId);
                    table.ForeignKey(
                        name: "FK_tblErrorLog_tblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblActivityLog_UserId",
                table: "tblActivityLog",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblErrorLog_UserId",
                table: "tblErrorLog",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblActivityLog");

            migrationBuilder.DropTable(
                name: "tblActivityType");

            migrationBuilder.DropTable(
                name: "tblBlog");

            migrationBuilder.DropTable(
                name: "tblBusinessDetail");

            migrationBuilder.DropTable(
                name: "tblCategory");

            migrationBuilder.DropTable(
                name: "tblConfig");

            migrationBuilder.DropTable(
                name: "tblCutomerDetail");

            migrationBuilder.DropTable(
                name: "tblErrorLog");

            migrationBuilder.DropTable(
                name: "tblErrorType");

            migrationBuilder.DropTable(
                name: "tblFaq");

            migrationBuilder.DropTable(
                name: "tblImage");

            migrationBuilder.DropTable(
                name: "tblLocation");

            migrationBuilder.DropTable(
                name: "tblOrder");

            migrationBuilder.DropTable(
                name: "tblPayment");

            migrationBuilder.DropTable(
                name: "tblProduct");

            migrationBuilder.DropTable(
                name: "tblRequest");

            migrationBuilder.DropTable(
                name: "tblRole");

            migrationBuilder.DropTable(
                name: "tblSubCategory");

            migrationBuilder.DropTable(
                name: "tblUserRole");

            migrationBuilder.DropTable(
                name: "tblUser");
        }
    }
}
