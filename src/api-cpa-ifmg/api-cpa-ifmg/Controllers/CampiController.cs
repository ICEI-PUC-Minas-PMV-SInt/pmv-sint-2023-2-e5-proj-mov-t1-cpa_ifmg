using api_cpa_ifmg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_cpa_ifmg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampiController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CampiController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var model = await _context.Campi.ToListAsync();
            return Ok(model);
        }
        [HttpPost]
        public async Task<ActionResult> Create(Campus model)
        {
            _context.Campi.Add(model);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetById", new { id = model.Id }, model);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var model = await _context.Campi
                 .FirstOrDefaultAsync(c => c.Id == id);
            if (model == null) return NotFound();
            return Ok(model);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Campus model)
        {
            if (id != model.Id) return BadRequest();
            var modelDb = await _context.Campi.AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);

            if (modelDb == null) return NotFound();

            _context.Campi.Update(model);
            await _context.SaveChangesAsync();

            return NoContent();

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var model = await _context.Campi.FindAsync(id);
            if (model == null) return NotFound();

            _context.Campi.Remove(model);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
