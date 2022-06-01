using System.Threading.Tasks;
using C_upsB.DataAccesLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;

namespace C_upsB.Controllers
{
    public class Drink:Controller
    {
        private readonly ILogger<Drink> _logger;
        private readonly AppDbContext _dbContext;

        public Drink(ILogger<Drink> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}