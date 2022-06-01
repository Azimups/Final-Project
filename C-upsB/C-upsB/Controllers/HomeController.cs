using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var stylishitems = await _dbContext.Stylish.SingleOrDefaultAsync();
            var aboutimages = await _dbContext.AboutImages.SingleOrDefaultAsync();
            var abouttexts = await _dbContext.AboutTexts.SingleOrDefaultAsync();
            var categories = await _dbContext.Categories.ToListAsync();
            var blogs = await _dbContext.Blogs.ToListAsync();
            
            return View( new HomeViewModel
            {
                Stylish = stylishitems,
                AboutImages = aboutimages,
                AboutTexts = abouttexts,
                Categories = categories,
                Blogs = blogs,
            });
        }

    }
}