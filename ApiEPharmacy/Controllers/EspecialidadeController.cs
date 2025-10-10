using ApiEPharmacy.Data;
using ApiEPharmacy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiEPharmacy.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class EspecialidadeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EspecialidadeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Especialidade>>> GetAll()
        {
            return await _context.Especialidade.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Especialidade>> GetById(int id)
        {
            var especialidade = await _context.Especialidade.FindAsync(id);
            if (especialidade == null) return NotFound();
            return especialidade;
        }

        [HttpPost]
        public async Task<ActionResult<Especialidade>> Create(Especialidade especialidade)
        {
            _context.Especialidade.Add(especialidade);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = especialidade.Id }, especialidade);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Especialidade especialidade)
        {
            if (id != especialidade.Id) return BadRequest();

            _context.Entry(especialidade).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var especialidade = await _context.Especialidade.FindAsync(id);
            if (especialidade == null) return NotFound();

            _context.Especialidade.Remove(especialidade);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
