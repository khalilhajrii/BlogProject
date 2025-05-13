using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProject.Migrations
{
    /// <inheritdoc />
    public partial class superadmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84d97bfd-8f03-457d-9c5d-63c2d3fc40e3",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a2603ec8-bbc1-4d25-a560-21e888f1328f", "superadmin@blog.com", "SUPERADMIN@BLOG.COM", "SUPERADMIN@BLOG.COM", "AQAAAAIAAYagAAAAENrtQNE9WBG7pYRShL2/6/OijCEN0j6V9veIksjiE0fDedBiKTlZMYZX1GdJeakCZg==", "1cc9ddb4-e5e3-4888-8118-97d7dc59a82a", "superadmin@blog.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84d97bfd-8f03-457d-9c5d-63c2d3fc40e3",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "18f45ab7-85d5-46f2-a986-57a9391a0544", "superadmin@bloggie.com", "SUPERADMIN@BLOGGIE.COM", "SUPERADMIN@BLOGGIE.COM", "AQAAAAIAAYagAAAAEHWYNIItkKSvE35bSRH1adLPGNeZqDfSAtxrC/LvonJzs6NvBr6/lqP6LgaGReUxTQ==", "2c08def1-1adc-4150-b25a-ea9bb8c2c74b", "superadmin@bloggie.com" });
        }
    }
}
