using AutoMapper;
using MegaWeb.Shared.Models;

namespace MegaWeb.Shared.Map
{
    public class FuncaoModelToFuncaoDto : Profile
    {
        public FuncaoModelToFuncaoDto()
        {
            CreateMap<Funcao, FuncaoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(x => x.Descricao))
                .ForMember(dest => dest.Inserted, opt => opt.MapFrom(x => x.Inserted));
        }
    }
}