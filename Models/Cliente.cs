using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Código do cliente")]
        public int Id { get; set; }

        [Column("NomeCliente")]
        [Display(Name = "Digite o nome do cliente")]
        public string NomeCliente { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Digite a data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Column("CpfCliente")]
        [Display(Name = "Digite o Cpf do cliente")]
        public string CpfCliente { get; set; } = string.Empty;

        [Column("EnderecoCliente")]
        [Display(Name = "Digite o endereço do cliente")]
        public string EnderecoCliente { get; set; } = string.Empty;

        [Column("NumeroCasa")]
        [Display(Name = "Digite o número da casa")]
        public string NumeroCasa { get; set; } = string.Empty;

        [Column("BairroCliente")]
        [Display(Name = "Digite o bairro do cliente")]
        public string BairroCliente { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }

        [Column("TelefoneCliente")]
        [Display(Name = "Telefone do Cliente")]
        public string TelefoneCliente { get; set; } = string.Empty;

    }
}
