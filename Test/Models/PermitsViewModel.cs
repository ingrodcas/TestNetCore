using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class PermitsViewModel
    {

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Nombre de Empleado")]
        [Required(ErrorMessage = "Nombre de Empleado Requerido.")]
        public string EmployeeName { get; set; }

        [Display(Name = "Apellidos de Empleado")]
        [Required(ErrorMessage = "Apellidos de Empleado Requerido.")]
        public string EmployeeLastName { get; set; }

        [Display(Name = "Tipo de Permiso")]
        [Required(ErrorMessage = "Tipo de Permiso Requerido.")]
        public int PermissionType { get; set; }

        public DateTime PermitDate { get; set; }
    }
}
