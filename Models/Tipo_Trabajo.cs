using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.Models
{
    public class Tipo_Trabajo
    {
        [Key]
        public int IdTipoTrabajo { get; set; }

        [Required(ErrorMessage ="Este campo es requerido")]
        [MaxLength(20, ErrorMessage = "Este campo acepta hasta 20 caracteres")]
        public string NombreTipoTrabajo { get; set; }
        //Asi declaro que se va a relacionar con muchas tareas
        //public virtual ICollection<Tarea> Tarea { get; set; }
    }
}
