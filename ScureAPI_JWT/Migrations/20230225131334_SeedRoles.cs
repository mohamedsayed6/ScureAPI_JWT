using Microsoft.EntityFrameworkCore.Migrations;


#nullable disable

namespace ScureAPI_JWT.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] {"Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values:new object[] { System.Guid.NewGuid().ToString(),"User","USER", System.Guid.NewGuid().ToString() }
                );
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { System.Guid.NewGuid().ToString(), "Admin", "ADMIN", System.Guid.NewGuid().ToString() }
                );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from AspNetRoles");
        }
    }
}
