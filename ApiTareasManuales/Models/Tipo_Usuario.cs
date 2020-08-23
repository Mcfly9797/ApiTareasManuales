using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.Models
{
    public class Tipo_Usuario
    {

        public int Id { get; set; }
        public int Tipo { get; set; }
        public string Nombre { get; set; }
        public ICollection<Usuario> Usuario_TipoUsuario { get; set; } //Creo la relacion inversa con la tabla Usuario_TipoUsuario que aloja una FK hacia aca
    }
}
