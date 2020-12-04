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
        public int UserId { get; set; }
        public string NombreUser { get; set; }
        public string Detalle { get; set; }
        public DateTime Duracion { get; set; }
        public DateTime Fecha { get; set; }
        
        public int Tipo_TrabajoId { get; set; }
        public string Tipo_Trabajo { get; set;}
        
        public int ElementoId { get; set; }
        public string Elemento { get; set; }

        public int MedidaId { get; set; }
        public string Medida { get; set; }

        public int DisenioId { get; set; }
        public string Disenio { get; set; }

    }
}
