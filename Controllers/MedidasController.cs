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
    public class MedidasController : ControllerBase
    {
        private readonly MyDbContext _context;

        public MedidasController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Medidas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medida>>> GetMedida()
        {
            return await _context.Medida.ToListAsync();
        }

        // GET: api/Medidas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Medida>> GetMedida(int id)
        {
            var medida = await _context.Medida.FindAsync(id);

            if (medida == null)
            {
                return NotFound();
            }

            return medida;
        }

        // PUT: api/Medidas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedida(int id, Medida medida)
        {
            if (id != medida.IdMedida)
            {
                return BadRequest();
            }

            _context.Entry(medida).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedidaExists(id))
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

        // POST: api/Medidas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Medida>> PostMedida(Medida medida)
        {
            _context.Medida.Add(medida);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedida", new { id = medida.IdMedida }, medida);
        }

        // DELETE: api/Medidas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedida(int id)
        {
            var medida = await _context.Medida.FindAsync(id);
            if (medida == null)
            {
                return NotFound();
            }

            _context.Medida.Remove(medida);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MedidaExists(int id)
        {
            return _context.Medida.Any(e => e.IdMedida == id);
        }
    }
}
