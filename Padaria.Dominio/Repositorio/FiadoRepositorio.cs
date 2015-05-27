using Padaria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
