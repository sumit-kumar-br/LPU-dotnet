using System.ComponentModel.DataAnnotations;

namespace EFCoreMVCWebDemo.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }

        [Required(ErrorMessage = "Mandatory")]
        public string Name { get; set; }
        public string Location { get; set; }

        //One to many relationships
        public ICollection<Employee> Employees { get; set; }
    }
}

