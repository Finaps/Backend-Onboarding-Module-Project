using Bomp.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Bomp.Infrastructure.Database
{
  public class PokemonContext : DbContext
  {
    private const string connnectionString = "Server=(localdb)\\mssqllocaldb;Database=PokemonContext;Trusted_Connection=True;";


    public PokemonContext(DbContextOptions<PokemonContext> options) : base(options)
    {
    }
        
    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connnectionString);
    }

    public DbSet<Pokemon> Pokemons { get; set; }
  }
}
