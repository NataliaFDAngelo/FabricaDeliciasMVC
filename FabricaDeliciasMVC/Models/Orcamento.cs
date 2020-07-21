using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FabricaDeliciasMVC.Models
{
    public class Orcamento
    {
        [Key]
        [DisplayName("Número do Orçamento")]
        public int IdOrcamento { get; set; }
        [DisplayName("Descrição do Orçamento")]
        public string Descricao { get; set; }
        public Tema Tema { get; set; }
        public Cliente Cliente { get; set; }
        [DisplayName("Forma de Pagamento")]
        public Pagamento Pagamento { get; set; }
        [DisplayName("Responsável pelo Orçamento")]
        public Responsavel Responsavel { get; set; }
        public decimal Valor { get; set; }

        public int ClienteId { get; set; }
        public int TemaId { get; set; }
        public int ResponsavelId { get; set; }
        public int PagamentoId { get; set; }
    }
}