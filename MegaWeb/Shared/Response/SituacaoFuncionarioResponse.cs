using System.ComponentModel.DataAnnotations;

namespace MegaWeb.Shared.Response
{
    public class SituacaoFuncionarioResponse
    {
        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }
    }
}