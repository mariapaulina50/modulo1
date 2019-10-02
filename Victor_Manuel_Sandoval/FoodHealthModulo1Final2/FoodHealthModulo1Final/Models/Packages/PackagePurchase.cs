using System.ComponentModel.DataAnnotations;

namespace FoodHealthModulo1Final.Models.Packages
{
    public class PackagePurchase : Package
    {
        [Display(Name = "Cantidad")]
        public float Quantity { get; set; }

        public decimal Value { get { return Price * (decimal)Quantity; } }
    }
}