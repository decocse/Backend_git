using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapp.DB.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanCardMastersController : ControllerBase
    {
        private readonly WEBAPPDBCONTEXT _context;

        public LoanCardMastersController(WEBAPPDBCONTEXT context)
        {
            _context = context;
        }

        // GET: api/LoanCardMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoanCardMaster>>> GetLoanCardMaster()
        {
          if (_context.LoanCardMaster == null)
          {
              return NotFound();
          }
            return await _context.LoanCardMaster.ToListAsync();
        }

        // GET: api/LoanCardMasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoanCardMaster>> GetLoanCardMaster(int id)
        {
          if (_context.LoanCardMaster == null)
          {
              return NotFound();
          }
            var loanCardMaster = await _context.LoanCardMaster.FindAsync(id);

            if (loanCardMaster == null)
            {
                return NotFound();
            }

            return loanCardMaster;
        }

        // PUT: api/LoanCardMasters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoanCardMaster(int id, LoanCardMaster loanCardMaster)
        {
            if (id != loanCardMaster.LoanId)
            {
                return BadRequest();
            }

            _context.Entry(loanCardMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoanCardMasterExists(id))
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

        // POST: api/LoanCardMasters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LoanCardMaster>> PostLoanCardMaster(LoanCardMaster loanCardMaster)
        {
          if (_context.LoanCardMaster == null)
          {
              return Problem("Entity set 'WEBAPPDBCONTEXT.LoanCardMaster'  is null.");
          }
            _context.LoanCardMaster.Add(loanCardMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoanCardMaster", new { id = loanCardMaster.LoanId }, loanCardMaster);
        }

        // DELETE: api/LoanCardMasters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoanCardMaster(int id)
        {
            if (_context.LoanCardMaster == null)
            {
                return NotFound();
            }
            var loanCardMaster = await _context.LoanCardMaster.FindAsync(id);
            if (loanCardMaster == null)
            {
                return NotFound();
            }

            _context.LoanCardMaster.Remove(loanCardMaster);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LoanCardMasterExists(int id)
        {
            return (_context.LoanCardMaster?.Any(e => e.LoanId == id)).GetValueOrDefault();
        }
    }
}
