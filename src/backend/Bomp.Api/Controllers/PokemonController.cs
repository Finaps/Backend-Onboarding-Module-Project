using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Bomp.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bomp.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class PokemonController : ControllerBase
  {
    public PokemonController()
    {
    }

    private static JsonSerializerOptions jsonSettings = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true,
    };

    /// <Challenge>
    /// Currently this method always returns ditto instead of a random pokemon, change it so it does
    /// </Challenge>
    [HttpGet]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    public Pokemon GetRandomPokemon()
    {
      using (var httpClient = new HttpClient())
      {
        var response = httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/ditto").Result;
        var t = response.Content.ReadAsStringAsync().Result;
        var pokemon = JsonSerializer.Deserialize<Pokemon>(response.Content.ReadAsStringAsync().Result, jsonSettings);
        return pokemon;
      }
    }

    [HttpGet("{id}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    public Pokemon GetPokemonById(int id)
    {
      using (var httpClient = new HttpClient())
      {
        var response = httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}").Result;
        var pokemon = JsonSerializer.Deserialize<Pokemon>(response.Content.ReadAsStringAsync().Result, jsonSettings);
        return pokemon;
      }
    }
  }
}