using System.ComponentModel;

namespace FabricaDeliciasMVC.Models
{
    public class Pagamento
    {
        [DisplayName ("Número do Pagamento")]
        public int IdPagamento { get; set; }
        [DisplayName("Nome do Pagamento")]
        public string Nome { get; set; }
    }
}