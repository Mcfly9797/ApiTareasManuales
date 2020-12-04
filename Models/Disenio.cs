﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasManuales.Models
{
    public class Disenio
    {
        [Key]
        public int IdDisenio { get; set; }

        [Required(ErrorMessage ="Este campo es requerido")]
        [MaxLength(20,ErrorMessage ="Este campo acepta hasta 20 caracteres")]
        public string NombreDisenio { get; set; }

        //Asi declaro que se va a relacionar inversamente con Tareas
        //public virtual ICollection<Tarea> Tarea { get; set; }
    }
}
