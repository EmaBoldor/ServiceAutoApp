using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceAutoApp.Data;
using ServiceAutoApp.Models;

namespace ServiceAutoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasiniController : ControllerBase
    {
        private readonly ServiceAutoAppContext _context;

        public MasiniController(ServiceAutoAppContext context)
        {
            _context = context;
        }

        // GET: api/Masini
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Masina>>> GetMasina()
        {
            return await _context.Masina.ToListAsync();
        }

        // GET: api/Masini/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Masina>> GetMasina(Guid id)
        {
            var masina = await _context.Masina.FindAsync(id);

            if (masina == null)
            {
                return NotFound();
            }

            return masina;
        }

        // PUT: api/Masini/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMasina(Guid id, Masina masina)
        {
            if (id != masina.ID)
            {
                return BadRequest();
            }

            _context.Entry(masina).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MasinaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Masini
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task PostMasina([FromBody] Masina masina)
        {
            if(masina.ID == Guid.Empty)
            {
                masina.ID = Guid.NewGuid();
            }

            _context.Masina.Add(masina);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetMasina", new { id = masina.ID }, masina);
        }

        // DELETE: api/Masini/5
        [HttpDelete("{id}")]
        public async Task DeleteMasina(Guid id)
        {
            Masina masina = await _context.Masina.FindAsync(id);
            if (masina != null)
            {
                _context.Masina.Remove(masina);
                await _context.SaveChangesAsync();
            }
        }

        private bool MasinaExists(Guid id)
        {
            return _context.Masina.Any(e => e.ID == id);
        }
    }
}
