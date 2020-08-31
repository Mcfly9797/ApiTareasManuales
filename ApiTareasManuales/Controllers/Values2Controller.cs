using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTareasManuales.DTOs;
using ApiTareasManuales.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiTareasManuales.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Values2Controller : ControllerBase
    {

        //Context
        private readonly MyDbContext _context;
        
        //Constructor
        public Values2Controller(MyDbContext context)
        {
            context = _context;
        }


        //Controladores
        [HttpGet]
        public  IActionResult GetSpeakers()
        {
            var medidaFromDatabase =  _context.Medida.ToList();
            var medidaDTO = new List<MedidaDTO>();
            foreach (var medida in medidaFromDatabase)
            {
                medidaDTO.Add(new MedidaDTO
                {
                    IdMedida = medida.IdMedida,
                    NombreMedida = medida.NombreMedida,
                    Tarea = (ICollection<TareaDTO>)medida

                });
            }
            return Ok(medidaDTO);
        }

        //// GET: api/<ValuesController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
    }
}
