using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class DoomContext : DbContext
    {
        public DoomContext(DbContextOptions options) : base(options) { }
        public DbSet<Response> Responses { get; set; }
        public DbSet<Fiber> Fibers { get; set; }
        public DbSet<Board> Boards { get; set; }
    }
}