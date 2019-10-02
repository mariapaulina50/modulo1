using FoodHealthModulo1Final.Models.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1Final.Models.Packages
{
    public class Package
    {
        [Key]
        [Display(Name = "Paquete")]
        public int PackageID { get; set; }

        [Display(Name = "Tipo de paquete")]
        public int PackageTypeID { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "Debe ingresar un {0}")]
        public decimal Price { get; set; }

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Debe Ingresar un {0}")]
        [StringLength(300, ErrorMessage = "El campo {0} debe tener entre (2) y (1) caracteres", MinimumLength = 3)]
        //Si lo pongo mas a la cantidad minima de caracteres tal vez tenga que ponerse a meter mero texto, lo dejo así en 3, pero en realidad deberían ser 100 como minimo.
        public string Description { get; set; }

        public virtual PackageType packagetype { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}