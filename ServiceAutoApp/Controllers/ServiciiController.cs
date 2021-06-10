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
    public class ServiciiController : ControllerBase
    {
        private readonly ServiceAutoAppContext _context;

        public ServiciiController(ServiceAutoAppContext context)
        {
            _context = context;
        }

        // GET: api/Servicii
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Serviciu>>> GetServiciu()
        {
            return await _context.Serviciu.ToListAsync();
        }

        // GET: api/Servicii/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Serviciu>> GetServiciu(Guid id)
        {
            var serviciu = await _context.Serviciu.FindAsync(id);

            if (serviciu == null)
            {
                return NotFound();
            }

            return serviciu;
        }

        // PUT: api/Servicii/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServiciu(Guid id, Serviciu serviciu)
        {
            if (id != serviciu.ID)
            {
                return BadRequest();
            }

            _context.Entry(serviciu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiciuExists(id))
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

        // POST: api/Servicii
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task PostServiciu([FromBody] Serviciu serviciu)
        {
            if(serviciu.ID == Guid.Empty)
            {
                serviciu.ID = Guid.NewGuid();
            }

            _context.Serviciu.Add(serviciu);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetServiciu", new { id = serviciu.ID }, serviciu);
        }

        // DELETE: api/Servicii/5
        [HttpDelete("{id}")]
        public async Task DeleteServiciu(Guid id)
        {
            Serviciu serviciu = await _context.Serviciu.FindAsync(id);
            if (serviciu != null)
            {
                _context.Serviciu.Remove(serviciu);
                await _context.SaveChangesAsync();

            }

        }

        private bool ServiciuExists(Guid id)
        {
            return _context.Serviciu.Any(e => e.ID == id);
        }
    }
}
