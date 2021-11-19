using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CrudDemo.Models
{
    public class Company : BaseObject
    {
        [Required]
        [StringLength(50, ErrorMessage="Name length can't be more than 50")]
        [Display(Name="Company Name")]
        public override string Name { get => base.Name; set => base.Name = value; }
        
        [StringLength(100, ErrorMessage="Country length can't be more than 100")]   
        public string Country { get; set; }

        [StringLength(100, ErrorMessage="State length can't be more than 100")]   
        public string State { get; set; }

        [StringLength(100, ErrorMessage="City length can't be more than 100")]   
        public string City { get; set; }        
        
        [StringLength(200, ErrorMessage="Address length can't be more than 200")]
        public string Address { get; set; }
        
        public List<Department> Departments { get; set; }
        
        
        public Company(string name,string country, string state, string city, string address) : base()    
        {
            Name= name;
            Country= country;
            State=state;
            City= city;
            Address= address;

        }
        public Company()
        {
            
        }
    }
}