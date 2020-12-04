using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.Models
{
    public class Herramienta_Reparacion
    {
        [Key]
        public int IdHerramienta_Reparacion { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(20, ErrorMessage = "Este campo acepta hasta 20 caracteres")]
        public string NombreHerramienta_Reparacion { get; set; }

    }
}
