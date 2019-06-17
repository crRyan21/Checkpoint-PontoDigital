
using System;
using Checkpoint_PontoDigital.Models;
using Checkpoint_PontoDigital.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint_PontoDigital.Controllers
{
    public class CadastroAdmController :Controller
    {

        private AdmRepositorio administradorRepositorio = new AdmRepositorio ();
        
        [HttpGet]
         public IActionResult Cadastrar(){
             return View();
         }
         [HttpPost]
          public IActionResult Cadastrar(IFormCollection form){
            AdmModel usuario = new AdmModel();;
            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];
            usuario.Telefone = form["telefone"];
            usuario.DataNascimento = DateTime.Parse(form["nascimento"]);

            administradorRepositorio.Inserir(usuario);
            ViewData["Action"] = "CadastroAdm";
            
            return RedirectToAction("Index","Home");
        }


        
    }
}