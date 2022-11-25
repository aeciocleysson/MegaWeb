using System;

namespace MegaWeb.Shared.Response
{
    public class FuncionarioResponse
    {
        public string Nome { get; set; }
        public long Matricula { get; set; }
        public DateTime DataNascimento { get; set; }
        public int SituacaoFuncionarioId { get; set; }
        public int FuncaoId { get; set; }
        public FuncaoResponse Funcao { get; set; }
        public SituacaoFuncionarioResponse SituacaoFuncionario { get; set; }
    }
}