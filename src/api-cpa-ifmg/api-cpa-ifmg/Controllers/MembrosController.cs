﻿using api_cpa_ifmg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_cpa_ifmg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembrosController : ControllerBase
    {
        private readonly AppDbContext _context;
        public MembrosController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var model = await _context.Membros.ToListAsync();
            return Ok(model);
        }
        [HttpPost]
        public async Task<ActionResult> Create(Membro model)
        {
            _context.Membros.Add(model);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetById", new { id = model.Id }, model);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var model = await _context.Membros
                 
                 .FirstOrDefaultAsync(c => c.Id == id);
            if (model == null) return NotFound();
            return Ok(model);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Membro model)
        {
            if (id != model.Id) return BadRequest();
            var modelDb = await _context.Membros.AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);

            if (modelDb == null) return NotFound();

            _context.Membros.Update(model);
            await _context.SaveChangesAsync();

            return NoContent();

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var model = await _context.Membros.FindAsync(id);
            if (model == null) return NotFound();

            _context.Membros.Remove(model);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
