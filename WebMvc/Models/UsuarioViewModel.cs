using System.ComponentModel.DataAnnotations;

namespace WebMvc.Models
{
    public class UsuarioViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Preenchimento Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 6)]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int idade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        public string Email { get; set; }
    }
}
