using Padaria.Dominio.Entidades;
using Padaria.Dominio.Repositorio;
using System.Web.Mvc;

namespace Padaria.View.Controllers
{
    public class CategoriaController : Controller
    {
        private CategoriaRepositorio categoriaDB;
        private const int Sucesso = 1;
        private const int Insucesso = 0;
      
        [HttpGet]
        public ActionResult Listar()
        {
            categoriaDB = new CategoriaRepositorio();
            return View(categoriaDB.Listar());

        }
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View(new Categoria());
        }
        [HttpPost]
        public ActionResult Cadastrar(Categoria categoria)
        {
            categoriaDB = new CategoriaRepositorio();
            if (categoriaDB.Cadastrar(categoria) != 0)
            {
               return RedirectToAction("Listar");
            }
            return View(categoria);
           
        }
        [HttpGet]
        public ActionResult Editar(int CategoriaID)
        {
            categoriaDB = new CategoriaRepositorio();
            Categoria categoria = categoriaDB.GetCategoria(CategoriaID: CategoriaID);           
            return View(categoria);
        }
        [HttpPost]
        public ActionResult Editar(Categoria categoria)
        {
            categoriaDB = new CategoriaRepositorio();
            if (categoriaDB.Editar(categoria) != 0)
            {
                return RedirectToAction("Listar");
            }
            return View("Listar");
          
        }
        [HttpGet]
        public ActionResult Deletar(int CategoriaID)
        {
            categoriaDB = new CategoriaRepositorio();
            Categoria categoria = categoriaDB.GetCategoria(CategoriaID);          
            return View(categoria);
        }
        [HttpPost]
        public ActionResult Deletar(Categoria categoria)
        {
            categoriaDB = new CategoriaRepositorio();
            if (categoriaDB.Deletar(categoria) != 0)
            {
              return RedirectToAction("Listar");
            }
            return View(categoria);

        }
        [HttpGet]
        public ActionResult Detales(int CategoriaID)
        {
            categoriaDB = new CategoriaRepositorio();
            Categoria categoria = categoriaDB.GetCategoria(CategoriaID);          
            return View(categoria);

        }

    }
}
