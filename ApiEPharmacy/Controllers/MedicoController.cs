using ApiEPharmacy.Data;
using ApiEPharmacy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiEPharmacy.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class MedicoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MedicoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medico>>> GetAll()
        {
            return await _context.Medico.Include(m => m.Especialidade).ToListAsync(); // Assim ele Inclui a Classse Especialidade relacionada, 
         // return await _context.Medico.ToListAsync(); // Assim Sem isso o campo daclasse vem Null no json 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Medico>> GetById(int id)
        {
            var medico = await _context.Medico.Include(m => m.Especialidade).FirstOrDefaultAsync(m => m.Id == id);
            if (medico == null) return NotFound();
            return medico;
        }

        [HttpPost]
        public async Task<ActionResult<Medico>> Create(Medico medico)
        {
            _context.Medico.Add(medico);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = medico.Id }, medico);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Medico medico)
        {
            if (id != medico.Id) return BadRequest();

            _context.Entry(medico).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var medico = await _context.Medico.FindAsync(id);
            if (medico == null) return NotFound();

            _context.Medico.Remove(medico);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

