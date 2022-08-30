
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

    //controlador do cliente
CadastraCliente(string NomeEntrada, string CpfEntrada, DateTime DataEntrada, Profissao ProfissaoEntrada)
{
    Cliente clienteNovo = new Cliente();

    clienteNovo.Nome = NomeEntrada;
    clienteNovo.Cpf = CpfEntrada;
    clienteNovo.DateTime = DatacoEntrada;
    clienteNovo.Profissa = ProfissaoEntrada;

    CadastraClienteNoBanco(clienteNovo);
}
}