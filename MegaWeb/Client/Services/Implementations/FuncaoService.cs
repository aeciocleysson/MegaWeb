using MegaWeb.Client.Services.Interfaces;
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

        public async Task<List<Funcao>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<Funcao>>("api/funcao");
        }

        public async Task Insert(Funcao funcao)
        {
            await _httpClient.PostAsJsonAsync<Funcao>("api/funcao", funcao);
        }
    }
}