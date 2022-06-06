using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_upsB.DataAccesLayer;
using C_upsB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace C_upsB.Controllers
{
    public class Basket : Controller
    {
        private readonly AppDbContext _dbContext;

        public Basket(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var basket = Request.Cookies["basket"];
            if (string.IsNullOrEmpty(basket))
            {
                return Content("Empty");
            }
            var basketViewModels = JsonConvert.DeserializeObject<List<BasketViewModel>>(basket);
            var newBasket = new List<BasketViewModel>();
            foreach (var basketViewModel in basketViewModels)
            {
                var product = await _dbContext.Drinks.FindAsync(basketViewModel.Id);
                if (product==null)
                {
                    continue;
                }
                else
                {
                    newBasket.Add(new BasketViewModel()
                    {
                        Id = product.Id,
                        Name = product.Title,
                        Image = product.Image,
                        Price = product.price,
                        Count=basketViewModel.Count
                    });
                }
                basket = JsonConvert.SerializeObject(newBasket);
                Response.Cookies.Append("basket",basket);
            }
            return View(newBasket);
        }
        
        public async Task<IActionResult> AddToBasket(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }

            var product = await _dbContext.Drinks.FindAsync(id);
            if (product==null)
            {
                return NotFound();
            }

            List<BasketViewModel> basketViewModels;
            var existBasket = Request.Cookies["basket"];
            if (string.IsNullOrEmpty(existBasket))
            {
                basketViewModels = new List<BasketViewModel>();
            }
            else
            {
                basketViewModels = JsonConvert.DeserializeObject<List<BasketViewModel>>(existBasket);
            }

            var existBasketViewMocdel = basketViewModels.FirstOrDefault(x => x.Id == id);

            if (existBasketViewMocdel==null)
            {
                existBasketViewMocdel = new BasketViewModel()
                {
                    Id=product.Id,
                };
                basketViewModels.Add(existBasketViewMocdel);
            }
            else
            {
                existBasketViewMocdel.Count++; 
            }
            var basket = JsonConvert.SerializeObject(basketViewModels);
            Response.Cookies.Append("basket",basket);
            return RedirectToAction(nameof(Index));
            
        }
    }
}