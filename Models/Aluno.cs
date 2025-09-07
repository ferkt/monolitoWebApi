using System.ComponentModel.DataAnnotations;

namespace AlunosApi.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Nome { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [EmailAddress]
        public int Idade { get; set; }
    }
}
