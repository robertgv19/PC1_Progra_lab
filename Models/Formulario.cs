using System;
using System.ComponentModel.DataAnnotations;

namespace Practica_1.Models
{
    public class Formulario
    {
        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre_Est")]
        public String Nombre_Est { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellido_Est")]
        public String Apellido_Est { get; set; }

            [Display(Name="Distrito")]
        public String Distrito { get; set; }

            [Display(Name="Banco")]
        public String Banco { get; set; }

        [Display(Name="Genero")]
        public String Genero { get; set; }

        [Display(Name="Autor")]
        public String Autor { get; set; }

        [Display(Name="Respuesta")]
        public String Respuesta { get; set; }

    }
}