using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class EntradaProduto
    {
        [Column("Id")]
        [Display(Name = "Código da Entrada do Produto")]
        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("DataEntrada")]
        [Display(Name = "Digite a data da entrada")]
        public DateTime DataEntrada { get; set; } 

        [Column("QtdEntrada")]
        [Display(Name = "Quantidade de Entrada")]
        public int QtdEntrada { get; set; } 
    }
}
