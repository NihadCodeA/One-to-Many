using EternaMVC.Models;
using EternaMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EternaMVC.Controllers
{
    public class AboutController : Controller
    {
        private Database _dbContext;
        public AboutController(Database dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            AboutViewModel aboutVM = new AboutViewModel
            {
                Count = _dbContext.Count.ToList(),
                Clients = _dbContext.Clients.ToList(),
                Testimonials = _dbContext.Testimonials.ToList(),
            };
            return View(aboutVM);
        }
    }
}
