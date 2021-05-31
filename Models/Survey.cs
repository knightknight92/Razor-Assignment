using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_Assignment.Models
{
    public class Survey
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must enter your new to continue")] 
        public string Response { get; set; }

    }
}
