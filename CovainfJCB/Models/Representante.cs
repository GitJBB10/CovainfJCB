using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovainfJCB.Models
{
    public class Representante
    {
        [Key]
        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name ="Identificación")]
        [MinLength(10, ErrorMessage ="Debe ingresar 10 numeros")]
        [MaxLength(10)]
        public  string Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(30)]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(30)]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MinLength(10, ErrorMessage = "Debe ingresar 10 numeros")]
        [MaxLength(10)]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(50)]
        public string Direccion { get; set; }

        
    }
}
