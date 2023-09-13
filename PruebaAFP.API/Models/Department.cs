namespace PruebaAFP.API.Models
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Employees { get; set; }
        public int OrganizationLevel { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Relational properties
        public Guid EnterpriseId { get; set; } // Foreign Key
        public Enterprise Enterprise { get; set; } // Navigation Reference

    }
}
