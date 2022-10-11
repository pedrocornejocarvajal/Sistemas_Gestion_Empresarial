using Microsoft.AspNetCore.Mvc;

namespace _06_HwlloWorld_MVC_UI.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            return "Hola Mundo desde el controlador";
        }

        public String Salva()
        {
            return "Hola Salva desde el controlador";
        }

        public ViewResult VistaErBeti()
        {
            return View();
        }
    } 
}
