using Padaria.Dominio.Entidades;
using System.Linq;

namespace Padaria.Dominio.Repositorio
{
    public class TipoDePagamentoRepositorio
    {
        private _DbContext _banco = new _DbContext();
        private const int Sucesso = 1;
        private const int Insucesso = 0;
        public _DbContext Banco
        {
            get { return _banco; }
        }


        public IQueryable<TipoPagamento> Listar()
        {
            return Banco.TipoPagamento;
        }

        public int Cadastrar(TipoPagamento tipoPagamento)
        {
            Banco.Entry(tipoPagamento).State = System.Data.Entity.EntityState.Added;
            return Banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }

        public TipoPagamento GetTipoPagamento(int tipoPagamentoID)
        {
            return Banco.TipoPagamento.Find(tipoPagamentoID);
        }

        public int Editar(TipoPagamento tipoPagamento)
        {
            Banco.Entry(tipoPagamento).State = System.Data.Entity.EntityState.Modified;
            return Banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }

        public int Deletar(TipoPagamento tipoPagamento)
        {
            Banco.Entry(tipoPagamento).State = System.Data.Entity.EntityState.Deleted;
            return Banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }
    }
}
