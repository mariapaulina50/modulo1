using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1.Models
{
    public class Cliente
    {
        [key]
        public int ClienteID { get; set; }

        [Display(Name = "Tipo Documento")]
        public int DocumentTypeId { get; set; }

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Debe ingresar los {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre (2) y (1) caracteres", MinimumLength = 3)]
        public string Nombres { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Debe ingresar los {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre (2) y (1) caracteres", MinimumLength = 3)]
        public string Apellidos { get; set; }

        [Display(Name = "Documento")]
        public string Documento { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "Debe ingresar los {0}")]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }

        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "Debe ingresar los {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre (2) y (1) caracteres", MinimumLength = 3)]
        public string Usuario { get; set; }

        [Display(Name = "Clave")]
        [Required(ErrorMessage = "Debe ingresar los {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre (2) y (1) caracteres", MinimumLength = 3)]
        [DataType(DataType.Password)]
        public string Clave { get; set; }

        [Display(Name = "Fecha Nacimiento")]
        [Required(ErrorMessage = "Debe ingresar una {0})")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha_de_nacimiento { get; set; }

        [Display(Name = "Pais")]
        [Required(ErrorMessage = "Debe ingresar una {0})")]
        public string Pais { get; set; }

        [Display(Name = "Ciudad")]
        [Required(ErrorMessage = "Debe ingresar una {0})")]
        public string Ciudad { get; set; }

        [Display(Name = "Telefono")]
        [Required(ErrorMessage = "Debe ingresar una {0})")]
        public string Telefono { get; set; }

        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "Debe ingresar los {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre (2) y (1) caracteres", MinimumLength = 3)]
        public string Direccion { get; set; }

        public virtual DocumentType DocumentType { get; set; }
    }
}