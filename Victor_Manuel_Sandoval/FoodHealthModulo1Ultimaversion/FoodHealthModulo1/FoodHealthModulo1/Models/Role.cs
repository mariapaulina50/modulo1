using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }

        [Display(Name = "Nombre del rol")]
        public string RoleName { get; set; }

        public virtual ICollection<Cliente> clientes { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

    }
}