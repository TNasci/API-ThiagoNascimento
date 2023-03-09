using APP_ThiagoNascimento.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace APP_ThiagoNascimento.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Brasileirao()
        {
            List<tabelaBrasileiraoModel> times = new List<tabelaBrasileiraoModel>
            {
                new tabelaBrasileiraoModel{ Nome = "Atletico Mineiro", Pontos=84 },
                new tabelaBrasileiraoModel{ Nome = "Flamengo", Pontos=71 },
                new tabelaBrasileiraoModel{ Nome = "Palmeiras", Pontos=66 },
                new tabelaBrasileiraoModel{ Nome = "Fortaleza", Pontos=58 },
                new tabelaBrasileiraoModel{ Nome = "Corinthians", Pontos=57 }
            };
            return View(times);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}