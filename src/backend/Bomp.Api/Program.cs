using Bomp.Infrastructure.Database;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Bomp.Api
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = CreateWebHost(args);
      host.Run();
    }

    public static IWebHost CreateWebHost(string[] args)
    {
      return WebHost
        .CreateDefaultBuilder(args)
        .UseStartup<Startup>()
        .Build();
    }
  }
}
