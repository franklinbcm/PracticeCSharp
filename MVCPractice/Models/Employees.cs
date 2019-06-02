using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPractice.Models
{
    public class Employees
    {
        [DisplayName("Empleado:")]
        [Required(ErrorMessage ="Debe llenar este campo")]
        [StringLength(10)]
        public string Employee { get; set; }

        [DisplayName("Correo:")]
        [Required(ErrorMessage ="Campo Requerido")]
        [RegularExpression(".+@.+\\..+", ErrorMessage ="Invalid Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}