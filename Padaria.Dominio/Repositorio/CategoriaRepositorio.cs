using Padaria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria.Dominio.Repositorio
{
    public class CategoriaRepositorio 
    {
        private readonly _DbContext banco = new _DbContext();
        private const int Sucesso = 1;
        private const int Insucesso = 0;
        public _DbContext Banco
        {
            get { return banco; }
        }
        public IQueryable<Categoria> Listar()
        {
            return this.banco.Categoria;
        }
        public Categoria GetCategoria(int CategoriaID)
        {
            return this.banco.Categoria.Find(CategoriaID);             
        }
        public int Cadastrar(Categoria categoria)
        {
            banco.Entry(categoria).State = System.Data.Entity.EntityState.Added;
            return banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }
        public int Editar(Categoria categoria)
        {
            banco.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
            return banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }
        public int Deletar(Categoria categoria)
        {
            banco.Entry(categoria).State = System.Data.Entity.EntityState.Deleted;
            return banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }
     
    }
}
