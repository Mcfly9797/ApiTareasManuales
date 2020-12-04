using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.Models
{   //Elemento seria el objeto que fue involucrado en la tarea
    public class Elemento
    {
        [Key]
        public int IdElemento { get; set; }

        [Required(ErrorMessage ="Este campo es requerido")]
        [MaxLength(20, ErrorMessage = "Este campo acepta hasta 20 caracteres")]
        public string NombreElemento { get; set; }
        
        //Asi declaro que se va a relacionar con muchas tareas
        //public virtual ICollection<Tarea> Tarea { get; set; }

    }
}
