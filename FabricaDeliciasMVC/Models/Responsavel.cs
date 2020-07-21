using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FabricaDeliciasMVC.Models
{
    public class Responsavel
    {
        [Key]
        [DisplayName ("Número da Responsável")]
        public int IdResponsavel { get; set; }
        [DisplayName("Nome da Responsável")]
        public string Nome { get; set; }
    }
}