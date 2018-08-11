
using System.ComponentModel.DataAnnotations;


namespace AspNetVS2017.Capitulo03.Mvc.Portfolio.Models
{
    public class ContatoViewModel
    {
        [Required] // falar que o camppo é obrigatorio no formulario.
        public string Nome { get; set; }

        [Required] // falar que o camppo é obrigatorio no formulario.
        [EmailAddress] // Validar se o e-mail está no padrão correto.
        public string Email { get; set; }

        [Required] // falar que o camppo é obrigatorio no formulario.
        public string Mensagem { get; set; }
    }
}