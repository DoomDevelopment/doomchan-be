using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FibersController : ControllerBase
    {
        public DoomContext _context { get; }
        public FibersController(DoomContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Fiber>>> GetFibers(int id)
        {
            return await _context.Fibers.Where(f => f.Board.ID == id).ToListAsync();
        }
    }
}