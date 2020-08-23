using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.Models
{


    public class Tarea
    {
        public int Id { get; set; }
        public int NroSerie { get; set; }
        public string Detalle { get; set; }
        public DateTime Duracion { get; set; }
        public DateTime Fecha { get; set; }

        //Foreign keys
        public int UsuarioId { get; set; }
        public int Tipo_TrabajoId { get; set; }
        public int ElementoId { get; set; }
        public int MedidaId { get; set; }
        public int DisenioId { get; set; }

        //Relacion Objetos
        public virtual Usuario Usuario { get; set; }
        public virtual Tipo_Trabajo Tipo_Trabajo { get; set; }
        public virtual Elemento Elemento { get; set; }
        public virtual Medida Medida { get; set; }
        public virtual Disenio Disenio { get; set; }
    }
}
