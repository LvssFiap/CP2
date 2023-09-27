using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CP2.Models
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdutoId { get; set; }

        [DisplayName("Nome do Produto")]
        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string Nome { get; set; }

        [DisplayName("Descrição do Produto")]
        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string desc { get; set; }

        [DisplayName("Valor do produto")]
        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public double valor { get; set; }

        [DisplayName("Quantidade do Produto")]
        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public int quantidade { get; set; }

        [DisplayName("Localização do Produto")]
        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string local { get; set; }

        [DisplayName("Link da Imagem do Produtp")]
        [Required(ErrorMessage = "Campo não pode ser nulo")]
        public string? url { get; set; }
    }
}
