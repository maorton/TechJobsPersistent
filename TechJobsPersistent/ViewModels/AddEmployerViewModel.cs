using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        
        [Required(ErrorMessage ="Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Location is required.")]
        public string Location { get; set; }


    
    }
}
