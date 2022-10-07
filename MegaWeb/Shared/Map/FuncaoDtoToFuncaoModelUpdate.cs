using AutoMapper;
using MegaWeb.Shared.DTO;
using MegaWeb.Shared.Models;

namespace MegaWeb.Shared.Map
{
    public class FuncaoDtoToFuncaoModelUpdate : Profile
    {
        public FuncaoDtoToFuncaoModelUpdate()
        {
            CreateMap<FuncaoDtoUpdate, Funcao>().ReverseMap();
        }
    }
}