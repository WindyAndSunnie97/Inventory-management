using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanlyKho1.Migrations
{
    /// <inheritdoc />
    public partial class m5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4L);

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "NameUser");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "NameProduct");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Persons",
                newName: "NamePerson");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Inventory",
                newName: "NameInventory");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "NameCategory");

            migrationBuilder.AlterColumn<string>(
                name: "Classify",
                table: "Documents",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameUser",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NameProduct",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NamePerson",
                table: "Persons",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NameInventory",
                table: "Inventory",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NameCategory",
                table: "Categories",
                newName: "Name");

            migrationBuilder.AlterColumn<byte>(
                name: "Classify",
                table: "Documents",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Documents",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Name", "Password", "RoleID", "UserName" },
                values: new object[] { 4L, "maido@gmail.com", "Nguyễn Mai", "staff2", (byte)0, "staff2" });
        }
    }
}
