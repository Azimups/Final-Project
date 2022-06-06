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
    public class BlogCrud : Controller
    {
        private readonly AppDbContext _dbContext;

        public BlogCrud(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var blogs = await _dbContext.Blogs.Where(x => x.IsDeleted == false).ToListAsync();
            return View(blogs);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (!blog.Photo.ContentType.Contains("image"))
            {
                ModelState.AddModelError("Photos","Yuklediyiniz photo olmalidir");
                return View();
            }
            if (blog.Photo.Length > 1024 * 1000)
            {
                ModelState.AddModelError("Photos","Yuklediyiniz photo 1 mbdan az olmalidir");
                return View();
            }
            var filename = await blog.Photo.GenerateFile(Constants.ImageFolderPath,"images");
            blog.Image = filename;
            await _dbContext.Blogs.AddAsync(blog);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var blog = await _dbContext.Blogs.FindAsync(id);
            if (blog==null)
            {
                return NotFound();
            }
            return View(blog);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var blog = await _dbContext.Blogs.FindAsync(id);
            if (blog==null)
            {
                return NotFound();
            }
            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteBlog(int?id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var blog = await _dbContext.Blogs.FindAsync(id);
            if (blog==null)
            {
                return NotFound();
            }
            var path = Path.Combine(Constants.ImageFolderPath, blog.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            blog.IsDeleted = true;
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            
            var blog = await _dbContext.Blogs.FindAsync(id);
            if (blog==null)
            {
                return NotFound();
            }
            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Blog blog)
        {
            var existBlog = await _dbContext.Blogs.FindAsync(id);
            if (existBlog==null)
            {
                return NotFound();
            }
            if (!blog.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Yuklediyiniz shekil olmalidir.");
                return View(existBlog);
            }

            if (!blog.Photo.IsAllowedSize(1))
            {
                ModelState.AddModelError("Photo", "1 mb-dan az olmalidir.");
                return View(existBlog);
            }
            var path = Path.Combine(Constants.ImageFolderPath, existBlog.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            var filename = await blog.Photo.GenerateFile(Constants.ImageFolderPath,"images");
            existBlog.Questions = blog.Questions;
            existBlog.Name = blog.Name;
            existBlog.Image = filename;
            existBlog.ContentHeader = blog.ContentHeader;
            existBlog.TitleFirst = blog.TitleFirst;
            existBlog.TitleSecond = blog.TitleSecond;
            existBlog.TitleThird = blog.TitleThird;
            existBlog.ContentHeaderTwo = blog.ContentHeaderTwo;
            existBlog.TitleFifth = blog.ContentHeader;
            existBlog.TitleSix = blog.ContentHeader;
            existBlog.TitleSeven = blog.ContentHeader;
            existBlog.ContentHeaderThird = blog.ContentHeader;
            existBlog.TitleEight = blog.ContentHeader;
            existBlog.TitleFourth = blog.TitleFourth;
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}