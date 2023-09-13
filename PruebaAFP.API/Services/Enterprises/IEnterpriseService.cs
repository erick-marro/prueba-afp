using PruebaAFP.Contracts.Enterprises;

namespace PruebaAFP.API.Services.Enterprises
{
    public interface IEnterpriseService
    {
        Task<EnterpriseResponse> GetEnterprise(Guid id);
        Task<EnterpriseResponse> CreateEnterprise(CreateEnterpriseRequest request);
    }
}
