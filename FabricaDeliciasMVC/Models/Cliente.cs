using System.ComponentModel;

namespace FabricaDeliciasMVC.Models
{
    public class Cliente
    {
        [DisplayName ("Número do Cliente")]
        public int IdCliente { get; set; }
        [DisplayName("Nome do Cliente")]
        public string Nome { get; set; }
        [DisplayName("Telefone do Cliente")]
        public string Telefone { get; set; }
    }
}