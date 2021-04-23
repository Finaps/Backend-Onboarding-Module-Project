using System;
using System.Linq;
using System.Threading.Tasks;
using PokeProj.Models;

namespace PokeProj.Services
{
    public interface IGetPokemonService
    {
        Task<Pokemon> GetRandomPokemon();
        Task<Pokemon> GetPokemonById(int id);
    }
}
