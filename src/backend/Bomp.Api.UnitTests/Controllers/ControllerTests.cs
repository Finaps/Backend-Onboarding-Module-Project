using Bomp.Controllers;
using Xunit;

namespace LoadResourceTest.UnitTests.Controllers
{
  public class Tests
  {
    /// <Challenge>
    /// Currently this test only checks if it is not null, make sure it tests it returns a different pokemon each time
    /// </Challenge>
    [Fact]
    public void GetRandomPokemonReturnsPokemon()
    {
      var controller = new PokemonController();
      var result = controller.GetRandomPokemon();
      Assert.NotNull(result);
    }
  }
}
