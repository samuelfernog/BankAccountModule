
using System.ComponentModel.DataAnnotations;
namespace BankAccountModule.Models
{
    public class Cliente
    {
    string Nome;

    [StringLength(11,MinimumLength=11)]
    string Cpf { get; set; }
    DateTime DataNascimento { get; set; }
    Profissao Profissao;
        
    }
}
