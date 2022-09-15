using AutoMapper;
using MegaWeb.Shared.Map;
using MegaWeb.Shared.Models;

namespace MegaWeb.Shared.DTO
{
    public class FuncaoProfile : Profile
    {
        public FuncaoProfile()
        {
            CreateMap<FuncaoDto, Funcao>().ReverseMap();
        }
    }
}