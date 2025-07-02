using LanchesMac.Repositories;
using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILanchesRepository _lancheRepository;

        public LancheController(ILanchesRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            ViewData["Titulo"] = "Todos os lanches";
            ViewData["Data"] = DateTime.Now;

            var Lanches = _lancheRepository.Lanches;
            var TotalLache = Lanches.Count();

            ViewBag.Total = "Total de Lacnhes : ";
            ViewBag.TotalTotal = TotalLache;



            return View(Lanches);
        }
    }
}
