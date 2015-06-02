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
        private readonly _DbContext banco = null ;
        private const int Sucesso = 1;
        private const int Insucesso = 0;

        public ComandaRepositorio()
        {
            banco = new _DbContext();
        }
        public ComandaRepositorio(_DbContext banco)
        {
            this.banco = banco;
        }

        public _DbContext Banco
        {
            get { return banco; }

        }
        public int Cadastrar(Comanda comanda)
        {
            Banco.Entry(comanda).State = System.Data.Entity.EntityState.Added;
            return Banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }
        public IQueryable<VendaComComandaAtiva> ListarItensPorCodigoDaComanda(string codigo)
        {
            Comanda comanda = Banco.Comanda.FirstOrDefault(c=>c.Codigo == codigo);
            return this.Banco.VendaComComandaAtiva.Where(c => c.ComandaID == comanda.ComandaID);
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

        public Comanda GetComandaPorCodigo(string Codigo)
        {
            return Banco.Comanda.FirstOrDefault(c=>c.Codigo == Codigo);
        }
    }
}
