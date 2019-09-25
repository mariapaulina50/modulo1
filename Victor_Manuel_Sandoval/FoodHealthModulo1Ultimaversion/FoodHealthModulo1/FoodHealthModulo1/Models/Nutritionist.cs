using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1.Models
{
    public class Nutritionist
    {
        [key]
        public int NutritionistID { get; set; }
        public int ClienteID { get; set; }
    }
}