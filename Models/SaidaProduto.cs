using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    public class SaidaProduto
    {
        [Column("Id")]
        [Display(Name = "Código da saída do produto")]
        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("DataSaida")]
        [Display(Name = "Data da saída")]
        public DateTime DataSaida { get; set; }

        [Column("QtdSaida")]
        [Display(Name = "Quantidade de saída")]
        public int QtdSaida { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("ClienteId")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("TipoSaidaId")]
        public int TipoSaidaId { get; set; }
        public TipoSaida? TipoSaida { get; set; }
    }
}
