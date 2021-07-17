using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        [Display(Name = "Email ID")]
        public string Email { get; set; }


        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Country")]
        public string Country { get; set; }
    }
}
