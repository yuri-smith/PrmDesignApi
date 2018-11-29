using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrmDesignApi.Models;
using PrmDesignApi.Models.CRM;

namespace PrmDesignApi.Controllers
{
    [Produces("application/json")]
    [Route("api/CompanyProfiles")]
    public class CompanyProfilesController : Controller
    {
        private readonly PrmDesignContext _context;

        public CompanyProfilesController(PrmDesignContext context)
        {
            _context = context;
        }

        // GET: api/CompanyProfiles
        [HttpGet]
        public IEnumerable<CompanyProfile> GetCompanyProfiles()
        {
            return _context.CompanyProfiles;
        }

        // GET: api/CompanyProfiles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompanyProfile([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var companyProfile = await _context.CompanyProfiles
                .Include(cp => cp.LegalAddress).ThenInclude(la => la.City)
                .Include(cp => cp.ActualAddress).ThenInclude(aa => aa.City)
                .SingleOrDefaultAsync(m => m.CompanyId == id);

            if (companyProfile == null)
            {
                return NotFound();
            }

            return Ok(companyProfile);
        }

        // PUT: api/CompanyProfiles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompanyProfile([FromRoute] int id, [FromBody] CompanyProfile companyProfile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != companyProfile.Id)
            {
                return BadRequest();
            }

            _context.Entry(companyProfile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyProfileExists(id))
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

        // POST: api/CompanyProfiles
        [HttpPost]
        public async Task<IActionResult> PostCompanyProfile([FromBody] CompanyProfile companyProfile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CompanyProfiles.Add(companyProfile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompanyProfile", new { id = companyProfile.Id }, companyProfile);
        }

        // DELETE: api/CompanyProfiles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanyProfile([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var companyProfile = await _context.CompanyProfiles.SingleOrDefaultAsync(m => m.Id == id);
            if (companyProfile == null)
            {
                return NotFound();
            }

            _context.CompanyProfiles.Remove(companyProfile);
            await _context.SaveChangesAsync();

            return Ok(companyProfile);
        }

        private bool CompanyProfileExists(int id)
        {
            return _context.CompanyProfiles.Any(e => e.Id == id);
        }
    }
}