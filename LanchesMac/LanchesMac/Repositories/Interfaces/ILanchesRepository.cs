using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ILanchesRepository 
    {
        IEnumerable<Lanche>Lanches { get; }
        IEnumerable<Lanche>LanchesPreferido { get; }
        Lanche GetLancheById(int lancheId);
    }
}
