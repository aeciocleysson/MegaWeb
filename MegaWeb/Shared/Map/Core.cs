using AutoMapper;
using MegaWeb.Shared.Models;
using MegaWeb.Shared.Request;
using MegaWeb.Shared.Response;

namespace MegaWeb.Shared.Map
{
    public class Core : Profile
    {
        public Core()
        {
            Funcao();
            SituacaoFuncionario();
        }

        private void Funcao()
        {
            CreateMap<Funcao, FuncaoResponse>().ReverseMap();
            CreateMap<FuncaoRequest, Funcao>();
        }

        private void SituacaoFuncionario()
        {
            CreateMap<SituacaoFuncionario, SituacaoFuncionarioResponse>().ReverseMap();
        }
    }
}