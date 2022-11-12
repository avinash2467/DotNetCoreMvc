using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime Dob { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int EmployeeStatus { get; set; }
        public int CreatedBy { get; set; }
        public bool Active { get; set; } = true;
    }
}
