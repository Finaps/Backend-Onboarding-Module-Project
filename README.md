# Backend Onboarding Module Project

This repository contains the basic setup for the Backend Onboarding Module Project
During onboarding, the new collegue will fork and extend this project to learn new skills and become familiar with the project setup.
On resolution the Mentor(s) can look at the forked project together and discuss to learn even more.

Challenges are scattered troughout the codebase which can form inspiration for extending functionality.
The Challenges.md file contains more general challenges that apply to a wider part of the codebase.

## Getting started
- Fork or Clone the project from the [Github](https://github.com/Finaps/Backend-Onboarding-Module-Project)
- Use 
```bash
  dotnet run
``` 
in the root folder of both the backend and frontend to start the services.

## Feedback, Questions and Support

If you have any feedback, questions or need support, please reach out to us at simon.martyr@finaps.nl or sander.meester@finaps.nl.



## Common issues

If you try to run it but run into the following error message:

```bash
The SSL connection could not be established ...
```
or
```bash
The remote certificate is invalid ....
```

try to run 

```bash
dotnet dev-certs https --clean
dotnet dev-certs https --trust
```

This renews the developer certificate for your dotnet environment

