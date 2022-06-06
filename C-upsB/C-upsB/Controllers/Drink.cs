using System.Linq;
using System.Threading.Tasks;
using C_upsB.DataAccesLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using C_upsB.Models;
using C_upsB.ViewModels;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IActionResult> Index(int? id)
        {
            var drinks = await _dbContext.Drinks.Where(x => x.IsDeleted == false).Where(x=>x.CategoryId==id).ToListAsync();
            return View(drinks);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }

            var drink = await _dbContext.Drinks.FindAsync(id);
            if (drink==null)
            {
                return NotFound();
            }

            return View(drink);
        }
    }
}