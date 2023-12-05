using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class Pais
    {
        [Column("Id")]
        [Display(Name = "Código do País")]
        public int Id { get; set; }

        [Column("PaisNome")]
        [Display(Name = "Digite o nome do País")]
        public string PaisNome { get; set; } = string.Empty;
    }
}
