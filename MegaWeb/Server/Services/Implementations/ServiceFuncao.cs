using AutoMapper;
using MegaWeb.Server.Repository.Interfaces;
using MegaWeb.Server.Services.Interfaces;
using MegaWeb.Shared.DTO.FuncaoDtos;
using MegaWeb.Shared.Models;
using MegaWeb.Shared.Request;
using MegaWeb.Shared.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MegaWeb.Server.Services.Implementations
{
    public class ServiceFuncao : IServiceFuncao
    {
        private readonly IFuncaoRepository _repository;
        private readonly IMapper _mapper;

        public ServiceFuncao(IFuncaoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<FuncaoResponse> Add(FuncaoRequest entity)
        {
            var funcao = _mapper.Map<Funcao>(entity);
            await _repository.Add(funcao);

            var response = _mapper.Map<FuncaoResponse>(funcao);
            return response;
        }

        public async Task<List<FuncaoResponse>> GetAll()
        {
            var funcoes = await _repository.GetAll();
            var funcoesDto = _mapper.Map<List<FuncaoResponse>>(funcoes);

            return funcoesDto;
        }

        public async Task<FuncaoDto> GetById(int id)
        {
            var funcao = await _repository.GetById(id);
            var funcaoDto = _mapper.Map<FuncaoDto>(funcao);

            return funcaoDto;
        }

        public async Task<bool> Remove(int id)
        {
            await _repository.Remove(id);
            return true;
        }

        public async Task<FuncaoDtoUpdate> Update(FuncaoDtoUpdate entity)
        {
            var funcao = _mapper.Map<Funcao>(entity);
            await _repository.Update(funcao);

            return entity;
        }
    }
}