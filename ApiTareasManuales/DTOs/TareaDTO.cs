using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.DTOs
{


    public class TareaDTO
    {
        public int IdTarea { get; set; }
        public int NroSerie { get; set; }
        public string Detalle { get; set; }
        public DateTime Duracion { get; set; }
        public DateTime Fecha { get; set; }

        //Foreign keys
        public int UserId { get; set; }
        public int Tipo_TrabajoId { get; set; }
        public int ElementoId { get; set; }
        public int MedidaId { get; set; }
        public int DisenioId { get; set; }

        //Relacion Objetos
        public virtual UserDTO Usuario { get; set; }
        public virtual Tipo_TrabajoDTO Tipo_Trabajo { get; set; }
        public virtual ElementoDTO Elemento { get; set; }
        public virtual MedidaDTO Medida { get; set; }
        public virtual DisenioDTO Disenio { get; set; }
    }
}
