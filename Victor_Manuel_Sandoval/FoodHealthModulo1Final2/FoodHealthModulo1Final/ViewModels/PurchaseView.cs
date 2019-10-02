using FoodHealthModulo1Final.Models.Packages;
using FoodHealthModulo1Final.Models.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1Final.ViewModels
{
    public class PurchaseView
    {
        public Customer Customer { get; set; }
        public PackagePurchase PackagePurchase { get; set; }
        public List<PackagePurchase> PackagePurchase1 { get; set; }
    }
}