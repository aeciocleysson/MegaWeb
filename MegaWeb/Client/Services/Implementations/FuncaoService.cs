using MegaWeb.Client.Services.Interfaces;
using MegaWeb.Shared.Map;
using MegaWeb.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MegaWeb.Client.Services.Implementations
{
    public class FuncaoService : IFuncaoService
    {
        private readonly HttpClient _httpClient;

        public FuncaoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<FuncaoDto>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<FuncaoDto>>("api/funcao");
        }

        public async Task Insert(FuncaoDto funcao)
        {
            await _httpClient.PostAsJsonAsync<FuncaoDto>("api/funcao", funcao);
        }
    }
}