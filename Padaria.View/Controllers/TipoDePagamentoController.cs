using Padaria.Dominio.Entidades;
using Padaria.Dominio.Repositorio;
using System.Web.Mvc;

namespace Padaria.View.Controllers
{
    public class TipoDePagamentoController : Controller
    {
        private TipoDePagamentoRepositorio tipoPagamentoDB = null;
        private const int Sucesso = 1;
        [HttpGet]
        public ActionResult Listar()
        {
            tipoPagamentoDB = new TipoDePagamentoRepositorio();
            return View(tipoPagamentoDB.Listar());
        }
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View(new TipoPagamento());
        }
        [HttpPost]
        public ActionResult Cadastrar(TipoPagamento tipoPagamento)
        {
            tipoPagamentoDB = new TipoDePagamentoRepositorio();

            if (tipoPagamentoDB.Cadastrar(tipoPagamento) == Sucesso)
            {
                return RedirectToAction("Listar");
            }
            return View(tipoPagamento);
        }
        [HttpGet]
        public ActionResult Editar(int tipoPagamentoID)
        {
            tipoPagamentoDB = new TipoDePagamentoRepositorio();
            TipoPagamento tipoPagamento = tipoPagamentoDB.GetTipoPagamento(tipoPagamentoID);
            return View(tipoPagamento);
        }
        [HttpPost]
        public ActionResult Editar(TipoPagamento tipoPagamento)
        {
            tipoPagamentoDB = new TipoDePagamentoRepositorio();
            if (tipoPagamentoDB.Editar(tipoPagamento) == Sucesso)
            {
                return RedirectToAction("Listar");
            }
            return View(tipoPagamento);
        }
        [HttpGet]
        public ActionResult Deletar(int tipoPagamentoID)
        {
            tipoPagamentoDB = new TipoDePagamentoRepositorio();
            TipoPagamento tipoPagamento = tipoPagamentoDB.GetTipoPagamento(tipoPagamentoID);
            return View(tipoPagamento);
        }
        [HttpPost]
        public ActionResult Deletar(TipoPagamento tipoPagamento)
        {
            tipoPagamentoDB = new TipoDePagamentoRepositorio();
            if (tipoPagamentoDB.Deletar(tipoPagamento) == Sucesso)
            {
                return RedirectToAction("Listar");
            }
            return View(tipoPagamento);
        }
        [HttpGet]
        public ActionResult Detales(int tipoPagamentoID)
        {
            tipoPagamentoDB = new TipoDePagamentoRepositorio();
            TipoPagamento tipoPagamento = tipoPagamentoDB.GetTipoPagamento(tipoPagamentoID);
            return View(tipoPagamento);
        }
    }
}
