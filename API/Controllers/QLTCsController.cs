using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QLTCsController : ControllerBase
    {
        private readonly DataContext _context;
        public QLTCsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppQLTC>>> GetQLTCs()
        {
            return await _context.QLTC.ToListAsync();
        }

        // api/users/2
        [HttpGet("{id}")]
        public async Task<ActionResult<AppQLTC>> GetQLTC(int id)
        {
            return await _context.QLTC.FindAsync(id);
        }
    }
}