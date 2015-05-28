using Padaria.Dominio.Entidades;
using Padaria.Dominio.Repositorio;
using System.Web.Mvc;

namespace Padaria.View.Controllers
{
    public class ClienteController : Controller
    {
        ClienteRepositorio clienteDB = null;

        [HttpGet]
        public ActionResult Listar()
        {
            clienteDB = new ClienteRepositorio();
            return View(clienteDB.Listar());
        }
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View(new Cliente());
        }
        [HttpPost]
        public ActionResult Cadastrar(Cliente cliente)
        {
            clienteDB = new ClienteRepositorio();
            if (clienteDB.Cadastrar(cliente) != 0)
            {
                RedirectToAction("Listar");
            }
            return View(cliente);
        }
        [HttpGet]
        public ActionResult Editar(int ClienteID)
        {
            clienteDB = new ClienteRepositorio();
            Cliente cliente = clienteDB.GetCliente(ClienteID);
            return View(cliente);
        }
        [HttpPost]
        public ActionResult Editar(Cliente cliente)
        {
            clienteDB = new ClienteRepositorio();
            if (clienteDB.Editar(cliente) != 0)
            {
                return RedirectToAction("Listar");
            }
            return View(cliente);
        }
        [HttpGet]
        public ActionResult Detales(int ClienteID)
        {
            clienteDB = new ClienteRepositorio();
            Cliente cliente = clienteDB.GetCliente(ClienteID);
            return View(cliente);
        }
        [HttpGet]
        public ActionResult Deletar(int ClienteID)
        {
            clienteDB = new ClienteRepositorio();
            Cliente cliente = clienteDB.GetCliente(ClienteID);
            return View(cliente);
        }
        [HttpPost]
        public ActionResult Deletar(Cliente cliente)
        {
            clienteDB = new ClienteRepositorio();
            if (clienteDB.Deletar(cliente) != 0 )
            {
                return RedirectToAction("Listar");
            }
            return  View(cliente);
        }
    }
}
