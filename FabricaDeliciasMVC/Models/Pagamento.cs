using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FabricaDeliciasMVC.Models
{
    public class Pagamento
    {
        [Key]
        [DisplayName ("Número do Pagamento")]
        public int IdPagamento { get; set; }
        [DisplayName("Nome do Pagamento")]
        public string Nome { get; set; }
    }
}