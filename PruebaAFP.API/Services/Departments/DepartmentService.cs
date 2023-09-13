using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PruebaAFP.API.Data;
using PruebaAFP.API.Extensions;
using PruebaAFP.API.Models;
using PruebaAFP.Contracts.Departments;

namespace PruebaAFP.API.Services.Departments
{
    public class DepartmentService : IDepartmentService
    {

        private readonly ILogger<DepartmentService> _logger;
        private readonly AFPDbContext _context;

        public DepartmentService(
            ILogger<DepartmentService> logger,
            AFPDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<DepartmentResponse> CreateDepartment(CreateDepartmentRequest request)
        {
            try
            {
                Department department = new Department()
                {
                    Id = Guid.NewGuid(),
                    Name = request.department,
                    Employees = request.employees,
                    OrganizationLevel = request.organizationLevel,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    EnterpriseId = request.enterprise
                };

                await _context.Departments.AddAsync(department);
                await _context.SaveChangesAsync();

                return department.ConvertToDeptartmentResponse();
            } catch (Exception ex)
            {
                _logger.LogError($"Error {ex.Message}");
                return null;
            }

        }

        public async Task<IEnumerable<DepartmentResponse>> GetByEnterprise(Guid enterprise)
        {
            try
            {

                var response = new List<DepartmentResponse>();

                var departments = await _context.Departments.Where(d => d.EnterpriseId == enterprise).ToListAsync();

                foreach (var department in departments)
                {
                    var depto = department.ConvertToDeptartmentResponse();
                    response.Add(depto);
                }

                return response;
            } catch(Exception ex)
            {
                _logger.LogError($"Error {ex.Message}");
                return null;
            }
        }

        public Task<DepartmentResponse> GetDepartment(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
