using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryHunter.Models
{
    public class Pedido
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Estabelecimento Estabelecimento { get; set; }
        public List<Produto> Produtos { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal Total { get; set; }
    }
}
