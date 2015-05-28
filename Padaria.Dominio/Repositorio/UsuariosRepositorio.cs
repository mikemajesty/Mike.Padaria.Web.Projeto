using Padaria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace Padaria.Dominio.Repositorio
{
    public class UsuariosRepositorio
    {
        private _DbContext _banco = new _DbContext();
        private const int Sucesso = 1;
        private const int Insucesso = 0;
        public _DbContext Banco
        {
            get { return _banco; }
        }

        public IQueryable<Usuarios> Listar()
        {
            return Banco.Usuarios.Include(c => c.Permissao);
        }
        public int Salvar(Usuarios usuarios)
        {
            Banco.Entry(usuarios).State = EntityState.Added;
            return Banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;

        }

        public Usuarios GetUsuario(int UsuarioID)
        {
            return Banco.Usuarios.Find(UsuarioID);
        }

        public int Editar(Usuarios usuario)
        {
            Banco.Entry(usuario).State = EntityState.Modified;
            return Banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }

        public int Deletar(Usuarios usuario)
        {
            Banco.Entry(usuario).State = EntityState.Deleted;
            return Banco.SaveChanges() == Sucesso ? Sucesso : Insucesso;
        }
    }
}
