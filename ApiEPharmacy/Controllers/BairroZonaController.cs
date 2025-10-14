using ApiEPharmacy.Data;
using ApiEPharmacy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiEPharmacy.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BairroZonaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BairroZonaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BairroZona>>> GetAll()
        {
            return await _context.BairroZona.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BairroZona>> GetById(int id)
        {
            var bairroZona = await _context.BairroZona.FindAsync(id);
            if (bairroZona == null) return NotFound();
            return bairroZona;
        }

        [HttpPost]
        public async Task<ActionResult<BairroZona>> Create(BairroZona bairroZona)
        {
            _context.BairroZona.Add(bairroZona);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = bairroZona.Id }, bairroZona);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, BairroZona bairroZona)
        {
            if (id != bairroZona.Id) return BadRequest();

            _context.Entry(bairroZona).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var bairroZona = await _context.BairroZona.FindAsync(id);
            if (bairroZona == null) return NotFound();

            _context.BairroZona.Remove(bairroZona);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

