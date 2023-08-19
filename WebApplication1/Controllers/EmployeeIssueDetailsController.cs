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
    public class EmployeeIssueDetailsController : ControllerBase
    {
        private readonly WEBAPPDBCONTEXT _context;

        public EmployeeIssueDetailsController(WEBAPPDBCONTEXT context)
        {
            _context = context;
        }

        // GET: api/EmployeeIssueDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeIssueDetails>>> GetemployeeIssueDetails()
        {
          if (_context.employeeIssueDetails == null)
          {
              return NotFound();
          }
            return await _context.employeeIssueDetails.ToListAsync();
        }

        // GET: api/EmployeeIssueDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeIssueDetails>> GetEmployeeIssueDetails(int id)
        {
          if (_context.employeeIssueDetails == null)
          {
              return NotFound();
          }
            var employeeIssueDetails = await _context.employeeIssueDetails.FindAsync(id);

            if (employeeIssueDetails == null)
            {
                return NotFound();
            }

            return employeeIssueDetails;
        }

        // PUT: api/EmployeeIssueDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeIssueDetails(int id, EmployeeIssueDetails employeeIssueDetails)
        {
            if (id != employeeIssueDetails.IssueId)
            {
                return BadRequest();
            }

            _context.Entry(employeeIssueDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeIssueDetailsExists(id))
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

        // POST: api/EmployeeIssueDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmployeeIssueDetails>> PostEmployeeIssueDetails(EmployeeIssueDetails employeeIssueDetails)
        {
          if (_context.employeeIssueDetails == null)
          {
              return Problem("Entity set 'WEBAPPDBCONTEXT.employeeIssueDetails'  is null.");
          }
            _context.employeeIssueDetails.Add(employeeIssueDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployeeIssueDetails", new { id = employeeIssueDetails.IssueId }, employeeIssueDetails);
        }

        // DELETE: api/EmployeeIssueDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeIssueDetails(int id)
        {
            if (_context.employeeIssueDetails == null)
            {
                return NotFound();
            }
            var employeeIssueDetails = await _context.employeeIssueDetails.FindAsync(id);
            if (employeeIssueDetails == null)
            {
                return NotFound();
            }

            _context.employeeIssueDetails.Remove(employeeIssueDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeIssueDetailsExists(int id)
        {
            return (_context.employeeIssueDetails?.Any(e => e.IssueId == id)).GetValueOrDefault();
        }
    }
}
