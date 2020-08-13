using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public int Tipo { get; set; }
    }

    public class Tipo_Usuario
    {
        public int Id { get; set; }
        public int Tipo { get; set; }
    }

    public class Usuario_TipoUsuario
    {
        public int Id { get; set; }
        //public int IdUsuario { get; set; }
        //public int IdTipoUsuario { get; set; }
        public ICollection<Usuario> IdUsuarios { get; set; }
        public ICollection<Tipo_Usuario> Tipo_Usuarios { get; set; }
    }

    public class Operario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    
    public class Trabajo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class Elemento_Reparado
    {
        public int Id { get; set; }
        public int Nombre { get; set; }
    }
    public class Medida
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    
    public class Disenio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class Intervencion
    {
        public int Id { get; set; }
        public int IdOperario { get; set; }
        public int NroSerie { get; set; }
        public string Detalle { get; set; }
        public DateTime Tiempo { get; set; }
        public DateTime Fecha { get; set; }
        public ICollection<Trabajo> Trabajos { get; set; }
        public ICollection<Elemento_Reparado> Elemento_Reparados { get; set; }
        //public int IdTrabajo { get; set; }
        //public int IdTrabajo_Reparado { get; set; }
        public ICollection<Medida> Medidas { get; set; }

        //public int IdMedida { get; set; }
        //public int IdDisenio { get; set; }
        public ICollection<Disenio> Disenios { get; set; }
        
    }

}

