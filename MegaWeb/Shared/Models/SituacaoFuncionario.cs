using System.Collections.Generic;

namespace MegaWeb.Shared.Models
{
    public class SituacaoFuncionario
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> Funcionario { get; set; } = new List<Funcionario>();
    }
}