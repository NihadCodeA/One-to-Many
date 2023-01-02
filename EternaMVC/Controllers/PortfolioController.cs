using EternaMVC.Models;
using EternaMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaMVC.Controllers
{
    public class PortfolioController : Controller
    {
        private Database _dbContext;
        public PortfolioController(Database dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            PortfolioViewModel portfolioVM = new PortfolioViewModel
            {
                Portfolios = _dbContext.Portfolios
                .Include(pi => pi.PortfolioImages).ToList(),
                Categories = _dbContext.Categories.ToList(),
            };
            return View(portfolioVM);
        }
        public IActionResult Detail(int id)
        {
            Portfolio portfolio = _dbContext.Portfolios
                .Include(x => x.Category)
                .Include(pi=>pi.PortfolioImages)
                .FirstOrDefault(por => por.Id == id);

            if (portfolio is null) return NotFound();
            return View(portfolio);
        }
    }
}
