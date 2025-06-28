using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;

namespace LanchesMac.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository (AppDbContext appcontext)
        {
            _context = appcontext;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
