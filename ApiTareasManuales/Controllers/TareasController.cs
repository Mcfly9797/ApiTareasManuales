using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiTareasManuales.Models;
using ApiTareasManuales.DTOs;
using Microsoft.AspNetCore.Authentication;

namespace ApiTareasManuales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        private readonly MyDbContext _context;

        public TareasController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Tareas
        [HttpGet]
        public async Task<ActionResult> GetTarea()
        {
            ObjectResult resp;

            var query =
            from tarea in _context.Tarea
            join disenio in _context.Disenio on tarea.Disenio.IdDisenio equals disenio.IdDisenio
            join elemento in _context.Elemento on tarea.Elemento.IdElemento equals elemento.IdElemento
            join medida in _context.Medida on tarea.Medida.IdMedida equals medida.IdMedida
            join tipo_trabajo in _context.Tipo_Trabajo on tarea.Tipo_Trabajo.IdTipoTrabajo equals tipo_trabajo.IdTipoTrabajo
            join user in _context.User on tarea.UserId equals user.IdUser
            //where post.ID == id
            //select new { Tarea = tarea, Tipo_Trabajo = tipo_trabajo };
            select new {id_Tarea = tarea.IdTarea,
                        idUsuario=tarea.UserId,
                        nombreUsuario = user.NombreUser,
                        numeroSerie = tarea.NroSerie,
                        fecha = tarea.Fecha,
                        detalle = tarea.Detalle,
                        duracion = tarea.Duracion,
                        disenio = disenio.NombreDisenio,
                        elemento = elemento.NombreElemento,
                        medida = medida.NombreMedida,
                        tipoTrabajo = tipo_trabajo.NombreTipoTrabajo};

            var tareasDb = await query.ToListAsync();
            var lstTareaDTO = new List<TareaDTO>();
            
            foreach (var tareaDb in tareasDb)
            {
                lstTareaDTO.Add( new TareaDTO {
                    IdTarea = tareaDb.id_Tarea,
                    NroSerie = tareaDb.numeroSerie,
                    UserId = tareaDb.idUsuario,
                    NombreUser = tareaDb.nombreUsuario,
                    Detalle = tareaDb.detalle,
                    Duracion = tareaDb.duracion,
                    Fecha = tareaDb.fecha,
                    Tipo_Trabajo = tareaDb.tipoTrabajo,
                    Elemento = tareaDb.elemento,
                    Medida = tareaDb.medida,
                    Disenio = tareaDb.disenio
                });
            }
            
            
            if (lstTareaDTO.Count != 0)
            {
                resp = Ok(lstTareaDTO);

            }
            else
            {
                resp = NotFound("No se encuentran datos");
            }

            return resp;
            
            //Original
            //return await _context.Tarea.ToListAsync();
        }

        // GET: api/Tareas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tarea>> GetTarea(int id)
        {
            var tarea = await _context.Tarea.FindAsync(id);

            if (tarea == null)
            {
                return NotFound();
            }

            return tarea;
        }

        // PUT: api/Tareas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarea(int id, Tarea tarea)
        {
            if (id != tarea.IdTarea)
            {
                return BadRequest();
            }

            _context.Entry(tarea).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TareaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Tareas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tarea>> PostTarea(Tarea tarea)
        {
            _context.Tarea.Add(tarea);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTarea", new { id = tarea.IdTarea }, tarea);
        }

        // DELETE: api/Tareas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tarea>> DeleteTarea(int id)
        {
            var tarea = await _context.Tarea.FindAsync(id);
            if (tarea == null)
            {
                return NotFound();
            }

            _context.Tarea.Remove(tarea);
            await _context.SaveChangesAsync();

            return tarea;
        }

        private bool TareaExists(int id)
        {
            return _context.Tarea.Any(e => e.IdTarea == id);
        }
    }
}
