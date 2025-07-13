using LanchesMac.Models;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace LanchesMac.Components
{
    public class CarrinhoCompraResumo : ViewComponent
    {
        readonly CarrinhoCompra _carrinhoCompra;
         
        public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra) 
        {
        _carrinhoCompra = carrinhoCompra;
        }

        public IViewComponentResult Invoke()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()

            };

            return View(carrinhoCompraVM);
        }
    }
}
