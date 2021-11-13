using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialDos.Models.ViewModels
{
    public class EstudianteViewModel
    {

        public int StudentId { get; set; }

        [Display(Name = " Segundo Nombre ")]
        [Required(ErrorMessage = "estos campos son requeridos")]
        public string LastName { get; set; }

        [Display(Name = "Primer Nombre ")]
        [Required(ErrorMessage = "estos campos son requeridos")]
        public string FirstMidName { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "estos campos son requeridos")]
        public DateTime EnrrollmentsDate { get; set; }
    }
}