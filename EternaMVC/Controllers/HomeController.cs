using EternaMVC.Models;
using EternaMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EternaMVC.Controllers
{
    public class HomeController : Controller
    {
        private Database _dbContext;
        public HomeController(Database dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = _dbContext.Sliders.ToList(),
                Services = _dbContext.Services.ToList(),
                Clients = _dbContext.Clients.ToList(),
            };            
            return View(homeVM);
        }
    }
}
