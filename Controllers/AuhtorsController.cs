using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoresWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly BookStoresDbContext _context;

        public AuthorsController(BookStoresDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Author> Get()
        {
            return _context.Authors.ToList();
        }
    }
}
