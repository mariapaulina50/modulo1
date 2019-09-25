using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1.Models
{
    public class DocumentType
    {
        [Key]
        public int DocumentTypeId { get; set; }

        [Display(Name = "Tipo Documento")]
        public string DocumentName { get; set; }

        public virtual ICollection<Cliente> clientes { get; set; }
    }
}