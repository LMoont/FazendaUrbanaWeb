using System.ComponentModel.DataAnnotations;

namespace FazendaUrbana.Models
{
    public class Usuario
    { 

        [Required]
        public string Nome { get; set; }

        [Required]
        public string CpfCnpj { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }
    }
}
