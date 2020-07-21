using FabricaDeliciasMVC.DataContext;
using FabricaDeliciasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FabricaDeliciasMVC.Helpers
{
    public class RetornaSelecListItem
    {
        private static FabricaDeliciasDB db = new FabricaDeliciasDB();

        public static List<SelectListItem> Clientes()
        {
            List<Cliente> lCliente = new List<Cliente>();
            lCliente = db.Clientes.ToList();

            List<SelectListItem> listaClientes = lCliente.ConvertAll(c =>
            {
                return new SelectListItem()
                {
                    Text = c.Nome,
                    Value = c.IdCliente.ToString(),
                    Selected = false
                };
            });
            return listaClientes;
        }

        public static List<SelectListItem> Temas()
        {
            List<Tema> lTemas = new List<Tema>();
            lTemas = db.Temas.ToList();

            List<SelectListItem> listaTemas = lTemas.ConvertAll(t =>
            {
                return new SelectListItem()
                {
                    Text = t.Nome,
                    Value = t.IdTema.ToString(),
                    Selected = false
                };
            });
            return listaTemas;
        }

        public static List<SelectListItem> Pagamentos()
        {
            List<Pagamento> lPagamentos = new List<Pagamento>();
            lPagamentos = db.Pagamentos.ToList();

            List<SelectListItem> listaPagamentos = lPagamentos.ConvertAll(p =>
            {
                return new SelectListItem()
                {
                    Text = p.Nome,
                    Value = p.IdPagamento.ToString(),
                    Selected = false
                };
            });
            return listaPagamentos;
        }

        public static List<SelectListItem> Responsaveis()
        {
            List<Responsavel> lResponsaveis = new List<Responsavel>();
            lResponsaveis = db.Responsaveis.ToList();

            List<SelectListItem> listaResponsaveis = lResponsaveis.ConvertAll(r =>
            {
                return new SelectListItem()
                {
                    Text = r.Nome,
                    Value = r.IdResponsavel.ToString(),
                    Selected = false
                };
            });
            return listaResponsaveis;
        }
    }
}