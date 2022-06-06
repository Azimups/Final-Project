using System.Threading.Tasks;
using C_upsB.DataAccesLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace C_upsB.Controllers
{
    public class Blog:Controller
    {
        private readonly ILogger<Blog> _logger;
        private readonly AppDbContext _dbContext;

        public Blog(ILogger<Blog> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) 
            {
                return NotFound();
            }
            var blogger = await _dbContext.Blogs.FindAsync(id);
            if (blogger==null)
            {
                return NotFound();
            }

            var blogRelateds = await _dbContext.BlogRelateds.ToListAsync();
            ViewBag.BlogRelateds = blogRelateds;
            return View(blogger);
        }
    }
}