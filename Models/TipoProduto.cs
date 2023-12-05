using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class TipoProduto
    {
        [Column("Id")]
        [Display(Name = "Código do Tipo de Produto")]
        public int Id { get; set; }

        [Column("TipoProdutoDescricao")]
        [Display(Name = "Digite a descrição do produto")]
        public string TipoProdutoDescricao { get; set; } = string.Empty;
    }
}
