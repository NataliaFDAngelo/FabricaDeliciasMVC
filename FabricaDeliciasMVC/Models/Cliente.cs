using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FabricaDeliciasMVC.Models
{
    public class Cliente
    {
        [Key]
        [DisplayName ("Número do Cliente")]
        public int IdCliente { get; set; }
        [DisplayName("Nome do Cliente")]
        public string Nome { get; set; }
        [DisplayName("Telefone do Cliente")]
        public string Telefone { get; set; }
    }
}