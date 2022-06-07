using Microsoft.AspNetCore.Mvc;

namespace C_upsB.Areas.MyAdminPanel.Controllers
{
    [Area("MyAdminPanel")]

    public class DashBoard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}