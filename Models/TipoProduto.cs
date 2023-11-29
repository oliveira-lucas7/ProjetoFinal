using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class TipoProduto
    {
        [Column("TipoProdutoId")]
        [Display(Name = "Código do Tipo de Produto")]
        public int TipoProdutoId { get; set; }

        [Column("TipoProdutoDescricao")]
        [Display(Name = "Digite a descrição do produto")]
        public string TipoProdutoDescricao { get; set; } = string.Empty;
    }
}
