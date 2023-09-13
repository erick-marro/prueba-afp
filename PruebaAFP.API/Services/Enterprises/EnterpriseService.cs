using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PruebaAFP.API.Data;
using PruebaAFP.API.Extensions;
using PruebaAFP.API.Models;
using PruebaAFP.Contracts.Enterprises;

namespace PruebaAFP.API.Services.Enterprises
{
    public class EnterpriseService : IEnterpriseService
    {

        private readonly ILogger<EnterpriseService> _logger;
        private readonly AFPDbContext _context;

        public EnterpriseService(
            ILogger<EnterpriseService> logger,
            AFPDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<EnterpriseResponse> CreateEnterprise(CreateEnterpriseRequest request)
        {
            try
            {
                Enterprise enterprise = new Enterprise()
                {
                    Id = Guid.NewGuid(),
                    Company = request.enterprise,
                    CompanyName = request.companyName,
                    RegistrationDate = request.registrationDate,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                };

                await _context.Enterprises.AddAsync(enterprise);
                await _context.SaveChangesAsync();

                var response = enterprise.ConvertToEnterpriseResponse();

                return response;


            } catch (Exception ex)
            {
                _logger.LogError($"No se pudo guardar la empresa {ex.Message}");
                throw ex;
            }

        }

        public async Task<EnterpriseResponse> GetEnterprise(Guid id)
        {
            try
            {
                var enterprise = await _context.Enterprises.FindAsync(id);

                if (enterprise != null)
                {
                    return enterprise.ConvertToEnterpriseResponse();
                }

                return null;
            } catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                throw ex;
            }
        }
    }
}
