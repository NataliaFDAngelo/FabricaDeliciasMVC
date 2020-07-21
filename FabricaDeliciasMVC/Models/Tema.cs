using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FabricaDeliciasMVC.Models
{
    public class Tema
    {
        [Key]
        [DisplayName ("Número do Tema")]
        public int IdTema { get; set; }
        [DisplayName("Nome do Tema")]
        public string Nome { get; set; }
    }
}