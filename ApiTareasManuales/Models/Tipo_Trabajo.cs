using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.Models
{
    public class Tipo_Trabajo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        //Asi declaro que se va a relacionar con muchas tareas
        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}
