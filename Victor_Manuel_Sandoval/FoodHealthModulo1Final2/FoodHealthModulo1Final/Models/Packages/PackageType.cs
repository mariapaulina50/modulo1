using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1Final.Models.Packages
{
    public class PackageType
    {

        [Key]
        [Display(Name = "Tipo de paquete")]
        public int PackageTypeID { get; set; }


        [Display(Name = "Tipo de paquete")]
        [Required(ErrorMessage = "Debe Ingresar un {0}")]
        public string Duration { get; set; }

        public virtual ICollection<Package> package { get; set; }
    }
}