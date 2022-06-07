using System.Linq;
using System.Threading.Tasks;
using C_upsB.DataAccesLayer;
using C_upsB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace C_upsB.Controllers
{
    public class AboutController:Controller
    {
        private readonly ILogger<AboutController> _logger;
        private readonly AppDbContext _dbContext;

        public AboutController(ILogger<AboutController> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var aboutdetail = await _dbContext.AboutDetails.SingleOrDefaultAsync();
            return View(new HomeViewModel
            {
                AboutDetails = aboutdetail,
            });
        }
        
    }
}