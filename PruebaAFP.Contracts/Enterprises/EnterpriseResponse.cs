using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAFP.Contracts.Enterprises
{
    public record EnterpriseResponse(
        Guid id, 
        string enterprise, 
        string companyName,
        DateTime registrationDate,
        DateTime createdAt,
        DateTime updatedAt);
}
