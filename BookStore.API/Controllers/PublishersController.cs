﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStore.API.Models;
using Microsoft.AspNetCore.Authorization;
using BookStore.Models;

namespace BookStore.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly BookStoresDbContext _context;

        public PublishersController(BookStoresDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Publisher>>> GetPublishers()
        {
            return await _context.Publishers.ToListAsync();
        }

        [HttpGet("details/{id}")]
        public async Task<ActionResult<Publisher>> GetPublisherDetails(int id)
        {
            // var publisher = await _context.Publishers
            //     .Include(p => p.Books)
            //         .ThenInclude(b => b.Sales)
            //     .Include(p => p.Users)
            //         .ThenInclude(u => u.Job)
            //     .FirstOrDefaultAsync(p => p.PubId == id);

            var publisher = await _context.Publishers.SingleAsync(p => p.PubId == id);

            _context.Entry(publisher)
                .Collection(p => p.Users)
                .Query()
                .Where(u => u.EmailAddress.Contains("Karin"))
                .Load();

            _context.Entry(publisher)
                .Collection(p => p.Books)
                .Query()
                .Include(b => b.Sales)
                .Load();

            // var user = await _context.Users.SingleAsync(u => u.UserId == "paolo.accorti");

            // _context.Entry(user).Reference(u => u.Role)

            if (publisher == null)
            {
                return NotFound();
            }

            return publisher;
        }

        [HttpPost("post/details")]
        public async Task<ActionResult<Publisher>> PostPublisherDetails(Publisher publisher)
        {
            // var publisher = new Publisher();
            // publisher.PublisherName = "Harper & Brothers";
            // publisher.City = "New York City";
            // publisher.State = "NY";
            // publisher.Country = "USA";

            // Book book1 = new Book();
            // book1.Title = "Good night moon - 1";
            // book1.PublishedDate = DateTime.Now;

            // Book book2 = new Book();
            // book2.Title = "Good night moon - 2";
            // book2.PublishedDate = DateTime.Now;

            // Sale sale1 = new Sale();
            // sale1.Quantity = 2;
            // sale1.StoreId = "8042";
            // sale1.OrderNum = "XYZ";
            // sale1.PayTerms = "Net 30";
            // sale1.OrderDate = DateTime.Now;

            // Sale sale2 = new Sale();
            // sale2.Quantity = 2;
            // sale2.StoreId = "7131";
            // sale2.OrderNum = "QA879.1";
            // sale2.PayTerms = "Net 20";
            // sale2.OrderDate = DateTime.Now;

            // book1.Sales.Add(sale1);
            // book2.Sales.Add(sale2);

            // publisher.Books.Add(book1);
            // publisher.Books.Add(book2);

            _context.Publishers.Add(publisher);
            _context.SaveChanges();

            var foundPublisher = await _context.Publishers
                .Include(p => p.Books)
                    .ThenInclude(b => b.Sales)
                .Include(p => p.Users)
                    .ThenInclude(u => u.Job)
                .FirstOrDefaultAsync(p => p.PubId == publisher.PubId);

            if (foundPublisher == null)
            {
                return NotFound();
            }

            return foundPublisher;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Publisher>> GetPublisher(int id)
        {
            var publisher = await _context.Publishers.FindAsync(id);

            if (publisher == null)
            {
                return NotFound();
            }

            return publisher;
        }

        // PUT: api/Publishers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPublisher(int id, Publisher publisher)
        {
            if (id != publisher.PubId)
            {
                return BadRequest();
            }

            _context.Entry(publisher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PublisherExists(id))
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

        // POST: api/Publishers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Publisher>> PostPublisher(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPublisher", new { id = publisher.PubId }, publisher);
        }

        // DELETE: api/Publishers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Publisher>> DeletePublisher(int id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            if (publisher == null)
            {
                return NotFound();
            }

            _context.Publishers.Remove(publisher);
            await _context.SaveChangesAsync();

            return publisher;
        }

        private bool PublisherExists(int id)
        {
            return _context.Publishers.Any(e => e.PubId == id);
        }
    }
}
