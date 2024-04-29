using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Enviro365Assessment_Jnr_DOTNET.Migrations
{
    /// <inheritdoc />
    public partial class ImproveDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnvironmentDataId",
                table: "EnvFile",
                newName: "EnvDataId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnvDataId",
                table: "EnvFile",
                newName: "EnvironmentDataId");
        }
    }
}
