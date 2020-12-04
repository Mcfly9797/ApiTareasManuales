using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.DTOs
{
    public class Tipo_UserDTO
    {
        public int IdTipoUser { get; set; }
        public int TipoUser { get; set; }
        public string NombreTipoUser { get; set; }

        //Creo la relacion inversa con la tabla Usuario_TipoUsuario que aloja una FK hacia aca
        public ICollection<UserDTO> Usuario_TipoUser { get; set; } 
    }
}
