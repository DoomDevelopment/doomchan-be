using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResponsesController : ControllerBase
    {
        public DoomContext _context { get; }
        public ResponsesController(DoomContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Response>>> GetPosts(int id)
        {
            return await _context.Responses.Where(f => f.Fiber.ID == id).ToListAsync();
        }
    }
}