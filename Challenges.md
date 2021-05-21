# Challenges for the Backend Onboarding Module Project

## Extend the usage of the PokeApi

- Extend the Pokemon Model to also store for example its weight, 4 moves it can learn or the places it can be caught.
- Extend the Pokemon Model to also store each Pokemons evolutions, adding a reference to each Pokemons previous and next evolution.
- Extend it whichever way you like, look on the [PokeAPI](https://pokeapi.co/) for inspiration.
- If you use an external login (such as facebook) could you use user data to improve the experience?
  - For example, find pokemon with matching birthdays?

## Security

- How about adding authentication? [docs](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/?view=aspnetcore-5.0) [example](https://dotnetcorecentral.com/blog/authentication-handler-in-asp-net-core/)
- Could be fun to try an external login, such as Facebook/Google/Twitter etc.
- Can you restrict certain controllers?
- Can you make certain controllers not require authentication?
- How about enabling or disabling CORS?
- Is the database secured? [docs](https://docs.microsoft.com/en-us/aspnet/core/security/authorization/secure-data?view=aspnetcore-5.0)

## Testing

- Improve the tests so that each method has at least a single unit test, preferrably more than just the happy flow.
- Try to implement a mock for the Pokemon API.
- Can you workout how much code coverage your tests are achieving? 
  - Maybe [Coverlet](https://github.com/coverlet-coverage/coverlet) would help?
- Can you ensure all your injected dependecies resolve correctly?
- Can we validate the OpenAPI? 
  - Maybe something like [Dredd](https://dredd.org/en/latest/) could help us?
- Experiement with possible testing tools [list](https://github.com/dariusz-wozniak/List-of-Testing-Tools-and-Frameworks-for-.NET/blob/master/README.md)

## Database and Docker

- Make sure that each retrieved Pokemon also gets stored in our own Database
- Instead of using an in memory database, make it so it uses a seperate Database
- Run this seperate Database via Docker
- Experiement with a different database provider [providers](https://docs.microsoft.com/en-us/ef/core/providers/?tabs=dotnet-core-cli)
  - Alternatively try switching to a different ORM.

## Dependency Injection

- Use Dependency Injection to ensure we use only one Httpclient for the entire controller, instead of one for each request.

## Defensive programming

- The program should always report information to the user about what went wrong, and should only support actions that it can handle. Try to improve the projects error handling, propagation and prevention so it never breaks.

## Documentation

- Are you able to document your data models? 

## Misc

- Could we make our service performance actions in the background?
  - Maybe a daily fetch of pokemone with birthdays, that day?
- What other NuGets could enhance our service?
