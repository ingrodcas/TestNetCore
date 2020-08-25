using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class PermissionTypesViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description Requerido.")]
        public string Description { get; set; }
    }
}
