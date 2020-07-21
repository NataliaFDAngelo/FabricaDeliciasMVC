using FabricaDeliciasMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FabricaDeliciasMVC.DataContext
{
    public class FabricaDeliciasDB : DbContext
    {
        public DbSet<Orcamento> Orcamentos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Tema> Temas { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Responsavel> Responsaveis { get; set; }
    }
}