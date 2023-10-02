using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
