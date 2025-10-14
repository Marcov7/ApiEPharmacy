using ApiEPharmacy.Data;
using ApiEPharmacy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiEPharmacy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClinicaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clinica>>> GetAll()
        {
            return await _context.Clinica.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Clinica>> GetById(int id)
        {
            var entlidade = await _context.Clinica.FindAsync(id);
            if (entlidade == null) return NotFound();
            return entlidade;
        }

        [HttpPost]
        public async Task<ActionResult<Clinica>> Create(Clinica entlidade)
        {
            _context.Clinica.Add(entlidade);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = entlidade.Id }, entlidade);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Clinica entlidade)
        {
            if (id != entlidade.Id) return BadRequest();

            _context.Entry(entlidade).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entlidade = await _context.Clinica.FindAsync(id);
            if (entlidade == null) return NotFound();

            _context.Clinica.Remove(entlidade);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

