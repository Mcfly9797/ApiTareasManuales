using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.DTOs
{
    public class MedidaDTO
    {
        public int IdMedida { get; set; }
        public string NombreMedida { get; set; }
        //Asi declaro que se va a relacionar inversamente con Tareas
        public virtual ICollection<TareaDTO> Tarea { get; set; }
    }
}
