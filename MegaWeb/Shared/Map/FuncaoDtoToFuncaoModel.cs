using AutoMapper;
using MegaWeb.Shared.Models;

namespace MegaWeb.Shared.Map
{
    public class FuncaoDtoToFuncaoModel : Profile
    {
        public FuncaoDtoToFuncaoModel()
        {
            CreateMap<FuncaoDto, Funcao>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(x => x.Descricao));
        }
    }
}