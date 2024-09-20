using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RTT.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlternativeContactNum",
                table: "ClientInfos");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "ClientInfos");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "ClientInfos");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "ClientInfos");

            migrationBuilder.DropColumn(
                name: "HomeAddress",
                table: "ClientInfos");

            migrationBuilder.DropColumn(
                name: "WorkAddress",
                table: "ClientInfos");

            migrationBuilder.CreateTable(
                name: "AdditionalInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlternativeContactNum = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalInfos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalInfos");

            migrationBuilder.AddColumn<string>(
                name: "AlternativeContactNum",
                table: "ClientInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "ClientInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "ClientInfos",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "ClientInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress",
                table: "ClientInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkAddress",
                table: "ClientInfos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
