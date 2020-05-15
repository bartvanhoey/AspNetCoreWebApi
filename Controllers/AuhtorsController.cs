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
        private readonly BookStoresDBContext _context;

        public AuthorsController(BookStoresDBContext context){
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Author> Get()
        {
            return _context.Author.ToList();
        }
    }
}
