using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILanchesRepository _lanchesRepository;
        private readonly CarrinhoCompraController _carrinhoCompra;

        public CarrinhoCompraController(ILanchesRepository lanchesRepository, CarrinhoCompraController carrinhoCompra)
        {
            _lanchesRepository = lanchesRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
