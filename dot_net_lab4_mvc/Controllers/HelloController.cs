using dot_net_lab4_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace dot_net_lab4_mvc.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            HelloModel model = new();
            model.Imie = "Artur";
            model.Nazwisko = "Borkowski";
            model.Indeks = "57647";

            return View(model);
        }
    }
}
