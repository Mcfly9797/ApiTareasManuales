using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiTareasManuales.Models;
using ApiTareasManuales.DTOs;

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
        public async Task<ActionResult<IEnumerable<TareaDTO>>> GetTarea()
        {

            //Traigo la lista de todas las tareas realizadas en una lista asincrona
            var lstTareaBd = await (from tarea in _context.Tarea select tarea).ToListAsync();

            var lstTareaDTO = new List<TareaDTO>();
            foreach (var tareaBD in lstTareaBd)
                lstTareaDTO.Add(ModelToDTO(tareaBD));

            if (lstTareaDTO.Count != 0)
                return Ok(lstTareaDTO);
            else
                return NotFound("No se encuentran datos");

        }




        // GET: api/Tareas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TareaDTO>> GetTarea(int id)
        {
            var tareaDTO = ModelToDTO(await _context.Tarea.FindAsync(id));

            if (tareaDTO == null)
                return NotFound();

            return tareaDTO;
        }




        // PUT: api/Tareas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarea(int id, TareaDTO tareaDTO)
        {
            if (id != tareaDTO.IdTarea)
                return BadRequest();

            _context.Entry(DTOToModel(tareaDTO)).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TareaExists(id))
                    return NotFound();
                else
                    throw;
            }

            return Ok("Elemento modificado correctamente");
        }




        // POST: api/Tareas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TareaDTO>> PostTarea(TareaDTO tareaDTO)
        {
            _context.Tarea.Attach(DTOToModel(tareaDTO));
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTarea", new { id = tareaDTO.IdTarea }, tareaDTO);
        }




        // DELETE: api/Tareas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTarea(int id)
        {
            var tarea = await _context.Tarea.FindAsync(id);
            if (tarea == null)
                return NotFound();

            _context.Tarea.Remove(tarea);
            await _context.SaveChangesAsync();

            return Ok("Elemento eliminado correctamente");
        }


        #region Funciones
        private bool TareaExists(int id)
        {
            return _context.Tarea.Any(e => e.IdTarea == id);
        }




        private TareaDTO ModelToDTO(Tarea tareaModel) =>
            new TareaDTO
            {
                NroSerie = tareaModel.NroSerie,
                UserId = tareaModel.UserId,
                NombreUser = tareaModel.Usuario.NombreUser,
                Detalle = tareaModel.Detalle,
                Duracion = tareaModel.Duracion,
                Fecha = tareaModel.Fecha,
                Tipo_TrabajoId = tareaModel.Tipo_TrabajoId,
                Tipo_Trabajo = tareaModel.Tipo_Trabajo.NombreTipoTrabajo,
                ElementoId = tareaModel.Elemento.IdElemento,
                Elemento = tareaModel.Elemento.NombreElemento,
                MedidaId = tareaModel.Medida.IdMedida,
                Medida = tareaModel.Medida.NombreMedida,
                DisenioId = tareaModel.Disenio.IdDisenio,
                Disenio = tareaModel.Disenio.NombreDisenio,
            };




        private Tarea DTOToModel(TareaDTO tareaDTO) =>
            new Tarea
            {
                NroSerie = tareaDTO.NroSerie,
                UserId = tareaDTO.UserId,
                Detalle = tareaDTO.Detalle,
                Duracion = tareaDTO.Duracion,
                Fecha = tareaDTO.Fecha,
                Tipo_TrabajoId = tareaDTO.Tipo_TrabajoId,
                ElementoId = tareaDTO.ElementoId,
                MedidaId = tareaDTO.MedidaId,
                DisenioId = tareaDTO.DisenioId,
            };
        #endregion
    }
}
