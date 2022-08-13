using System.ComponentModel.DataAnnotations;

namespace BankAccountModule.Models
{
    // Dados conta corrente
    class ContaCorrente
    {
        [StringLength(8, MinimumLength = 8)]
        int Numero { get; set; }

        [StringLength(4, MinimumLength = 4)]
        int Agencia { get; set; }

        double Saldo { get; set; }

        Cliente Titular;
    }
}
