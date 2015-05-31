using Padaria.Dominio.Entidades;
using Padaria.Dominio.Repositorio;
using System.Web.Mvc;

namespace Padaria.View.Controllers
{
    public class ComandaController : Controller
    {

        private ComandaRepositorio comandaBD = null;
        private const int Sucesso = 1;
        private const int Insucesso = 0;
        [HttpGet]
        public ActionResult Listar()
        {
            comandaBD = new ComandaRepositorio();
            return View(comandaBD.Listar());
        }
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View(new Comanda());
        }
        [HttpPost]
        public ActionResult Cadastrar(Comanda comanda)
        {
            comandaBD = new ComandaRepositorio();
            if (comandaBD.Cadastrar(comanda) == Sucesso)
            {
                return RedirectToAction("Listar");
            }
            return View(comandaBD);
        }
        [HttpGet]
        public ActionResult Deletar(int ComandaID)
        {
            comandaBD = new ComandaRepositorio();
            Comanda comanda = comandaBD.GetComanda(ComandaID);
            return View(comanda);
        }
        [HttpPost]
        public ActionResult Deletar(Comanda comanda)
        {
            comandaBD = new ComandaRepositorio();
            if (comandaBD.Deletar(comanda) == Sucesso)
            {
                return RedirectToAction("Listar");
            }
            return View(comanda);

        }

        [HttpGet]
        public ActionResult Detales(int ComandaID)
        {
            comandaBD = new ComandaRepositorio();
            Comanda comanda = comandaBD.GetComanda(ComandaID);
            return View(comanda);
        }
        [HttpGet]
        public ActionResult Editar(int ComandaID)
        {
            comandaBD = new ComandaRepositorio();
            Comanda comanda = comandaBD.GetComanda(ComandaID);
            return View(comanda);
        }
        [HttpPost]
        public ActionResult Editar(Comanda comanda)
        {
            comandaBD = new ComandaRepositorio();
            if (comandaBD.Editar(comanda) == Sucesso)
            {
                return RedirectToAction("Listar");
            }
            return View(comanda);
        }
        [HttpPost]
        public JsonResult GetComanda(string Codigo)
        {
            try
            {
                comandaBD = new ComandaRepositorio();
                Comanda comanda = comandaBD.GetComandaPorCodigo(Codigo);
                return Json(new { Codigo = comanda.Codigo, ComandaID = comanda.ComandaID }, JsonRequestBehavior.AllowGet);

            }
            catch (System.Exception)
            {

                return null;
            }

        }
        [HttpGet]
        public ActionResult GetItensNaComanda(string comandaCodigo)
        {
            comandaBD = new ComandaRepositorio();
            return PartialView(comandaBD.ListarItensPorCodigoDaComanda(comandaCodigo));
        }

    }
}
