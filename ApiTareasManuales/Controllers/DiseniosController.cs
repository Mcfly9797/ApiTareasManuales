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
    [Route("[controller]")]
    [ApiController]
    public class DiseniosController : ControllerBase
    {
        private readonly MyDbContext _context;

        public DiseniosController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Disenios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Disenio>>> GetDisenio()
        {
            return await _context.Disenio.ToListAsync();
        }

        // GET: api/Disenios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Disenio>> GetDisenio(int id)
        {
            var disenio = await _context.Disenio.FindAsync(id);

            if (disenio == null)
            {
                return NotFound();
            }

            return disenio;
        }

        // PUT: api/Disenios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDisenio(int id, Disenio disenio)
        {
            if (id != disenio.IdDisenio)
            {
                return BadRequest();
            }

            _context.Entry(disenio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DisenioExists(id))
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

        // POST: api/Disenios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Disenio>> PostDisenio(Disenio disenio)
        {
            _context.Disenio.Add(disenio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDisenio", new { id = disenio.IdDisenio }, disenio);
        }

        // DELETE: api/Disenios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Disenio>> DeleteDisenio(int id)
        {
            var disenio = await _context.Disenio.FindAsync(id);
            if (disenio == null)
            {
                return NotFound();
            }

            _context.Disenio.Remove(disenio);
            await _context.SaveChangesAsync();

            return disenio;
        }

        private bool DisenioExists(int id)
        {
            return _context.Disenio.Any(e => e.IdDisenio == id);
        }
    }
}
