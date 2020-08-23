using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        //Asi se declara una FK
        public int Tipo_UsuarioId { get; set; }
        //Asi creo una relacion a nivel objetos para acceder a los datos
        public Tipo_Usuario Tipo_Usuario { get; set; }                                                                          //public Usuario_TipoUsuario Usuario_TipoUsuario { get; set; } //Creo la relacion a nivel objeto con la tabla Usuario_TipoUsuario que aloja una FK hacia aca.

    }
}
