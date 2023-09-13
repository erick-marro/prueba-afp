namespace PruebaAFP.API.Models
{
    public class Enterprise
    {
        public Guid Id { get; set; }

        public string Company { get; set; }
        public string CompanyName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Relational Properties
        public ICollection<Department> Departments { get; } = new List<Department>();


    }
}
