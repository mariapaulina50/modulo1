using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1Final.Models.Profiles
{
    public class DocumentType
    {
        [Key]
        [Display(Name = "Documento")]
        public int DocumentTypeID { get; set; }

        [Display(Name = "Tipo de Documento")]
        [Required(ErrorMessage = "Debe ingresar el {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre (2) y (1) caracteres", MinimumLength = 3)]
        public string NameDocument { get; set; }

        
    }
}