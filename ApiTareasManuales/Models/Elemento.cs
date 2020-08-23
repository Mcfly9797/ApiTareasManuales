using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.Models
{
    public class Elemento
    {
        public int Id { get; set; }
        public int Nombre { get; set; }
        //Asi declaro que se va a relacionar con muchas tareas
        public virtual ICollection<Tarea> Tareas { get; set; }

    }
}
