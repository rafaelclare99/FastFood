namespace LanchesMac.Models
{
    public class Lanche
    {
        public int LacheId { get; set; }
        public string LancheNome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImgegemUrl { get; set; }
        public string ImagemThumb { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}