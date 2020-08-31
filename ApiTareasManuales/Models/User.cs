using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        [Required(ErrorMessage ="El campo es requerido")]
        [StringLength(30,ErrorMessage ="El campo acepta hasta 30 caracteres")]
        public string NombreUser { get; set; }

        [Required(ErrorMessage ="Este campo es necesario")]
        [StringLength(30, ErrorMessage ="El campo acepta hasta 30 caracteres")]
        public string Clave { get; set; }

        //Asi se declara una FK
        public int Tipo_UserId { get; set; }
        
        //Asi creo una relacion a nivel objetos para acceder a los datos
        public Tipo_User Tipo_User { get; set; }                                                                          //public Usuario_TipoUsuario Usuario_TipoUsuario { get; set; } //Creo la relacion a nivel objeto con la tabla Usuario_TipoUsuario que aloja una FK hacia aca.

    }
}
