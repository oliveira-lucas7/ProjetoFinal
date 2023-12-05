using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class TipoSaida
    {
        [Column("Id")]
        [Display(Name = "Código do Tipo de saída do Produto")]
        public int Id { get; set; }

        [Column("TipoSaidaDescricao")]
        [Display(Name = "Digite a descrição da saída do produto")]
        public string TipoSaidaDescricao { get; set; } = string.Empty;
    }
}
