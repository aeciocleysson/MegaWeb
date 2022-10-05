using AutoMapper;
using MegaWeb.Shared.DTO;
using MegaWeb.Shared.Models;

namespace MegaWeb.Shared.Map
{
    public class FuncaoDtoToFuncaoModelUpdate : Profile
    {
        public FuncaoDtoToFuncaoModelUpdate()
        {
            CreateMap<FuncaoDtoUpdate, Funcao>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                 .ForMember(dest => dest.Descricao, opt => opt.MapFrom(x => x.Descricao))
                 .ForMember(dest => dest.UpdateAt, opt => opt.MapFrom(x => x.UpdateAt));
        }
    }
}