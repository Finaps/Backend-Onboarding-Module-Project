# Challenges for the Backend Onboarding Module Project

### Extend the usage of the PokeApi
- Extend the Pokemon Model to also store for example its weight, 4 moves it can learn or the places it can be caught.
- Extend the Pokemon Model to also store each Pokemons evolutions, adding a reference to each Pokemons previous and next evolution.
- Extend it whichever way you like, look on the [PokeAPI](https://pokeapi.co/) for inspiration.

### Testing
- Improve the tests so that each method has at least a single unit test, preferrably more than just the happy flow.

### Database and Docker
- Make sure that each retrieved Pokemon also gets stored in our own Database
- Instead of using an in memory database, make it so it uses a seperate Database
- Run this seperate Database via Docker

### Dependency Injection
- Use Dependency Injection to ensure we use only one Httpclient for the entire controller, instead of one for each request.

### Defensive programming
- The program should always report information to the user about what went wrong, and should only support actions that it can handle. Try to improve the projects error handling, propagation and prevention so it never breaks.