using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1.Models
{
    public class Assessment
    {
        [key]
        public int AssessmentID { get; set; }
        public int ClienteID { get; set; }
    }
}