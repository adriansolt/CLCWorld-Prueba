using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TelephoneAPI.Models;

namespace TelephoneAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelephoneController : ControllerBase
    {
        private readonly TelephoneContext _context;

        public TelephoneController(TelephoneContext context)
        {
            _context = context;
        }

        // GET: api/Telephone
        [HttpGet]
        public IEnumerable<Telephone> GetTelephones()
        {
            return _context.Telephones;
        }

        // GET: api/Telephone/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTelephone([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var telephone = await _context.Telephones.FindAsync(id);

            if (telephone == null)
            {
                return NotFound();
            }

            return Ok(telephone);
        }

        // PUT: api/Telephone/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTelephone([FromRoute] int id, [FromBody] Telephone telephone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != telephone.id)
            {
                return BadRequest();
            }

            _context.Entry(telephone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TelephoneExists(id))
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

        // POST: api/Telephone
        [HttpPost]
        public async Task<IActionResult> PostTelephone([FromBody] Telephone telephone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Telephones.Add(telephone);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTelephone", new { id = telephone.id }, telephone);
        }

        // DELETE: api/Telephone/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTelephone([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var telephone = await _context.Telephones.FindAsync(id);
            if (telephone == null)
            {
                return NotFound();
            }

            _context.Telephones.Remove(telephone);
            await _context.SaveChangesAsync();

            return Ok(telephone);
        }

        private bool TelephoneExists(int id)
        {
            return _context.Telephones.Any(e => e.id == id);
        }
    }
}