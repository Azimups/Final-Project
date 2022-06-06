using System.IO;
using System.Linq;
using System.Threading.Tasks;
using C_upsB.Areas.MyAdminPanel.Data;
using C_upsB.DataAccesLayer;
using C_upsB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace C_upsB.Areas.MyAdminPanel.Controllers
{
    [Area("MyAdminPanel")]
    public class MerchCrud : Controller
    {
        private readonly AppDbContext _dbContext;

        public MerchCrud(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var merchs = await _dbContext.Merchandises.Where(x => x.IsDeleted == false).ToListAsync();
            return View(merchs);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Merchandise merchandise)
        {
            if (!merchandise.Photo.ContentType.Contains("image"))
            {
                ModelState.AddModelError("Photos","Yuklediyiniz photo olmalidir");
                return View();
            }
            if (merchandise.Photo.Length > 1024 * 1000)
            {
                ModelState.AddModelError("Photos","Yuklediyiniz photo 1 mbdan az olmalidir");
                return View();
            }
            var filename = await merchandise.Photo.GenerateFile(Constants.ImageFolderPath,"images");
            merchandise.Image = filename;
            await _dbContext.Merchandises.AddAsync(merchandise);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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
            return View(merch);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var merch = await _dbContext.Merchandises.FindAsync(id);
            if (merch==null)
            {
                return NotFound();
            }
            return View(merch);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteMerch(int?id)
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
            var path = Path.Combine(Constants.ImageFolderPath, merch.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            merch.IsDeleted = true;
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
         public async Task<IActionResult> Update(int? id)
        {
            
            var merch = await _dbContext.Merchandises.FindAsync(id);
            if (merch==null)
            {
                return NotFound();
            }
            return View(merch);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Merchandise merch)
        {
            var existMerch = await _dbContext.Merchandises.FindAsync(id);
            if (existMerch==null)
            {
                return NotFound();
            }
            if (!merch.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Yuklediyiniz shekil olmalidir.");
                return View(existMerch);
            }

            if (!merch.Photo.IsAllowedSize(1))
            {
                ModelState.AddModelError("Photo", "1 mb-dan az olmalidir.");
                return View(existMerch);
            }
            var path = Path.Combine(Constants.ImageFolderPath, existMerch.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            var filename = await merch.Photo.GenerateFile(Constants.ImageFolderPath,"images");
            existMerch.Name = merch.Name;
            existMerch.Image = filename;
            existMerch.Price = merch.Price;
            existMerch.Description = merch.Description;
            existMerch.Description = merch.Description;
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}