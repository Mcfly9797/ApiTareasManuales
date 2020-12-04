using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.DTOs
{
    public class Tipo_TrabajoDTO
    {
        public int IdTipoTrabajo { get; set; }
        public string NombreTipoTrabajo { get; set; }
        //Asi declaro que se va a relacionar con muchas tareas
        public virtual ICollection<TareaDTO> Tarea { get; set; }
    }
}
