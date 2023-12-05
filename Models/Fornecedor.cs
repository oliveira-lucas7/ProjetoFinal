using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class Fornecedor
    {
        [Column("Id")]
        [Display(Name = "Código do Fornecedor")]
        public int Id { get; set; }

        [Column("NomeFornecedor")]
        [Display(Name = "Digite o nome do Fornecedor")]
        public string NomeFornecedor { get; set; } = string.Empty;

        [Column("EmailFornecedor")]
        [Display(Name = "Digite o email do Fornecedor")]
        public string EmailFornecedor { get; set; } = string.Empty;

        [Column("CnpjFornecedor")]
        [Display(Name = "Digite o CNPJ do Fornecedor")]
        public string CnpjFornecedor { get; set; } = string.Empty;
    }
}
