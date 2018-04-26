using System.ComponentModel.DataAnnotations;

namespace Contatos.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Nome { get; set; }
        [Required]
        [StringLength(11)]
        public string Telefone { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
    }
}