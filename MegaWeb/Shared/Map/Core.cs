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
        }

        private void Funcao()
        {
            CreateMap<Funcao, FuncaoResponse>().ReverseMap();
            CreateMap<FuncaoRequest, Funcao>();
        }
    }
}