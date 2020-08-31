using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ApiTareasManuales.Models;

namespace ApiTareasManuales.Models
{
    public class MyDbContext : DbContext
    {
        //MyDbContext es mi contexto que "maneja todo" con la bd. Recordar siempre inicializar los servicios de las conecciones en el archivo "Startup.cs"
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        //Los nombres que les de a estas variables van a ser los de cada tabla. Con cada DbSet creo una tabla.
        public DbSet<User> User { get; set; }
        public DbSet<Tipo_User> Tipo_User { get; set; }
         public DbSet<Tipo_Trabajo> Tipo_Trabajo { get; set; }
        public DbSet<Elemento> Elemento { get; set;}
        public DbSet<Medida> Medida { get; set; }
        public DbSet<Disenio> Disenio { get; set; }
        public DbSet<Tarea> Tarea { get; set; }
    }
}

