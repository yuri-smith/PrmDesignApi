using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrmDesignApi.Models;

namespace PrmDesignApi.Controllers
{
    [Produces("application/json")]
    [Route("api/dims")]
    public class DimsController : Controller
    {
        //private readonly PrmDesignContext _context;
        private PrmDesignContext _context;

        public DimsController(PrmDesignContext context)
        {
            _context = context;
        }

        // GET: api/Dims
        [HttpGet]
        public IEnumerable<Dim> GetDims()
        {
            return _context.Dims;
        }

        // GET: api/Dims/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDim([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dim = await _context.Dims.SingleOrDefaultAsync(m => m.Id == id);

            if (dim == null)
            {
                return NotFound();
            }

            return Ok(dim);
        }

        // PUT: api/Dims/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDim([FromRoute] int id, [FromBody] Dim dim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dim.Id)
            {
                return BadRequest();
            }

            _context.Entry(dim).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DimExists(id))
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

        // POST: api/Dims
        [HttpPost]
        public async Task<IActionResult> PostDim([FromBody] Dim dim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Dims.Add(dim);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDim", new { id = dim.Id }, dim);
        }

        // DELETE: api/Dims/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDim([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dim = await _context.Dims.SingleOrDefaultAsync(m => m.Id == id);
            if (dim == null)
            {
                return NotFound();
            }

            _context.Dims.Remove(dim);
            await _context.SaveChangesAsync();

            return Ok(dim);
        }

        private bool DimExists(int id)
        {
            return _context.Dims.Any(e => e.Id == id);
        }
    }
}