using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiTareasManuales.Models;

namespace ApiTareasManuales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoTrabajoController : ControllerBase
    {
        private readonly MyDbContext _context;

        public TipoTrabajoController(MyDbContext context)
        {
            _context = context;
        }




        // GET: api/Tipo_Trabajo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tipo_Trabajo>>> GetTipo_Trabajo()
        {
            return await _context.Tipo_Trabajo.ToListAsync();
        }




        // GET: api/Tipo_Trabajo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tipo_Trabajo>> GetTipo_Trabajo(int id)
        {
            var tipo_Trabajo = await _context.Tipo_Trabajo.FindAsync(id);

            if (tipo_Trabajo == null)
            {
                return NotFound();
            }

            return tipo_Trabajo;
        }




        // PUT: api/Tipo_Trabajo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipo_Trabajo(int id, Tipo_Trabajo tipo_Trabajo)
        {
            if (id != tipo_Trabajo.IdTipoTrabajo)
            {
                return BadRequest();
            }

            _context.Entry(tipo_Trabajo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tipo_TrabajoExists(id))
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




        // POST: api/Tipo_Trabajo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tipo_Trabajo>> PostTipo_Trabajo(Tipo_Trabajo tipo_Trabajo)
        {
            _context.Tipo_Trabajo.Add(tipo_Trabajo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipo_Trabajo", new { id = tipo_Trabajo.IdTipoTrabajo }, tipo_Trabajo);
        }




        // DELETE: api/Tipo_Trabajo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipo_Trabajo(int id)
        {
            var tipo_Trabajo = await _context.Tipo_Trabajo.FindAsync(id);
            if (tipo_Trabajo == null)
            {
                return NotFound();
            }

            _context.Tipo_Trabajo.Remove(tipo_Trabajo);
            await _context.SaveChangesAsync();

            return NoContent();
        }



        #region Funciones
        private bool Tipo_TrabajoExists(int id)
        {
            return _context.Tipo_Trabajo.Any(e => e.IdTipoTrabajo == id);
        }
        #endregion
    }
}
