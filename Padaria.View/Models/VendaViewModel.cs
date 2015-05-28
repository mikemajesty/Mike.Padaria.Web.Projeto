using Padaria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Padaria.View.Models
{
    public class VendaViewModel
    {
        public Caixa Caixa { get; set; }
        public SelectList Cliente { get; set; }
        public Comanda Comanda { get; set; }
        public Fiado Fiado { get; set; }
        public Permissao Permissao { get; set; }
        public SelectList TipoPagamento { get; set; }
        public Usuarios Usuario { get; set; }
        public VendaComComandaAtiva VendaNaComanda { get; set; }
        public Produto Produto { get; set; }
    }
}