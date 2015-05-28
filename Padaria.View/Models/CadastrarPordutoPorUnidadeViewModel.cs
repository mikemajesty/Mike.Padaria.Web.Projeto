using Padaria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Padaria.View.Models
{
    public class CadastrarPordutoPorUnidadeViewModel
    {
        public Produto Produto { get; set; }
        public SelectList Categoria { get; set; }
        
    }
}