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
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Tipo_Usuario> Tipo_Usuario { get; set; }
         public DbSet<Tipo_Trabajo> Tipo_Trabajo { get; set; }
        public DbSet<Elemento> Elemento { get; set;}
        public DbSet<Medida> Medida { get; set; }
        public DbSet<Disenio> Disenio { get; set; }
        public DbSet<Tarea> Tarea { get; set; }
    }
}

