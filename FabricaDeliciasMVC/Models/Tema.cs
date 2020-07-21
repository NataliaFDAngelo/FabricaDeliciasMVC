using System.ComponentModel;

namespace FabricaDeliciasMVC.Models
{
    public class Tema
    {
        [DisplayName ("Número do Tema")]
        public int IdTema { get; set; }
        [DisplayName("Nome do Tema")]
        public string Nome { get; set; }
    }
}