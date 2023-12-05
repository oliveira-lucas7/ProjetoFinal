using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código do Produto")]
        public int Id { get; set; }

        [Column("NomeProduto")]
        [Display(Name = "Digite o nome do produto")]
        public string NomeProduto { get; set; } = string.Empty;

        [Column("QtdEstoque")]
        [Display(Name = "Digite a quantidade")]
        public int QtdEstoque { get; set; }

        [ForeignKey("TipoProdutoId")]
        public int TipoProdutoId { get; set; }
        public TipoProduto? TipoProduto { get; set; }


        [ForeignKey("FornecedorId")]
        public int FornecedorId { get; set;}
        public Fornecedor? Fornecedor { get; set; }


    }
}
