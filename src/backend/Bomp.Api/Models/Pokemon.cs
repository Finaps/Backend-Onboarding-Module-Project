using System;

namespace Bomp.Api.Models
{
  /// <Challenge>
  /// Extend this model anyway you like
  /// You can for example store the German names, a list of moves or connected evolutions
  /// Look at the PokeApi (https://pokeapi.co/) for inspiration
  /// </Challenge>
  public class Pokemon
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}
