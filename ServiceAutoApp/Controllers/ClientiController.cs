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
    public class ClientiController : ControllerBase
    {
        private readonly ServiceAutoAppContext _context;

        public ClientiController(ServiceAutoAppContext context)
        {
            _context = context;
        }

        // GET: api/Clienti
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetClient()
        {
            return await _context.Client.ToListAsync();
        }

        // GET: api/Clienti/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClient(Guid id)
        {
            var client = await _context.Client.FindAsync(id);

            if (client == null)
            {
                return NotFound();
            }

            return client;
        }

        // PUT: api/Clienti/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClient(Guid id, Client client)
        {
            if (id != client.ID)
            {
                return BadRequest();
            }

            _context.Entry(client).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(id))
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

        // POST: api/Clienti
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task PostClient([FromBody]Client client)
        {
            if (client.ID == Guid.Empty)
            {
                client.ID = Guid.NewGuid();
            }

            _context.Client.Add(client);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetClient", new { id = client.ID }, client);
        }

        // DELETE: api/Clienti/5
        [HttpDelete("{id}")]
        public async Task DeleteClient(Guid id)
        {
            Client client = await _context.Client.FindAsync(id);
            if (client != null)
            {
                _context.Client.Remove(client);
                await _context.SaveChangesAsync();
            }

        }

        private bool ClientExists(Guid id)
        {
            return _context.Client.Any(e => e.ID == id);
        }
    }
}
