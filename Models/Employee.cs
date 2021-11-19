using System.ComponentModel.DataAnnotations;

namespace CrudDemo.Models
{
    public class Employee : BaseObject
    {
        [Required]
        [StringLength(100, ErrorMessage="Full Name length can't be more than 100")]
        [Display(Name="Full Name")]
        public override string Name { get => base.Name; set => base.Name = value; }

        public string DepartmentId { get; set; }
      
        public Department Department { get; set; }

         public EmployeeType EmployeeType { get; set; }
        
        
        
    }
    
}