using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TelephoneDirectory.Migrations
{
    public partial class person1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseEntities",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TypeEntity_email",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TypeEntity_number",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "BaseEntities");

            migrationBuilder.RenameTable(
                name: "BaseEntities",
                newName: "TypeEntities");

            migrationBuilder.AlterColumn<string>(
                name: "number",
                table: "TypeEntities",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "TypeEntities",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeEntities",
                table: "TypeEntities",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    email = table.Column<string>(type: "text", nullable: false),
                    number = table.Column<string>(type: "text", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    creates_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updates_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    creates_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updates_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeEntities",
                table: "TypeEntities");

            migrationBuilder.RenameTable(
                name: "TypeEntities",
                newName: "BaseEntities");

            migrationBuilder.AlterColumn<string>(
                name: "number",
                table: "BaseEntities",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "BaseEntities",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BaseEntities",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BaseEntities",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "BaseEntities",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "BaseEntities",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeEntity_email",
                table: "BaseEntities",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeEntity_number",
                table: "BaseEntities",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "BaseEntities",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseEntities",
                table: "BaseEntities",
                column: "Id");
        }
    }
}
