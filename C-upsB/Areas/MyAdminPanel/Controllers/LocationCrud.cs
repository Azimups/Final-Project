using System.Linq;
using System.Threading.Tasks;
using C_upsB.DataAccesLayer;
using C_upsB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace C_upsB.Areas.MyAdminPanel.Controllers
{
    [Area("MyAdminPanel")]
    public class LocationCrud : Controller
    {
        private readonly AppDbContext _dbContext;

        public LocationCrud(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var locations = await _dbContext.Locations.Where(x => x.IsDeleted == false).ToListAsync();
            return View(locations);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Location location)
        {
            await _dbContext.Locations.AddAsync(location);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var location = await _dbContext.Locations.FindAsync(id);
            if (location==null)
            {
                return NotFound();
            }
            return View(location);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var location = await _dbContext.Locations.FindAsync(id);
            if (location==null)
            {
                return NotFound();
            }
            return View(location);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteLocation(int?id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var location = await _dbContext.Locations.FindAsync(id);
            if (location==null)
            {
                return NotFound();
            }
            location.IsDeleted = true;
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
           
            var location = await _dbContext.Locations.FindAsync(id);
            if (location==null)
            {
                return NotFound();
            }
            return View(location);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Location location)
        {
            if (id==null)
            {
                return NotFound();
            }
            var existLocation = await _dbContext.Locations.FindAsync(id);
            if (existLocation==null)
            {
                return NotFound();
            }
            existLocation.LocationName = location.LocationName;
            existLocation.LocationAddress = location.LocationAddress;
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}