using EternaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaMVC.Controllers
{
    public class TeamController : Controller
    {
        private Database _dbContext;
        public TeamController(Database dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Team> teams = new List<Team>();
            teams = _dbContext.Team.Include(x => x.TeamSocialMediaAccounts).ToList();
            return View(teams);
        }
    }
}
