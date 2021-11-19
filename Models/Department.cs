using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrudDemo.Models
{
    public class Department : BaseObject
    {
        [Required]
        [StringLength(20, ErrorMessage="Name length can't be more than 20")]
        [Display(Name="Department Name")]
        public override string Name { get => base.Name; set => base.Name = value; }

        public List<Employee> Employees { get; set; }

        public string CompanyId { get; set; }
        
        public Company Company { get; set; }
        
        
        
        
    }
}