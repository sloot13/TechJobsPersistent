using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage ="Must have a Name")]
        public string Name { get; set;}
        [Required(ErrorMessage ="Must have a Location")]
        public string Location { get; set;}

        public AddEmployerViewModel()
        {

        }
    }
}
