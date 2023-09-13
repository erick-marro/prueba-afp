using PruebaAFP.API.Extensions;
using PruebaAFP.API.Models;
using Xunit;


namespace PruebaAFP.API.Tests
{
    public class EnterpriseExtensionsTests
    {
        [Fact]
        public void ConvertToEnterpriseResponseTest()
        {
            // Arrange
            var enterprise = new Enterprise
            {
                Id = Guid.NewGuid(),
                Company = "Empresa",
                CompanyName = "Nombre de la Empresa",
                RegistrationDate = DateTime.Now,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            // Act
            var result = enterprise.ConvertToEnterpriseResponse();

            // Assert
            Assert.Equal(enterprise.Id, result.id);
            Assert.Equal(enterprise.Company, result.enterprise);
            Assert.Equal(enterprise.CompanyName, result.companyName);
            Assert.Equal(enterprise.RegistrationDate, result.registrationDate);
            Assert.Equal(enterprise.CreatedAt, result.createdAt);
            Assert.Equal(enterprise.UpdatedAt, result.updatedAt);
        }
    }
}
