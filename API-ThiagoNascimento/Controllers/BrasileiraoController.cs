using API_ThiagoNascimento.Models;
using API_ThiagoNascimento.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_ThiagoNascimento.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrasileiraoController : Controller
    {
        private readonly ITabelaService _tabelaService;

        public BrasileiraoController(ITabelaService tabelaService)
        {
            _tabelaService = tabelaService;
        }

        public IActionResult Brasileirao()
        {
            var times = _tabelaService.GetTabelaList();
            return View(times);
        }
    }
}
