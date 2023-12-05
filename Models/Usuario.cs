using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Código do Usuário")]
        public int Id { get; set; }

        [Column("NomeUsuario")]
        [Display(Name = "Digite o nome do usuário")]
        public string NomeUsuario { get; set; } = string.Empty;

        [Column("EmailUsuario")]
        [Display(Name = "Digite o email do usuário")]
        public string EmailUsuario { get; set; } = string.Empty;

        [Column("SenhaUsuario")]
        [Display(Name = "Digite a senha do usuário")]
        public string SenhaUsuario { get; set; } = string.Empty;
    }
}
