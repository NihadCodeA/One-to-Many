using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaMVC.Migrations
{
    public partial class Teams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamSocialMediaAccount_Team_TeamId",
                table: "TeamSocialMediaAccount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamSocialMediaAccount",
                table: "TeamSocialMediaAccount");

            migrationBuilder.RenameTable(
                name: "TeamSocialMediaAccount",
                newName: "TeamSocialMediaAccounts");

            migrationBuilder.RenameIndex(
                name: "IX_TeamSocialMediaAccount_TeamId",
                table: "TeamSocialMediaAccounts",
                newName: "IX_TeamSocialMediaAccounts_TeamId");

            migrationBuilder.AddColumn<int>(
                name: "TestimonialId",
                table: "TeamSocialMediaAccounts",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamSocialMediaAccounts",
                table: "TeamSocialMediaAccounts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TeamSocialMediaAccounts_TestimonialId",
                table: "TeamSocialMediaAccounts",
                column: "TestimonialId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamSocialMediaAccounts_Team_TeamId",
                table: "TeamSocialMediaAccounts",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamSocialMediaAccounts_Testimonials_TestimonialId",
                table: "TeamSocialMediaAccounts",
                column: "TestimonialId",
                principalTable: "Testimonials",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamSocialMediaAccounts_Team_TeamId",
                table: "TeamSocialMediaAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamSocialMediaAccounts_Testimonials_TestimonialId",
                table: "TeamSocialMediaAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamSocialMediaAccounts",
                table: "TeamSocialMediaAccounts");

            migrationBuilder.DropIndex(
                name: "IX_TeamSocialMediaAccounts_TestimonialId",
                table: "TeamSocialMediaAccounts");

            migrationBuilder.DropColumn(
                name: "TestimonialId",
                table: "TeamSocialMediaAccounts");

            migrationBuilder.RenameTable(
                name: "TeamSocialMediaAccounts",
                newName: "TeamSocialMediaAccount");

            migrationBuilder.RenameIndex(
                name: "IX_TeamSocialMediaAccounts_TeamId",
                table: "TeamSocialMediaAccount",
                newName: "IX_TeamSocialMediaAccount_TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamSocialMediaAccount",
                table: "TeamSocialMediaAccount",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamSocialMediaAccount_Team_TeamId",
                table: "TeamSocialMediaAccount",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
