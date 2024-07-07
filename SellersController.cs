using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EasyhousingSolution_WebAPI.Model;

namespace EasyhousingSolution_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : ControllerBase
    {
        private readonly Ehs_DbContext _context;

        public SellersController(Ehs_DbContext context)
        {
            _context = context;
        }

        // GET: api/Sellers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seller>>> GetSeller()
        {
            return await _context.Seller.ToListAsync();
        }

        // GET: api/Sellers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Seller>> GetSeller(int id)
        {
            var seller = await _context.Seller.FindAsync(id);

            if (seller == null)
            {
                return NotFound();
            }

            return seller;
        }

        // PUT: api/Sellers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSeller(int id, Seller seller)
        {
            if (id != seller.SellerId)
            {
                return BadRequest();
            }

            _context.Entry(seller).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SellerExists(id))
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

        // POST: api/Sellers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Seller>> PostSeller(Seller seller)
        {
            _context.Seller.Add(seller);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSeller", new { id = seller.SellerId }, seller);
        }

        // DELETE: api/Sellers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Seller>> DeleteSeller(int id)
        {
            var seller = await _context.Seller.FindAsync(id);
            if (seller == null)
            {
                return NotFound();
            }

            _context.Seller.Remove(seller);
            await _context.SaveChangesAsync();

            return seller;
        }

        private bool SellerExists(int id)
        {
            return _context.Seller.Any(e => e.SellerId == id);
        }
    }
}
