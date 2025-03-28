using System.ComponentModel.DataAnnotations;

namespace EMS_Project.Data_Layer.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(100)]
        public string DepartmentName { get; set; }

        public DateTime CreatedAt { get; set; }

        // Navigation property for one-to-many relationship with Employee
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
