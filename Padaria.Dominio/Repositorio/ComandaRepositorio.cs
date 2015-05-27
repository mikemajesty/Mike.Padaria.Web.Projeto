using Padaria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria.Dominio.Repositorio
{
    public class ComandaRepositorio
    {
        private readonly _DbContext banco = new _DbContext();
        private const int Sucesso = 1;
        private const int Insucesso = 0;

        public _DbContext Banco
        {
            get { return banco; }

        }
        public int Cadastrar(Comanda comanda)
        {
            Banco.Entry(comanda).State = System.Data.Entity.EntityState.Added;
            return Banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }

        public IQueryable<Comanda> Listar()
        {
            return this.Banco.Comanda;
        }
        public Comanda GetComanda(int ComandaID)
        {
            return Banco.Comanda.Find(ComandaID);
        }
        public int Deletar(Comanda comanda)
        {
            Banco.Entry(comanda).State = System.Data.Entity.EntityState.Deleted;
            return Banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }
        public int Editar(Comanda comanda)
        {
            Banco.Entry(comanda).State = System.Data.Entity.EntityState.Modified;
            return Banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }
    }
}
