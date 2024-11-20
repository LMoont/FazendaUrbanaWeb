using FazendaUrbana.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FazendaUrbana.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PropostaAplicativo()
        {
            return View();
        }
        public IActionResult CadastroLogin()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}

