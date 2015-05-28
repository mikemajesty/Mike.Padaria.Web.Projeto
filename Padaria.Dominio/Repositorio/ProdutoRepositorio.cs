﻿using Padaria.Dominio.Entidades;

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
        public int Salvar(Produto produto)
        {
            banco.Produto.Add(produto);
            return banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;

        }
        public int Deletar(Categoria categoria)
        {            
            banco.Entry(categoria).State = System.Data.Entity.EntityState.Deleted;
            return banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }      
        public Produto GetProduto(int ProdutoID)
        {
            return banco.Produto.Find(ProdutoID);           
        }
        public int Editar(Produto produto)
        {
            this.banco.Entry(produto).State = System.Data.Entity.EntityState.Modified;
            return this.banco.SaveChanges() != 0 ? Sucesso : Insucesso;

        }
    }
}