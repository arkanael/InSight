namespace InSight.Application.DTOs
{
    public class ProdutoDTO
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; set; }
        public FornecedorDTO Fornecedor { get; set; }
        public CategoriaDTO Categorias { get; set; }
    }
}
