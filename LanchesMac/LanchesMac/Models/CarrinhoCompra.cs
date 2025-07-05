

using LanchesMac.Context;

namespace LanchesMac.Models
{
    public class CarrinhoCompra
    {
        private readonly AppDbContext _context;

        public CarrinhoCompra(AppDbContext context)
        {
            _context = context;
        }

        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoCompraItem> carrinhoCompraItems { get; set; }

        public static CarrinhoCompra GetCarrinho(IServiceProvider services)
        {
            //defina uma seção 
            ISession session =
                services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //obtem o serviço do contexto
            var context = services.GetService<AppDbContext>();

            //obtem ou gera o id do carrinho 
            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            //retorna o carrinho com contexto e o id atibuido ou obtido 
            return new CarrinhoCompra(context)
            {
                CarrinhoCompraId = carrinhoId
            };

        }


        public void AdicionarCarrinho(Lanche lanche)
        {

            var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(s =>
            s.lanche.LancheId == lanche.LancheId &&
            s.CarrinhoCompraId == CarrinhoCompraId);

            if (carrinhoCompraItem == null)
            {

                carrinhoCompraItem = new CarrinhoCompraItem
                {
                    CarrinhoCompraId = CarrinhoCompraId,
                    lanche = lanche,
                    Quantidade = 1

                };
                _context.CarrinhoCompraItens.Add(carrinhoCompraItem);     

            }
            else
            {
                carrinhoCompraItem.Quantidade++;
            }
            _context.SaveChanges();







        }

    }
}
