using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CP2.Models
{
    [Table("TB_CP2_Usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }

        [DisplayName("Nome Completo")]
        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string Nome { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string email { get; set; }

        [DisplayName("Senha")]
        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string senha { get; set; }

        [DisplayName("Telefone")]
        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string telefone { get; set; }
    }
}
