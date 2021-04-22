using Bomp.Controllers;
using Xunit;

namespace LoadResourceTest.UnitTests.Controllers
{
  public class Tests
  {
    [Fact]
    public void GetRandomPokemonReturnsPokemon()
    {
      var controller = new PokemonController();
      var result = controller.GetRandomPokemon();
      Assert.NotNull(result);
    }
  }
}
