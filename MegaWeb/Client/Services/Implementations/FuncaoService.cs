using MegaWeb.Client.Services.Interfaces;
using MegaWeb.Shared.Request;
using MegaWeb.Shared.Response;
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

        public async Task Delete(int id)
        {
            await _httpClient.DeleteAsync($"api/funcao/{id}");
        }

        public async Task<List<FuncaoResponse>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<FuncaoResponse>>("api/funcao");
        }

        public async Task<FuncaoResponse> GetById(int id)
        {
            return await _httpClient.GetFromJsonAsync<FuncaoResponse>($"api/funcao/{id}");
        }

        public async Task Insert(FuncaoRequest funcao)
        {
            await _httpClient.PostAsJsonAsync<FuncaoRequest>("api/funcao", funcao);
        }

        public async Task<FuncaoResponse> Update(FuncaoResponse funcao)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/funcao/", funcao);
            return response.Content.ReadFromJsonAsync<FuncaoResponse>().Result;
        }
    }
}