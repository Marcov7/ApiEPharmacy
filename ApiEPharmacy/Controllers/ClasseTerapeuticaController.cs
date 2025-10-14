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
    public class ClasseTerapeuticaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClasseTerapeuticaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClasseTerapeutica>>> GetAll()
        {
            return await _context.ClasseTerapeutica.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClasseTerapeutica>> GetById(int id)
        {
            var entlidade = await _context.ClasseTerapeutica.FindAsync(id);
            if (entlidade == null) return NotFound();
            return entlidade;
        }

        [HttpPost]
        public async Task<ActionResult<ClasseTerapeutica>> Create(ClasseTerapeutica entlidade)
        {
            _context.ClasseTerapeutica.Add(entlidade);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = entlidade.Id }, entlidade);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ClasseTerapeutica entlidade)
        {
            if (id != entlidade.Id) return BadRequest();

            _context.Entry(entlidade).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entlidade = await _context.ClasseTerapeutica.FindAsync(id);
            if (entlidade == null) return NotFound();

            _context.ClasseTerapeutica.Remove(entlidade);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
