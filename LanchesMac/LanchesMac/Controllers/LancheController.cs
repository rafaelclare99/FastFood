using LanchesMac.Models;
using LanchesMac.Repositories;
using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModels;
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

        public IActionResult List(string categoria)
        {

            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                if (string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals("Normal"))
                        .OrderBy(l => l.LancheNome);
                }
                else
                {
                    lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals("Natural"))
                           .OrderBy(l => l.LancheNome);
                }
                categoriaAtual = categoria;

            }

            var lancheListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual

            };

            return View(lancheListViewModel);


        }
    }
}
