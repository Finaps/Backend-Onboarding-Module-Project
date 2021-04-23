using Bomp.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Bomp.Infrastructure.Database
{
  public class PokemonContext : DbContext
  {
    public DbSet<Pokemon> Pokemons { get; set; }
    public PokemonContext(DbContextOptions<PokemonContext> options) : base(options)
    {
    }
  }
}