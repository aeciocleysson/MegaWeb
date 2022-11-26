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
            Funcionario();
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

        private void Funcionario()
        {
            CreateMap<Funcionario, FuncionarioResponse>()
                .ForMember(x => x.SituacaoFuncionario, opts => opts.MapFrom(src => new SituacaoFuncionarioResponse
                {
                    Id = src.SituacaoFuncionarioId,
                    Descricao = src.SituacaoFuncionario.Descricao
                }))
                .ForMember(w => w.Funcao, opt => opt.MapFrom(sr => new FuncaoResponse
                {
                    Id = sr.FuncaoId,
                    Descricao = sr.Funcao.Descricao
                }));
        }
    }
}