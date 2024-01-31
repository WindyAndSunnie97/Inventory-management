using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuanlyKho1.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    InventoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.InventoryID);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Phone = table.Column<string>(type: "char(10)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    UserName = table.Column<string>(type: "char(20)", nullable: false),
                    Password = table.Column<string>(type: "char(50)", nullable: false),
                    RoleID = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<long>(type: "bigint", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonID = table.Column<long>(type: "bigint", nullable: false),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Classify = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentID);
                    table.ForeignKey(
                        name: "FK_Documents_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsDetail",
                columns: table => new
                {
                    ProductDetailID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<long>(type: "bigint", nullable: false),
                    InventoryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsDetail", x => x.ProductDetailID);
                    table.ForeignKey(
                        name: "FK_ProductsDetail_Inventory_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "Inventory",
                        principalColumn: "InventoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsDetail_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DcDetail",
                columns: table => new
                {
                    DcDetailID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    DocumentID = table.Column<long>(type: "bigint", nullable: false),
                    ProductDetailID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DcDetail", x => x.DcDetailID);
                    table.ForeignKey(
                        name: "FK_DcDetail_Documents_DocumentID",
                        column: x => x.DocumentID,
                        principalTable: "Documents",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DcDetail_ProductsDetail_ProductDetailID",
                        column: x => x.ProductDetailID,
                        principalTable: "ProductsDetail",
                        principalColumn: "ProductDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { 1L, "Soft Drink" },
                    { 2L, "Beer" },
                    { 3L, "Wine" },
                    { 4L, "Mineral Water" }
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "InventoryID", "Address", "Name" },
                values: new object[] { 1L, "Cộng Hòa", "Kho 1" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonID", "Address", "Email", "Name", "Phone" },
                values: new object[] { 1L, "103/16C Trần Qang Diệu,P14,Q3", "ttathu0907@gmail.com", "Trần Thị Anh Thư", "0945449058" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "RoleID", "UserName" },
                values: new object[] { 1L, "ahihi@gmail.com", "Nguyễn Công Giới", "admin", (byte)1, "admin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Name", "Origin", "Price" },
                values: new object[] { 1L, 3L, "Soju", "Korea", 60000 });

            migrationBuilder.CreateIndex(
                name: "IX_DcDetail_DocumentID",
                table: "DcDetail",
                column: "DocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_DcDetail_ProductDetailID",
                table: "DcDetail",
                column: "ProductDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_PersonID",
                table: "Documents",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_UserID",
                table: "Documents",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsDetail_InventoryID",
                table: "ProductsDetail",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsDetail_ProductID",
                table: "ProductsDetail",
                column: "ProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DcDetail");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "ProductsDetail");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
