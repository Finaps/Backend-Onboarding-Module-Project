using System;
using System.Linq;
using System.Threading.Tasks;
using PokeProj.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace PokeProj.Services
{
    public class GetPokemonService : IGetPokemonService
    {
        private readonly HttpClient httpClient;

        public GetPokemonService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Pokemon> GetRandomPokemon()
        {
            return await httpClient.GetFromJsonAsync<Pokemon>("pokemon/random");
        }

        public async Task<Pokemon> GetPokemonById(int id)
        {
            return await httpClient.GetFromJsonAsync<Pokemon>($"pokemon/{id}");
        }
    }
}