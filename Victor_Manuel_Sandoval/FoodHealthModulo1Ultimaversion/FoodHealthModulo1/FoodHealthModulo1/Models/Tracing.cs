using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1.Models
{
    public class Tracing
    {
        [key]
        public int TracingID { get; set; }

        [Display(Name = "Fecha Seguimiento")]
        [Required(ErrorMessage = "Debe ingresar una {0})")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha_de_seguimiento { get; set; }

        [Display(Name = "Peso")]
        public int Peso { get; set; }

        [Display(Name = "Estatura")]
        public int Estatura { get; set; }

        [Display(Name = "Medida de cuello")]
        public int Medida_de_cuello { get; set; }

        [Display(Name = "Medida de busto")]
        public int Medida_de_busto { get; set; }

        [Display(Name = "Medida de cintura")]
        public int Medida_de_cintura { get; set; }

        [Display(Name = "IMC")]
        public int IMC { get; set; }

        [Display(Name = "Grasa")]
        public int Grasa { get; set; }

        [Display(Name = "Medida de pierna derecha")]
        public int Medida_de_pierna_derecha { get; set; }

        [Display(Name = "Medida de pierna izquierda")]
        public int Medida_de_pierna_izquierda { get; set; }



    }
}