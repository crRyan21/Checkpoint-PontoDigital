using Checkpoint_PontoDigital.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint_PontoDigital.Controllers {
    public class ClienteController : Controller {
        private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
        
        private const string SESSION_EMAIL = "_Email";

        private const string SESSION_USUARIO = "_USUARIO";
        


        [HttpGet]
        public IActionResult Login () {
            return View ();
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            var usuario = form["email"];
            var senha = form["senha"];

            var cliente = usuarioRepositorio.ObterPor (usuario);

            if (cliente != null && cliente.Email.Equals (usuario) && cliente.Senha.Equals (senha)) {
                HttpContext.Session.SetString (SESSION_EMAIL, usuario);
                HttpContext.Session.SetString (SESSION_USUARIO, cliente.Nome);
                cliente.Nome = (string)ViewData["User"];

            } else {
                return View();
            }
            return RedirectToAction("EnviarDepoimento","Depoimento");
        }

        public IActionResult Logout () {
            HttpContext.Session.Remove (SESSION_EMAIL);
            HttpContext.Session.Remove (SESSION_USUARIO);
            HttpContext.Session.Clear ();
            return RedirectToAction ("Index", "Home");
        }
    }
}