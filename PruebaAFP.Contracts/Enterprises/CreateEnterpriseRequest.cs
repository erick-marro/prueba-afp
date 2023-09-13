
namespace PruebaAFP.Contracts.Enterprises
{
    public record CreateEnterpriseRequest(
        string enterprise, 
        string companyName, 
        DateTime registrationDate);
}
