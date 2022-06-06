using System.Linq;
using System.Threading.Tasks;
using C_upsB.DataAccesLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace C_upsB.Controllers
{
    public class Location:Controller
    {
        private readonly ILogger<Location> _logger;
        private readonly AppDbContext _dbContext;

        public Location(ILogger<Location> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var locations = await _dbContext.Locations.Where(x => x.IsDeleted == false).ToListAsync();
            return View(locations);
        }
    }
}