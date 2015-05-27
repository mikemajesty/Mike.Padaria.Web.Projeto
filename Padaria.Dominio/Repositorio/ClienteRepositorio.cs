using Padaria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria.Dominio.Repositorio
{
    public class ClienteRepositorio
    {
        private readonly _DbContext banco = new _DbContext();
        private const int Sucesso = 1;
        private const int Insucesso = 0;
        public _DbContext Banco
        {
            get { return banco; }
        }

        public IQueryable<Cliente> Listar()
        {
            return this.banco.Cliente;
        }
        public int Cadastrar(Cliente cliente)
        {
            banco.Entry(cliente).State = System.Data.Entity.EntityState.Added;
            return banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }
        public Cliente GetCliente(int ClienteID)
        {
            return banco.Cliente.Find(ClienteID);
        }
        public int Editar(Cliente cliente)
        {
            banco.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
            return banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }
        public int Deletar(Cliente cliente)
        {
            banco.Entry(cliente).State = System.Data.Entity.EntityState.Deleted;
            return banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }
    }
}
