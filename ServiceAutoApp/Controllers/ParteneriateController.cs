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
    public class ParteneriateController : ControllerBase
    {
        private readonly ServiceAutoAppContext _context;

        public ParteneriateController(ServiceAutoAppContext context)
        {
            _context = context;
        }

        // GET: api/Parteneriate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Parteneriat>>> GetParteneriat()
        {
            return await _context.Parteneriat.ToListAsync();
        }

        // GET: api/Parteneriate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Parteneriat>> GetParteneriat(Guid id)
        {
            var parteneriat = await _context.Parteneriat.FindAsync(id);

            if (parteneriat == null)
            {
                return NotFound();
            }

            return parteneriat;
        }

        // PUT: api/Parteneriate/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParteneriat(Guid id, Parteneriat parteneriat)
        {
            if (id != parteneriat.ID)
            {
                return BadRequest();
            }

            _context.Entry(parteneriat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParteneriatExists(id))
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

        // POST: api/Parteneriate
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task PostParteneriat([FromBody] Parteneriat parteneriat)
        {
            if(parteneriat.ID == Guid.Empty)
            {
                parteneriat.ID = Guid.NewGuid();
            }

            _context.Parteneriat.Add(parteneriat);
            await _context.SaveChangesAsync();

           // return CreatedAtAction("GetParteneriat", new { id = parteneriat.ID }, parteneriat);
        }

        // DELETE: api/Parteneriate/5
        [HttpDelete("{id}")]
        public async Task DeleteParteneriat(Guid id)
        {
            Parteneriat parteneriat = await _context.Parteneriat.FindAsync(id);
            if (parteneriat != null)
            {
                _context.Parteneriat.Remove(parteneriat);
                await _context.SaveChangesAsync();
            }
        }

        private bool ParteneriatExists(Guid id)
        {
            return _context.Parteneriat.Any(e => e.ID == id);
        }
    }
}
