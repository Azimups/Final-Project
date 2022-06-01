using System.Threading.Tasks;
using C_upsB.DataAccesLayer;
using C_upsB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace C_upsB.Controllers
{
    public class Category:Controller
    {
        private readonly ILogger<Category> _logger;
        private readonly AppDbContext _dbContext;

        public Category(ILogger<Category> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _dbContext.Categories.ToListAsync();
            return View( new HomeViewModel
            {
                Categories = categories,
            });
        }
    }
}