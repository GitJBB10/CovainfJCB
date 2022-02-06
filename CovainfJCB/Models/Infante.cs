using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CovainfJCB.Models
{
    public class Infante
    {
        [Key]
        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Identificación")]
        [MinLength(10, ErrorMessage = "Debe ingresar 10 numeros")]
        [MaxLength(10)]
        public string IdInfante { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(30)]
        public string NombresInfante { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(30)]
        public string ApellidosInfante { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechNacimiento { get; set; }


        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(10)]
        public string IdRepresentante { get; set; }
    }
}
