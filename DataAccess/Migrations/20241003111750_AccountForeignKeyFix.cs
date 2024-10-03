using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AccountForeignKeyFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accounts_account_informations_AccountInfoId",
                table: "accounts");

            migrationBuilder.AlterColumn<int>(
                name: "AccountInfoId",
                table: "accounts",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_account_informations_AccountInfoId",
                table: "accounts",
                column: "AccountInfoId",
                principalTable: "account_informations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accounts_account_informations_AccountInfoId",
                table: "accounts");

            migrationBuilder.AlterColumn<int>(
                name: "AccountInfoId",
                table: "accounts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_account_informations_AccountInfoId",
                table: "accounts",
                column: "AccountInfoId",
                principalTable: "account_informations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
