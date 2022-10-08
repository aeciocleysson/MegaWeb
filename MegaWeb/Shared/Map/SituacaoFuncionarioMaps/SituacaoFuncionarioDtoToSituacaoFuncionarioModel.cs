using AutoMapper;
using MegaWeb.Shared.DTO.SituacaoFuncionarioDtos;
using MegaWeb.Shared.Models;

namespace MegaWeb.Shared.Map.SituacaoFuncionarioMaps
{
    public class SituacaoFuncionarioDtoToSituacaoFuncionarioModel : Profile
    {
        public SituacaoFuncionarioDtoToSituacaoFuncionarioModel()
        {
            CreateMap<SituacaoFuncionarioDto, SituacaoFuncionario>().ReverseMap();
        }
    }
}