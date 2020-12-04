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
    public class HerramientaReparacionController : ControllerBase
    {
        private readonly MyDbContext _context;

        public HerramientaReparacionController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Herramienta_Reparacion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Herramienta_Reparacion>>> GetHerramienta_Reparacion()
        {
            return await _context.Herramienta_Reparacion.ToListAsync();
        }

        // GET: api/Herramienta_Reparacion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Herramienta_Reparacion>> GetHerramienta_Reparacion(int id)
        {
            var herramienta_Reparacion = await _context.Herramienta_Reparacion.FindAsync(id);

            if (herramienta_Reparacion == null)
            {
                return NotFound();
            }

            return herramienta_Reparacion;
        }

        // PUT: api/Herramienta_Reparacion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHerramienta_Reparacion(int id, Herramienta_Reparacion herramienta_Reparacion)
        {
            if (id != herramienta_Reparacion.IdHerramienta_Reparacion)
            {
                return BadRequest();
            }

            _context.Entry(herramienta_Reparacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Herramienta_ReparacionExists(id))
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

        // POST: api/Herramienta_Reparacion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Herramienta_Reparacion>> PostHerramienta_Reparacion(Herramienta_Reparacion herramienta_Reparacion)
        {
            _context.Herramienta_Reparacion.Add(herramienta_Reparacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHerramienta_Reparacion", new { id = herramienta_Reparacion.IdHerramienta_Reparacion }, herramienta_Reparacion);
        }

        // DELETE: api/Herramienta_Reparacion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHerramienta_Reparacion(int id)
        {
            var herramienta_Reparacion = await _context.Herramienta_Reparacion.FindAsync(id);
            if (herramienta_Reparacion == null)
            {
                return NotFound();
            }

            _context.Herramienta_Reparacion.Remove(herramienta_Reparacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Herramienta_ReparacionExists(int id)
        {
            return _context.Herramienta_Reparacion.Any(e => e.IdHerramienta_Reparacion == id);
        }
    }
}
