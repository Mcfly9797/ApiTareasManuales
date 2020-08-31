using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.Models
{


    public class Tarea
    {
        [Key]
        public int IdTarea { get; set; }
        [Required(ErrorMessage = "Este campo es necesario")]
        public int NroSerie { get; set; }

        //No es necesario que todas las tareas tengan un detalle
        public string Detalle { get; set; }

        [Required(ErrorMessage ="Este campo es requerido")]
        public DateTime Duracion { get; set; }

        [Required(ErrorMessage ="Este campo es requerido")]
        public DateTime Fecha { get; set; }

        //Foreign keys
        public int UserId { get; set; }
        public int Tipo_TrabajoId { get; set; }
        public int ElementoId { get; set; }
        public int MedidaId { get; set; }
        public int DisenioId { get; set; }

        //Relacion Objetos
        public virtual User Usuario { get; set; }
        public virtual Tipo_Trabajo Tipo_Trabajo { get; set; }
        public virtual Elemento Elemento { get; set; }
        public virtual Medida Medida { get; set; }
        public virtual Disenio Disenio { get; set; }
    }
}
