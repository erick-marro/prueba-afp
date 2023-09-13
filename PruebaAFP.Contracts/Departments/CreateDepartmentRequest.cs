using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAFP.Contracts.Departments
{
    public record CreateDepartmentRequest(
        string department,
        int employees,
        int organizationLevel,
        Guid enterprise);
}
