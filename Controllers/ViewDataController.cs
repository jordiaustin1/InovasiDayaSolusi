using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ViewDataApi.Data;
using ViewDataApi.Models;

namespace ViewDataApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViewDataController : ControllerBase
    {
        private readonly AppDbContext _db;
        public ViewDataController(AppDbContext db) { _db = db; }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var transactions = await _db.Transactions.AsNoTracking().ToListAsync();
            var statuses = await _db.Statuses.AsNoTracking().ToListAsync();

            var resp = new ViewDataResponse
            {
                data = transactions,
                status = statuses
            };

            return Ok(resp);
        }
    }
}
