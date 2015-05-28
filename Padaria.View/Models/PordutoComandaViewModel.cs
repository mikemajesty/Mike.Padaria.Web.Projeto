using Padaria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padaria.View.Models
{
    public class PordutoComandaViewModel
    {
        public Comanda Comanda { get; set; }
        public Produto Produto { get; set; }
    }
}