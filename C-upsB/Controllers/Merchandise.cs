using System.Linq;
using System.Threading.Tasks;
using C_upsB.DataAccesLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace C_upsB.Controllers
{
    public class Merchandise : Controller
    {
        private readonly AppDbContext _dbContext;

        public Merchandise(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var merchandises = await _dbContext.Merchandises.Where(x => x.IsDeleted == false).ToListAsync();
            return View(merchandises);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }

            var merch = await _dbContext.Merchandises.FindAsync(id);
            if (merch==null)
            {
                return NotFound();
            }

            var thumbs = await _dbContext.Thumbs.Where(x => x.MerchId == id).ToListAsync();
            ViewBag.Thumbs = thumbs;
            var merchTypes = await _dbContext.MerchandiseTypes.Where(x => x.MerchandiseId == id).ToListAsync();
            ViewBag.MerchTypes = merchTypes;
            return View(merch);
        }
    }
}