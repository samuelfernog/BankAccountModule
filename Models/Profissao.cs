using System.ComponentModel.DataAnnotations;

namespace BankAccountModule.Models
{
    public class Profissao
    {
        public string NomeProfissao { get; set; }

        [StringLength(7, MinimumLength = 7)]
        public string Codigo { get; set; }
    }
}
