using AutoMapper;
using MegaWeb.Shared.DTO.FuncaoDtos;
using MegaWeb.Shared.Models;

namespace MegaWeb.Shared.Map
{
    public class FuncaoDtoToFuncaoModel : Profile
    {
        public FuncaoDtoToFuncaoModel()
        {
            CreateMap<FuncaoDto, Funcao>().ReverseMap();
        }
    }
}