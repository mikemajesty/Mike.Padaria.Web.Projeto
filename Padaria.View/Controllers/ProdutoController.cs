using Padaria.Dominio.Entidades;
using Padaria.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            produtoDB.InsertProduto(viewModel.Produto);
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Deletar(int ProdutoID)
        {
            produtoDB = new ProdutoRepositorio();
            Produto Produto = produtoDB.GetProdutoForDelete(ProdutoID);
            return ((Produto != null) ? View(CarregarViewModelProdutoCategoria(Produto, Produto.CategoriaID)) : View());

        }
        [HttpPost]
        public ActionResult Deletar(CadastrarPordutoPorUnidadeViewModel viewModel)
        {
            produtoDB = new ProdutoRepositorio();
            return produtoDB.DeleteCliente(viewModel.Produto.ProdutoID) != 0 ? View("Listar", this.ListarCliente()) : View();

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
            return produtoDB.Edit(viewModel.Produto) != 0 ? View("Listar", ListarCliente()) : View(viewModel);

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
