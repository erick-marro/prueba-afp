using PruebaAFP.API.Models;
using PruebaAFP.Contracts.Departments;
using PruebaAFP.Contracts.Enterprises;

namespace PruebaAFP.API.Extensions
{
    public static class DtoConversions
    {
        public static EnterpriseResponse ConvertToEnterpriseResponse(this Enterprise enterprise)
        {
            return new EnterpriseResponse(
                id: enterprise.Id, 
                enterprise: enterprise.Company, 
                companyName: enterprise.CompanyName,
                registrationDate: enterprise.RegistrationDate,
                createdAt: enterprise.CreatedAt,
                updatedAt: enterprise.UpdatedAt);
        }

        public static DepartmentResponse ConvertToDeptartmentResponse(this Department department)
        {
            return new DepartmentResponse(
                id: department.Id,
                department: department.Name,
                employees: department.Employees,
                organizationLevel: department.OrganizationLevel,
                enterprise: department.EnterpriseId,
                createdAt: department.CreatedAt,
                updatedAt: department.UpdatedAt);
        }
    }
}
