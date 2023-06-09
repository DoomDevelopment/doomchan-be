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
    public class BoardsController : ControllerBase
    {
        private readonly DoomContext _context;
        public BoardsController(DoomContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Board>>> GetBoards() { return await _context.Boards.ToListAsync(); }

    }
}