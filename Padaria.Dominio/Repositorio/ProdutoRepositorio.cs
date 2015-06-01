using Padaria.Dominio.Entidades;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
namespace Padaria.Dominio.Repositorio
{
    public class ProdutoRepositorio
    {
        private readonly _DbContext banco = new _DbContext();
        private const int Sucesso = 1;
        private const int Insucesso = 0;
        public _DbContext Banco
        {
            get { return banco; }
        }
        public  Produto GetProdutoPorCodigo(string codigo)
        {
            return Banco.Produto.FirstOrDefault(c => c.Codigo == codigo);
        }
        public IQueryable<Produto> ListarCliente()
        {            
            return Banco.Produto.Include(c => c.Categoria);
        }
       
        public int Salvar(Produto produto)
        {
            banco.Produto.Add(produto);
            return banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;

        }
        public int Deletar(Produto categoria)
        {            
            banco.Entry(categoria).State = System.Data.Entity.EntityState.Deleted;
            return banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }      
        public Produto GetProduto(int ProdutoID)
        {
            return banco.Produto.Find(ProdutoID);           
        }
        public IQueryable<Produto> GetProdutoListar(int ProdutoID)
        {
            //Produto produto = banco.Produto.Find(ProdutoID);
            return Banco.Produto.Where(c => c.ProdutoID == ProdutoID);
        }
        public int Editar(Produto produto)
        {
            this.banco.Entry(produto).State = System.Data.Entity.EntityState.Modified;
            return this.banco.SaveChanges() != 0 ? Sucesso : Insucesso;

        }
    }
}
