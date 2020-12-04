using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.Models
{
    public class Tipo_User
    {
        [Key]
        public int IdTipoUser { get; set; }

        [Required(ErrorMessage ="Este campo es requerido")]
        public int TipoUser { get; set; }

        [Required(ErrorMessage ="Este campo es requerido")]
        [MaxLength(20, ErrorMessage = "Este campo acepta hasta 20 caracteres")]
        public string NombreTipoUser { get; set; }

        //public ICollection<User> Users { get; set; } //Creo la relacion inversa con la tabla Usuario_TipoUsuario que aloja una FK hacia aca
    }
}
