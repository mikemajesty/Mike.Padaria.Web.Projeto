using Padaria.Dominio.Entidades;
using Padaria.Dominio.Repositorio;
using Padaria.View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Padaria.View.Controllers
{
    public class UsuariosController : Controller
    {
        private UsuariosRepositorio usuariosDB;
        private const int Sucesso = 1;
        [HttpGet]
        public ActionResult Listar()
        {
            usuariosDB = new UsuariosRepositorio();
            return View(usuariosDB.Listar());
        }
        [HttpGet]
        public ActionResult Cadastrar()
        {
            usuariosDB = new UsuariosRepositorio();
            return View(CarregaParaCadastro());
        }


        [HttpPost]
        public ActionResult Cadastrar(CadastraUsuariosPermissaoViewModel viewModel)
        {
            usuariosDB = new UsuariosRepositorio();
            return usuariosDB.Salvar(viewModel.Usuarios) == Sucesso ? View("Listar", usuariosDB.Listar()) : View(new CadastraUsuariosPermissaoViewModel()
            {
                Usuarios = viewModel.Usuarios,
                Permissao = new SelectList(usuariosDB.Banco.Permissao, "PermissaoID", "Nome")

            });
        }
        [HttpGet]
        public ActionResult Editar(int UsuarioID)
        {
            usuariosDB = new UsuariosRepositorio();
            Usuarios usuario = usuariosDB.GetUsuario(UsuarioID);
            return View(new CadastraUsuariosPermissaoViewModel()
            {
                Usuarios = usuario,
                Permissao = new SelectList(usuariosDB.Banco.Permissao, "PermissaoID", "Nome", usuario.PermissaoID)
            });
        }
        [HttpPost]
        public ActionResult Editar(CadastraUsuariosPermissaoViewModel viewModel)
        {
            usuariosDB = new UsuariosRepositorio();
            return (usuariosDB.Editar(viewModel.Usuarios) == Sucesso) ? View("Listar", usuariosDB.Listar()) : View(viewModel);

        }
        [HttpGet]
        public ActionResult Detales(int UsuarioID)
        {
            usuariosDB = new UsuariosRepositorio();
            Usuarios usuario = usuariosDB.GetUsuario(UsuarioID: UsuarioID);
            return View(new CadastraUsuariosPermissaoViewModel()
            {
                Usuarios = usuario,
                Permissao = new SelectList(usuariosDB.Banco.Permissao, "PermissaoID", "Nome", usuario.PermissaoID)
            });
        }
        [HttpGet]
        public ActionResult Deletar(int UsuarioID)
        {
            usuariosDB = new UsuariosRepositorio();
            Usuarios usuario = usuariosDB.GetUsuario(UsuarioID: UsuarioID);
            return View(new CadastraUsuariosPermissaoViewModel()
            {
                Usuarios = usuario,
                Permissao = new SelectList(usuariosDB.Banco.Permissao, "PermissaoID", "Nome", usuario.PermissaoID)
            });
        }
        [HttpPost]
        public ActionResult Deletar(CadastraUsuariosPermissaoViewModel viewModel)
        {
            usuariosDB = new UsuariosRepositorio();
            return usuariosDB.Deletar(viewModel.Usuarios) == Sucesso ? View("Listar", usuariosDB.Listar()) : View(new CadastraUsuariosPermissaoViewModel()
            {
                Usuarios = viewModel.Usuarios,
                Permissao = new SelectList(usuariosDB.Banco.Permissao, "PermissaoID", "Nome")

            });
        }
        private CadastraUsuariosPermissaoViewModel CarregaParaCadastro()
        {
            return new CadastraUsuariosPermissaoViewModel()
            {
                Permissao = new SelectList(usuariosDB.Banco.Permissao, "PermissaoID", "Nome"),
                Usuarios = new Usuarios() { UltimoAcesso = DateTime.Now.ToString("dd/MM/yyyy H:mm:ss") }

            };
        }
    }
}
