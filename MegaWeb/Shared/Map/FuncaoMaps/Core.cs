using AutoMapper;
using MegaWeb.Shared.Models;
using MegaWeb.Shared.Response;

namespace MegaWeb.Shared.Map.FuncaoMaps
{
    public class Core : Profile
    {
        public Core()
        {
            Funcao();
        }

        private void Funcao()
        {
            CreateMap<Funcao, FuncaoResponse>();
        }
    }
}