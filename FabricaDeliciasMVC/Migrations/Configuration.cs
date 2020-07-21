namespace FabricaDeliciasMVC.Migrations
{
    using FabricaDeliciasMVC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DataContext;

    internal sealed class Configuration : DbMigrationsConfiguration<FabricaDeliciasDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FabricaDeliciasDB context)
        {
            context.Clientes.AddOrUpdate(c => c.Nome, new Cliente { Nome = "Leonardo" }, new Cliente { Nome = "Natalia" });

            context.Pagamentos.AddOrUpdate(p => p.Nome, new Pagamento { Nome = "Dinheiro"}, new Pagamento { Nome = "Cartão Crédito" });

            context.Responsaveis.AddOrUpdate(r => r.Nome, new Responsavel { Nome = "Lili" }, new Responsavel { Nome = "Karina" });

            context.Temas.AddOrUpdate(t => t.Nome, new Tema { Nome = "Dinossauro" }, new Tema { Nome = "Moana" });
        }
    }
}
