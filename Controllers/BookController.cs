using System.Threading.Tasks;
using TokenAuthantication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace TokenAuthantication.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BookController: ControllerBase
    {
        private readonly TokenAuthenticationContext _context;
        public BookController(TokenAuthenticationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var data = await _context.TblBooks.ToListAsync();
            return Ok(data);
        }
    }
}