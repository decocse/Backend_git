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
    public class ItemDBsController : ControllerBase
    {
        private readonly WEBAPPDBCONTEXT _context;

        public ItemDBsController(WEBAPPDBCONTEXT context)
        {
            _context = context;
        }

        // GET: api/ItemDBs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemDB>>> GetItemDB()
        {
          if (_context.ItemDB == null)
          {
              return NotFound();
          }
            return await _context.ItemDB.ToListAsync();
        }

        // GET: api/ItemDBs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemDB>> GetItemDB(int id)
        {
          if (_context.ItemDB == null)
          {
              return NotFound();
          }
            var itemDB = await _context.ItemDB.FindAsync(id);

            if (itemDB == null)
            {
                return NotFound();
            }

            return itemDB;
        }

        // PUT: api/ItemDBs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemDB(int id, ItemDB itemDB)
        {
            if (id != itemDB.ItemId)
            {
                return BadRequest();
            }

            _context.Entry(itemDB).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemDBExists(id))
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

        // POST: api/ItemDBs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemDB>> PostItemDB(ItemDB itemDB)
        {
          if (_context.ItemDB == null)
          {
              return Problem("Entity set 'WEBAPPDBCONTEXT.ItemDB'  is null.");
          }
            _context.ItemDB.Add(itemDB);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemDB", new { id = itemDB.ItemId }, itemDB);
        }

        // DELETE: api/ItemDBs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemDB(int id)
        {
            if (_context.ItemDB == null)
            {
                return NotFound();
            }
            var itemDB = await _context.ItemDB.FindAsync(id);
            if (itemDB == null)
            {
                return NotFound();
            }

            _context.ItemDB.Remove(itemDB);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemDBExists(int id)
        {
            return (_context.ItemDB?.Any(e => e.ItemId == id)).GetValueOrDefault();
        }
    }
}
