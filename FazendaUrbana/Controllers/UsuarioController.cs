using Microsoft.AspNetCore.Mvc;
using FazendaUrbana.Models;

namespace FazendaUrbana.Controllers
{
    public class UsuarioController : Controller
    {
        // Exibir a página de cadastro
        public IActionResult Cadastro()
        {
            return View();
        }

        // Processar o cadastro
        [HttpPost]
        public IActionResult Cadastro(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                TempData["UsuarioNome"] = usuario.Nome;
                TempData["UsuarioCpfCnpj"] = usuario.CpfCnpj;
                TempData["UsuarioTelefone"] = usuario.Telefone;
                TempData["UsuarioEndereco"] = usuario.Endereco;
                TempData["UsuarioEmail"] = usuario.Email;
                TempData["UsuarioSenha"] = usuario.Senha;

                TempData["MensagemCadastro"] = "Cadastro concluído com sucesso!";

                return RedirectToAction("Perfil");
            }
            return View(usuario);
        }

        public IActionResult Login()
        {
            return View();
        }

        // Processar o login
        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            
            if (email == (string)TempData["UsuarioEmail"] && senha == (string)TempData["UsuarioSenha"])
            {
                TempData.Keep("UsuarioNome"); // Preserva o nome do usuário para exibição
                TempData.Keep("UsuarioEmail");
                return RedirectToAction("Perfil");
            }

            // Mensagem de erro se o login falhar
            ViewBag.Erro = "Email ou senha incorretos";
            return View();
        }

        // Exibir o perfil do usuário
        public IActionResult Perfil()
        {
            ViewBag.MensagemCadastro = TempData["MensagemCadastro"];
            ViewBag.UsuarioNome = TempData["UsuarioNome"];
            ViewBag.UsuarioCpfCnpj = TempData["UsuarioCpfCnpj"];
            ViewBag.UsuarioTelefone = TempData["UsuarioTelefone"];
            ViewBag.UsuarioEndereco = TempData["UsuarioEndereco"];
            ViewBag.UsuarioEmail = TempData["UsuarioEmail"];

            return View();
        }
    }
}
