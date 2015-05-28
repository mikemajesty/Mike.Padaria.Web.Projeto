using Padaria.Dominio.Entidades;
using System.Linq;
using System.Data.Entity;

namespace Padaria.Dominio.Repositorio
{
    public class FiadoRepositorio
    {
        private _DbContext _banco = new _DbContext();

        public _DbContext Banco
        {
            get { return _banco; }
        }
        public IQueryable<Fiado> Listar()
        {
            return Banco.Fiado.Include(c => c.Usuario);
        }

    }
}
