using Checkpoint_PontoDigital.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint_PontoDigital.Controllers {
    public class AdministradorController : Controller {
        private AdmRepositorio administradorRepositorio = new AdmRepositorio ();

        private const string SESSION_EMAIL = "_Email";
        private const string SESSION_USUARIO = "_USUARIO";

        [HttpGet]
        public IActionResult AdministradorLogin (){
            return View ();

        }
        [HttpPost]
        public IActionResult AdministradorLogin (IFormCollection form) {
            var usuario = form["email"];
            var senha = form["senha"];

            var cliente = administradorRepositorio.ObterPor (usuario);

            if (cliente != null && cliente.Email.Equals (usuario) && cliente.Senha.Equals (senha)) {
                HttpContext.Session.SetString (SESSION_EMAIL, usuario);
                HttpContext.Session.SetString (SESSION_USUARIO, cliente.Nome);
                cliente.Nome = (string)ViewData["User"];

            } else {
                return View();
            }
            return RedirectToAction("ListarDepoimentos","Depoimento");
        
            
            
        }
    }
}