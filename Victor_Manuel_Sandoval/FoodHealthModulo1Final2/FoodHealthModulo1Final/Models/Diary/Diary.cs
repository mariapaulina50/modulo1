using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1Final.Models.Diary
{
    public class Diary
    {
        [Key]
        [Display(Name = "Agenda")]
        public int DiaryID { get; set; }

        [Display(Name = "Cita")]
        public int AppointmentTypeID { get; set; }

        [Display(Name = "Fecha de la cita")]
        [Required(ErrorMessage = "Debe ingresar una {0})")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfAppointment { get; set; }

        public virtual AppointmentType AppointmentType { get; set; }
    }
}