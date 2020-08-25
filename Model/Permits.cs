using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Permits
    {
        public int Id { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeLastName { get; set; }

        public int PermissionType { get; set; }

        public DateTime PermitDate { get; set; }
    }
}
