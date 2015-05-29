using Padaria.Dominio.Repositorio;
using Padaria.View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Padaria.View.Controllers
{
    public class VendaController : Controller
    {
        VendaRepositorio vendaDB = null;
        [HttpGet]
        public ActionResult Index()
        {
            return View(FillViewModel());
        }
        [HttpGet]
        public PartialViewResult GetValorCaixa()
        {
            return PartialView(new VendaRepositorio());
        }
        [HttpPost]

        public ActionResult Produto(VendaViewModel viewModel)
        {
            vendaDB = new VendaRepositorio();
            return View(new PordutoComandaViewModel()
            {
                Comanda = vendaDB.GetComandaPorCodigo(viewModel.Comanda.Codigo),
                Produto = vendaDB.GetProdutoPorCosigo(viewModel.Produto.Codigo)
            });
        }
        private VendaViewModel FillViewModel()
        {
            vendaDB = new VendaRepositorio();
            return new VendaViewModel()
            {
                Caixa = vendaDB.GetCaixa,
                Cliente = vendaDB.GetCliente(),
                TipoPagamento = vendaDB.GetTipoPagamento(),
                Permissao = vendaDB.GetPermissao,
                Comanda = vendaDB.GetComanda,
                Fiado = vendaDB.GetFiado,
                Usuario = vendaDB.GetUsuarios,
                VendaNaComanda = vendaDB.GetVendaComComandaAtiva,
                Produto = vendaDB.GetProduto
            };
        }
    }
}
