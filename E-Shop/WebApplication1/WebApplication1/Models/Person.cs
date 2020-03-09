using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Person
    {
        [DisplayName("Jméno")]
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }

        [DisplayName("Prijmeni")]
        [RegularExpression(@"^.+@.+\..+$", ErrorMessage = "Neni email")]
        public string Surname { get; set; }

        [DisplayName("Vek")]
        [Required]
        [Range(0, 100)]
        public int Age { get; set; }
    }
}