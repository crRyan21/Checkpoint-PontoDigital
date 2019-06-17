using Microsoft.AspNetCore.Mvc;

namespace Checkpoint_PontoDigital.Controllers
{
    public class HomeController :Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}