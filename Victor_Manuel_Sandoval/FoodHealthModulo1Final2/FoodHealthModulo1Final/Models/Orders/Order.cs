using FoodHealthModulo1Final.Models.Profiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1Final.Models.Orders
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Display(Name = "Fecha de Orden")]
        [Required(ErrorMessage = "Debe ingresar una {0})")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOrder { get; set; }
        public int CustomerId { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}