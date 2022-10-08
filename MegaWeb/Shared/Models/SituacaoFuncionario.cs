using System.Collections.Generic;

namespace MegaWeb.Shared.Models
{
    public class SituacaoFuncionario : BaseModel
    {
        public string Descricao { get; set; }
        public List<Funcionario> Funcionario { get; set; } = new List<Funcionario>();
    }
}