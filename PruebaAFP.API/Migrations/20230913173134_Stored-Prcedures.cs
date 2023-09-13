using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaAFP.API.Migrations
{
    /// <inheritdoc />
    public partial class StoredPrcedures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
CREATE PROCEDURE [dbo].[sp_GetCompanyData]
    @Id UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        Company,
        CompanyName,
        RegistrationDate,
        CreatedAt,
        UpdatedAt
    FROM Enterprises
    WHERE Id = @Id
END;
            ");
            migrationBuilder.Sql(@"
CREATE PROCEDURE [dbo].[sp_GetDepartmentsByCompany]
    @CompanyId UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        d.Name AS DepartmentName,
        d.Employees,
        d.OrganizationLevel
    FROM Departments AS d
    WHERE d.EnterpriseId = @CompanyId;
END;

");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
