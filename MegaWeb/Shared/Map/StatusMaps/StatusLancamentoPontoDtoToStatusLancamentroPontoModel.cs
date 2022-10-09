using AutoMapper;
using MegaWeb.Shared.DTO.StatusDtos;
using MegaWeb.Shared.Models;

namespace MegaWeb.Shared.Map.StatusMaps
{
    public class StatusLancamentoPontoDtoToStatusLancamentroPontoModel : Profile
    {
        public StatusLancamentoPontoDtoToStatusLancamentroPontoModel()
        {
            CreateMap<StatusLancamentoPontoDto, StatusLancamentoPonto>().ReverseMap();
        }
    }
}