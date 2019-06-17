using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Checkpoint_PontoDigital.Models;
using System;
using Checkpoint_PontoDigital.Repositorio;

namespace Checkpoint_PontoDigital.Controllers
{
    public class CadastroController :Controller


    {
        private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public IActionResult Index(){
            ViewData["NomeView"] = "Cadastro";
            return View();
        }
        
        public IActionResult Cadastrar(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel();
            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];
            usuario.Telefone = form["telefone"];
            usuario.DataNascimento = DateTime.Parse(form["nascimento"]);

            usuarioRepositorio.Inserir(usuario);
            ViewData["Action"] = "Cadastro";
            
            return RedirectToAction("Index","Home");
        }
    }
}