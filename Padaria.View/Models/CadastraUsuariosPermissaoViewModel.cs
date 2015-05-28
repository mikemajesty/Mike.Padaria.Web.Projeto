using Padaria.Dominio.Entidades;
using System.Web.Mvc;

namespace Padaria.View.Models
{
    public class CadastraUsuariosPermissaoViewModel
    {
        public Usuarios Usuarios { get; set; }
        public SelectList Permissao { get; set; }
    }
}