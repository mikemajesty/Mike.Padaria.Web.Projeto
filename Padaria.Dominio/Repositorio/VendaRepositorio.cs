using Padaria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria.Dominio.Repositorio
{
    public class VendaRepositorio
    {
        private _DbContext _banco = new _DbContext();

        public _DbContext Banco
        {
            get { return _banco; }
            set { _banco = value; }
        }

        private Caixa _caixa;

        public Caixa GetCaixa
        {
            get { return _caixa; }
            set { _caixa = value; }
        }
        private Produto _produto;

        public Produto GetProduto
        {
            get { return _produto; }
            set { _produto = value; }
        }

        public decimal GetValorCaixa()
        {
            return this.Banco.Caixa.Sum(c => c.Valor);

        }
        private Comanda _comanda;

        public Comanda GetComanda
        {
            get { return _comanda; }
            set { _comanda = value; }
        }
        private Fiado _fiado;

        public Fiado GetFiado
        {
            get { return _fiado; }
            set { _fiado = value; }
        }
        private Permissao _permissao;

        public Permissao GetPermissao
        {
            get { return _permissao; }
            set { _permissao = value; }
        }
        private Usuarios _usuarios;

        public Usuarios GetUsuarios
        {
            get { return _usuarios; }
            set { _usuarios = value; }
        }
        private VendaComComandaAtiva _vendaComanada;

        public VendaComComandaAtiva GetVendaComComandaAtiva
        {
            get { return _vendaComanada; }
            set { _vendaComanada = value; }
        }
        public Comanda GetComandaPorCodigo(string codigo)
        {
            return Banco.Comanda.FirstOrDefault(c => c.Codigo == codigo);
        }
        public Produto GetProdutoPorCosigo(string Codigo)
        {
            return Banco.Produto.FirstOrDefault(c => c.Codigo == Codigo);
        }
        public SelectList GetCliente()
        {
            return new SelectList(Banco.Cliente, "ClienteID", "Nome");
        }

        public SelectList GetTipoPagamento()
        {
            return new SelectList(Banco.TipoPagamento, "TipoPagamentoID", "Tipo");

        }
    }
}
