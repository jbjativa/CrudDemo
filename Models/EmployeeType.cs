using System.ComponentModel.DataAnnotations;

namespace CrudDemo.Models
{
    public enum EmployeeType
    {
        [Display(Name = "Part-Time")]
        FullTime,
        [Display(Name = "Full-Time")]
        PartTime

    }
}