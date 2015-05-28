using Padaria.Dominio.Entidades;
using Padaria.Dominio.Repositorio;
using Padaria.View.Models;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

namespace Padaria.View.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoRepositorio produtoDB = null;


        private CadastrarPordutoPorUnidadeViewModel CarregarViewModelProdutoCategoria(Produto produto, int Selecao = 0)
        {
            CadastrarPordutoPorUnidadeViewModel viewModel = new CadastrarPordutoPorUnidadeViewModel();
            viewModel.Categoria = new SelectList(produtoDB.Banco.Categoria, "CategoriaID", "Nome", new { Selecao });
            viewModel.Produto = produto;
            return viewModel;
        }
        private IQueryable<Produto> ListarCliente()
        {
            produtoDB = new ProdutoRepositorio();
            return produtoDB.Banco.Produto.Include(c => c.Categoria);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(ListarCliente());
        }
        [HttpGet]
        public ActionResult Cadastrar()
        {
            produtoDB = new ProdutoRepositorio();
            return View(CarregarViewModelProdutoCategoria(new Produto()));
        }

        [HttpPost]
        public ActionResult Cadastrar(CadastrarPordutoPorUnidadeViewModel viewModel)
        {
            produtoDB = new ProdutoRepositorio();
            produtoDB.Salvar(viewModel.Produto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Deletar(int ProdutoID)
        {
            produtoDB = new ProdutoRepositorio();
            Produto Produto = produtoDB.GetProduto(ProdutoID);
            return ((Produto != null) ? View(CarregarViewModelProdutoCategoria(Produto, Produto.CategoriaID)) : View());

        }
        [HttpPost]
        public ActionResult Deletar(CadastrarPordutoPorUnidadeViewModel viewModel)
        {
            produtoDB = new ProdutoRepositorio();
            if (produtoDB.Deletar(viewModel.Produto) != 0 )
	        {
                  return RedirectToAction("Listar");
 	        }
            return View(viewModel);

        }
        [HttpGet]
        public ActionResult Editar(int ProdutoID)
        {
            produtoDB = new ProdutoRepositorio();
            Produto produto = produtoDB.GetProduto(ProdutoID);
            return View(CarregarViewModelProdutoCategoria(produto, produto.CategoriaID));
        }
        [HttpPost]
        public ActionResult Editar(CadastrarPordutoPorUnidadeViewModel viewModel)
        {
            produtoDB = new ProdutoRepositorio();
            return produtoDB.Editar(viewModel.Produto) != 0 ? View("Listar", ListarCliente()) : View(viewModel);

        }
        [HttpGet]
        public ActionResult Detales(int ProdutoID)
        {
            produtoDB = new ProdutoRepositorio();
            Produto produto = produtoDB.GetProduto(ProdutoID);
            return (produto != null) ? View(CarregarViewModelProdutoCategoria(produto, produto.CategoriaID)) : View("Listar", this.ListarCliente());
        }

    }
}
