using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1Final.Models.Profiles
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }

        [Display(Name = "Nombre del rol")]
        [Required(ErrorMessage = "Debe ingresar un {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre (2) y (1) caracteres", MinimumLength = 3)]
        public string RoleName { get; set; }

        public virtual ICollection<Employee> employee { get; set; }
    }
}