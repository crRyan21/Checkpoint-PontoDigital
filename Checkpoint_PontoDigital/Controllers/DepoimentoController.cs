using System;
using Checkpoint_PontoDigital.Models;
using Checkpoint_PontoDigital.Repositorio;
using Checkpoint_PontoDigital.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint_PontoDigital.Controllers {
    public class DepoimentoController : Controller

    {
        private DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio ();
        private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
        
        DepoimentoViewModel depoimentoViewModel = new DepoimentoViewModel();
        private const string SESSION_EMAIL = "_Email";
        private const string SESSION_USUARIO = "_USUARIO";

        [HttpGet]
        public IActionResult EnviarDepoimento () {
            depoimentoViewModel.depoimentos = depoimentoRepositorio.ListarTodos();
            return View (depoimentoViewModel);
        }

        [HttpPost]
        public IActionResult EnviarDepoimento (IFormCollection form) {
         DepoimentoModel usuario = new DepoimentoModel();
            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Telefone = form["telefone"];
            usuario.Estado = form["estado"];
            usuario.Titulo = form["titulo"];
            usuario.Descricao = form["descricao"];
        
            depoimentoRepositorio.Inserir(usuario);
            ViewData["Action"] = "EnviarDepoimento";
            
            return RedirectToAction("Depoimentos","Depoimento");
        }
        public IActionResult ListarDepoimentos(){
            var listaDeDepoimentos = depoimentoRepositorio.ListarTodos();

            if (listaDeDepoimentos.Count ==0)
            {
                ViewData["mensagem"] = "Nenhum Depoimentos";
            }
            depoimentoViewModel.depoimentos = listaDeDepoimentos;
            return View(depoimentoViewModel);
        }
            public IActionResult Apagar (int id){
                depoimentoRepositorio.Apagar(id);
        
                return RedirectToAction("ListarDepoimentos","Depoimento");
            }

            public IActionResult Depoimentos(){
                var listaDeDepoimentos = depoimentoRepositorio.ListarTodos();

            if (listaDeDepoimentos.Count ==0)
            {
                ViewData["mensagem"] = "Nenhum Depoimentos";
            }
            depoimentoViewModel.depoimentos = listaDeDepoimentos;
                return View(depoimentoViewModel);
            }
    }
}