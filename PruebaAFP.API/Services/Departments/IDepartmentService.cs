using PruebaAFP.Contracts.Departments;

namespace PruebaAFP.API.Services.Departments
{
    public interface IDepartmentService
    {
        Task<DepartmentResponse> CreateDepartment(CreateDepartmentRequest request);
        Task<DepartmentResponse> GetDepartment(Guid id);
        Task<IEnumerable<DepartmentResponse>> GetByEnterprise(Guid enterprise);
    }
}
