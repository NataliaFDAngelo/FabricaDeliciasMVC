using System.ComponentModel;

namespace FabricaDeliciasMVC.Models
{
    public class Responsavel
    {
        [DisplayName ("Número da Responsável")]
        public int IdResponsavel { get; set; }
        [DisplayName("Nome da Responsável")]
        public string Nome { get; set; }
    }
}