using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FazendaUrbana.Views.Home
{
    public class CadastroLoginModel : PageModel
    {
        // Defina apenas as propriedades e métodos específicos da página aqui
        public class LoginRequest
        {
            public string Email { get; set; } = string.Empty;
            public string Senha { get; set; } = string.Empty;
        }

        public class Usuario
        {
            public string Nome { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Telefone { get; set; } = string.Empty;
            public string Endereco { get; set; } = string.Empty;
            public string CpfCnpj { get; set; } = string.Empty;
        }
    }
}
