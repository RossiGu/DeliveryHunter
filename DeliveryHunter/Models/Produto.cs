using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryHunter.Models
{
    public class Produto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdutoId { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public string? ImagemUrl { get; set; }
        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
