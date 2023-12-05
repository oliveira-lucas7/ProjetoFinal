using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    public class Estado
    {
        [Column("Id")]
        [Display(Name = "Código do Estado")]
        public int Id { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "Nome do Estado")]
        public string EstadoNome { get; set; } = string.Empty;

        [ForeignKey("PaísId")]
        public int PaisId { get; set; }
        public Pais? Pais { get; set; }

    }
}
