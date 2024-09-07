using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AppFakeStore.Models;

namespace AppFakeStore.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly HttpClient _httpClient;

        public UsuarioService()
        {
            _httpClient = new HttpClient(); 
        }

        public async Task<List<Usuarios>> GetUsersAsync()
        {
            var usuarios = await _httpClient.GetFromJsonAsync<List<Usuarios>>("https://fakestoreapi.com/users");
            return usuarios;
        } 
    }
}