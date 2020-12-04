using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.DTOs
{
    public class UserDTO
    {
        public int IdUser { get; set; }

        [Required(ErrorMessage ="El campo es requerido")]
        public string NombreUser { get; set; }
        public string Clave { get; set; }
        //Asi se declara una FK
        public int Tipo_UserId { get; set; }
        //Asi creo una relacion a nivel objetos para acceder a los datos
        public Tipo_UserDTO Tipo_User { get; set; }                                                                          //public Usuario_TipoUsuario Usuario_TipoUsuario { get; set; } //Creo la relacion a nivel objeto con la tabla Usuario_TipoUsuario que aloja una FK hacia aca.

    }
}
