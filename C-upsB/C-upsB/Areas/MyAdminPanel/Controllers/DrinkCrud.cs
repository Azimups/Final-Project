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
    public class DrinkCrud:Controller
    {
        private readonly AppDbContext _dbContext;

        public DrinkCrud(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public  async Task<IActionResult> Index()
        {
            var drinks = await _dbContext.Drinks.Where(x => x.IsDeleted == false).ToListAsync();
            return View(drinks);
        }
        public IActionResult Create()
        {
            var categories = _dbContext.Categories.Where(x => x.IsDeleted == false).ToList();
            ViewBag.Categories = categories;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Drink drink,int CategoryId)
        {
            var categories = await _dbContext.Categories.ToListAsync();
            ViewBag.categories = categories;
            if (!drink.Photo.ContentType.Contains("image"))
            {
                ModelState.AddModelError("Photos","Yuklediyiniz photo olmalidir");
                return View();
            }
            if (drink.Photo.Length > 1024 * 1000)
            {
                ModelState.AddModelError("Photos","Yuklediyiniz photo 1 mbdan az olmalidir");
                return View();
            }
            var filename = await drink.Photo.GenerateFile(Constants.ImageFolderPath,"images");
            drink.Image = filename;
            drink.CategoryId = CategoryId;
            await _dbContext.Drinks.AddAsync(drink);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteDrink(int?id)
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
            var path = Path.Combine(Constants.ImageFolderPath, drink.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            drink.IsDeleted = true;
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            var categories = await _dbContext.Categories.Where(x => x.IsDeleted == false).ToListAsync();
            ViewBag.Categories = categories;
            var drink = await _dbContext.Drinks.FindAsync(id);
            if (drink==null)
            {
                return NotFound();
            }
            return View(drink);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Drink drink,int CategoryId)
        {
            var categories = await _dbContext.Categories.Where(x => x.IsDeleted == false).ToListAsync();
            ViewBag.Categories = categories;
            if (id==null)
            {
                return NotFound();
            }
            if (id!=drink.Id)
            {
                return BadRequest();
            }
            var existDrink = await _dbContext.Drinks.FindAsync(id);
            if (existDrink==null)
            {
                return NotFound();
            }
            if (!drink.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Yuklediyiniz shekil olmalidir.");
                return View(existDrink);
            }

            if (!drink.Photo.IsAllowedSize(1))
            {
                ModelState.AddModelError("Photo", "1 mb-dan az olmalidir.");
                return View(existDrink);
            }

            var path = Path.Combine(Constants.ImageFolderPath, existDrink.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            var filename = await drink.Photo.GenerateFile(Constants.ImageFolderPath,"images");
            existDrink.Title = drink.Title;
            existDrink.SubTitle = drink.SubTitle;
            existDrink.price = drink.price;
            existDrink.Image = filename;
            existDrink.CategoryId = CategoryId;
            existDrink.SizeLCalories = drink.Description;
            existDrink.SizeLTotalFat = drink.SizeLTotalFat;
            existDrink.SizeLCholesterol = drink.SizeLCholesterol;
            existDrink.SizeLSodium = drink.SizeLSodium;
            existDrink.SizeLTotalCarbs = drink.SizeLTotalCarbs;
            existDrink.SizeLTotalFiber = drink.SizeLTotalFiber;
            existDrink.SizeLTotalSugar = drink.SizeLTotalSugar;
            existDrink.SizeLTotalProtein = drink.SizeLTotalProtein;
            existDrink.SizeMCalories = drink.SizeMCalories;
            existDrink.SizeMTotalFat = drink.SizeMTotalFat;
            existDrink.SizeMCholesterol = drink.SizeMCholesterol;
            existDrink.SizeMSodium = drink.SizeMSodium;
            existDrink.SizeMTotalCarbs = drink.SizeMTotalCarbs;
            existDrink.SizeMTotalFiber = drink.SizeMTotalFiber;
            existDrink.SizeMTotalSugar = drink.SizeMTotalSugar;
            existDrink.SizeMTotalProtein = drink.SizeMTotalProtein;
            existDrink.SizeSCalories = drink.SizeSCalories;
            existDrink.SizeSTotalFat = drink.SizeSTotalFat;
            existDrink.SizeSCholesterol = drink.SizeSCholesterol;
            existDrink.SizeSSodium = drink.SizeSSodium;
            existDrink.SizeSTotalCarbs = drink.SizeSTotalCarbs;
            existDrink.SizeSTotalFiber = drink.SizeSTotalFiber;
            existDrink.SizeSTotalSugar = drink.SizeSTotalSugar;
            existDrink.SizeSTotalProtein = drink.SizeSTotalProtein;

            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}