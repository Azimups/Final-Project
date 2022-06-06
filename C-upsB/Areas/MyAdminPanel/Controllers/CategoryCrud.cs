using System.IO;
using System.Linq;
using System.Threading.Tasks;
using C_upsB.Areas.MyAdminPanel.Data;
using C_upsB.DataAccesLayer;
using C_upsB.Models;
using Microsoft.AspNetCore.Mvc;

namespace C_upsB.Areas.MyAdminPanel.Controllers
{
    [Area("MyAdminPanel")]
    public class CategoryCrud : Controller
    {
        private readonly AppDbContext _dbContext;

        public CategoryCrud(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var categories = _dbContext.Categories.Where(x=>x.IsDeleted==false).ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!category.Photo.ContentType.Contains("image"))
            {
                ModelState.AddModelError("Photos","Yuklediyiniz photo olmalidir");
                return View();
            }
            if (category.Photo.Length > 1024 * 1000)
            {
                ModelState.AddModelError("Photos","Yuklediyiniz photo 1 mbdan az olmalidir");
                return View();
            }
            var filename = await category.Photo.GenerateFile(Constants.ImageFolderPath,"images");
            category.Image = filename;
            await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var category = await _dbContext.Categories.FindAsync(id);
            if (category==null)
            {
                return NotFound();
            }
            return View(category);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = await _dbContext.Categories.FindAsync(id);
            if (category==null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCategory(int?id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var category = await _dbContext.Categories.FindAsync(id);
            if (category==null)
            {
                return NotFound();
            }
            var path = Path.Combine(Constants.ImageFolderPath, category.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            category.IsDeleted = true;
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            
            var category = await _dbContext.Categories.FindAsync(id);
            if (category==null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Category category)
        {
            var existCategory = await _dbContext.Categories.FindAsync(id);
            if (existCategory==null)
            {
                return NotFound();
            }
            if (!category.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Yuklediyiniz shekil olmalidir.");
                return View(existCategory);
            }

            if (!category.Photo.IsAllowedSize(1))
            {
                ModelState.AddModelError("Photo", "1 mb-dan az olmalidir.");
                return View(existCategory);
            }

            var path = Path.Combine(Constants.ImageFolderPath, existCategory.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            var filename = await category.Photo.GenerateFile(Constants.ImageFolderPath,"images");
            existCategory.Name = category.Name;
            existCategory.Image = filename;
            
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}