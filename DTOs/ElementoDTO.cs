using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.DTOs
{
    public class ElementoDTO
    {
        public int IdElemento { get; set; }
        public string NombreElemento { get; set; }
        //Asi declaro que se va a relacionar con muchas tareas
        public virtual ICollection<TareaDTO> Tarea { get; set; }

    }
}
