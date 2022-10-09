using AutoMapper;
using MegaWeb.Server.Repository.Interfaces;
using MegaWeb.Server.Services.Interfaces;
using MegaWeb.Shared.DTO.StatusDtos;
using MegaWeb.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MegaWeb.Server.Services.Implementations
{
    public class ServiceStatusLancamentoPonto : IServiceStatusLancamentoPonto
    {
        private readonly IStatusLancamentoPontoRepository _repository;
        private readonly IMapper _mapper;

        public ServiceStatusLancamentoPonto(IStatusLancamentoPontoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<StatusLancamentoPontoDto> Add(StatusLancamentoPontoDto entity)
        {
            var statusDto = _mapper.Map<StatusLancamentoPonto>(entity);
             await _repository.Add(statusDto);

            return entity;
        }

        public async Task<List<StatusLancamentoPontoDto>> GetAll()
        {
            var status = await _repository.GetAll();
            var statusDto = _mapper.Map<List<StatusLancamentoPontoDto>>(status);

            return statusDto;
        }
    }
}