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
    public class FabricanteController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FabricanteController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fabricante>>> GetAll()
        {
            return await _context.Fabricante.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Fabricante>> GetById(int id)
        {
            var entlidade = await _context.Fabricante.FindAsync(id);
            if (entlidade == null) return NotFound();
            return entlidade;
        }

        [HttpPost]
        public async Task<ActionResult<Fabricante>> Create(Fabricante entlidade)
        {
            _context.Fabricante.Add(entlidade);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = entlidade.Id }, entlidade);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Fabricante entlidade)
        {
            if (id != entlidade.Id) return BadRequest();

            _context.Entry(entlidade).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entlidade = await _context.Fabricante.FindAsync(id);
            if (entlidade == null) return NotFound();

            _context.Fabricante.Remove(entlidade);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

