namespace PruebaAFP.Contracts.Departments
{
    public record DepartmentResponse(
        Guid id,
        string department,
        int employees,
        int organizationLevel,
        Guid enterprise,
        DateTime createdAt,
        DateTime updatedAt);
}
