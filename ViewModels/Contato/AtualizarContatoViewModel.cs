using System.ComponentModel.DataAnnotations;

namespace Contatos.ViewModels.Contato
{
    public class AtualizarContatoViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatorio.")]
        [StringLength(255, ErrorMessage = "Tamanho maximo do campo 255 caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Telefone é obrigatorio.")]
        [StringLength(11, ErrorMessage = "Tamanho maximo do campo 11 caracteres.")]
        public string Telefone { get; set; }
        [StringLength(255, ErrorMessage = "Tamanho maximo do campo 255 caracterres")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email não valido")]
        public string Email { get; set; }
    }
}