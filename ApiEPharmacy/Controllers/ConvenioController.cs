using ApiEPharmacy.Data;
using ApiEPharmacy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiEPharmacy.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ConvenioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ConvenioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Convenio>>> GetAll()
        {
            return await _context.Convenio.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Convenio>> GetById(int id)
        {
            var entlidade = await _context.Convenio.FindAsync(id);
            if (entlidade == null) return NotFound();
            return entlidade;
        }

        [HttpPost]
        public async Task<ActionResult<Convenio>> Create(Convenio entlidade)
        {
            _context.Convenio.Add(entlidade);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = entlidade.Id }, entlidade);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Convenio entlidade)
        {
            if (id != entlidade.Id) return BadRequest();

            _context.Entry(entlidade).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entlidade = await _context.Convenio.FindAsync(id);
            if (entlidade == null) return NotFound();

            _context.Convenio.Remove(entlidade);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

