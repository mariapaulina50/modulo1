using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1.Models
{
    public class Diary
    {
        [key]
        public int DiaryID { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "Debe ingresar una {0})")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Display(Name = "Sede")]
        [Required(ErrorMessage = "Debe ingresar los {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre (2) y (1) caracteres", MinimumLength = 3)]
        public string Sede { get; set; }

        [Display(Name = "Nutricionista")]
        [Required(ErrorMessage = "Debe ingresar los {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre (2) y (1) caracteres", MinimumLength = 3)]
        public string Nutricionista { get; set; }

        [Display(Name = "Ciudad")]
        [Required(ErrorMessage = "Debe ingresar los {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre (2) y (1) caracteres", MinimumLength = 3)]
        public string Ciudad { get; set; }

        [Display(Name = "Hora cita")]
        [DisplayFormat(DataFormatString = "{00-00}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        [Required(ErrorMessage = "Debe ingresar los {0}")]
        public DateTime Hora_cita { get; set; }




    }
}