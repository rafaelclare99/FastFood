

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
    }
}
