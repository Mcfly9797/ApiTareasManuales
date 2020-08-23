using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.Models
{
    public class Medida
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        //Asi declaro que se va a relacionar inversamente con Tareas
        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}
