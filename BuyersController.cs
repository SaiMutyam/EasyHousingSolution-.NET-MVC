﻿using System;
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
    public class BuyersController : ControllerBase
    {
        private readonly Ehs_DbContext _context;

        public BuyersController(Ehs_DbContext context)
        {
            _context = context;
        }

        // GET: api/Buyers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Buyer>>> GetBuyer()
        {
            return await _context.Buyer.ToListAsync();
        }

        // GET: api/Buyers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Buyer>> GetBuyer(int id)
        {
            var buyer = await _context.Buyer.FindAsync(id);

            if (buyer == null)
            {
                return NotFound();
            }

            return buyer;
        }

        // PUT: api/Buyers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBuyer(int id, Buyer buyer)
        {
            if (id != buyer.BuyerId)
            {
                return BadRequest();
            }

            _context.Entry(buyer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuyerExists(id))
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

        // POST: api/Buyers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Buyer>> PostBuyer(Buyer buyer)
        {
            _context.Buyer.Add(buyer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBuyer", new { id = buyer.BuyerId }, buyer);
        }

        // DELETE: api/Buyers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Buyer>> DeleteBuyer(int id)
        {
            var buyer = await _context.Buyer.FindAsync(id);
            if (buyer == null)
            {
                return NotFound();
            }

            _context.Buyer.Remove(buyer);
            await _context.SaveChangesAsync();

            return buyer;
        }

        private bool BuyerExists(int id)
        {
            return _context.Buyer.Any(e => e.BuyerId == id);
        }
    }
}
