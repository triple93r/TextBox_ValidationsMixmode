using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? eName { get; set; } = string.Empty;
        public string Email { get; set; }
        public int EmployeeId { get; set; } = 0;

        public string Emptype { get; set; }

        public Employee() { 

        }
    }
}
