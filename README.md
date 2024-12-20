# CharityHub

CharityHub is a project designed to demonstrate the Onion Architecture using C#. This project aims to provide a clear example of how to implement this architecture in a .NET application.

## Project Structure

The project is divided into several layers, each with its own responsibility:

- **CharityHub.API**: This layer contains the service registration and is responsible for configuring and running the application.
  - **Program.cs**: Configures services and the app's request pipeline.
  - **Services**: Registers application and infrastructure services.
  
- **CharityHub.Application**: This layer contains the application logic and use cases. It interacts with the domain layer to perform business operations.
  - **Interfaces**: Defines the interfaces for services and repositories.
  - **Services**: Contains the implementation of application services.
  - **DTOs**: Data Transfer Objects used to transfer data between layers.

- **CharityHub.Domain**: This is the core layer of the application. It contains the business logic and entities. This layer is independent of any other layer and should not depend on any external libraries.
  - **Entities**: Contains the business entities.
  - **Interfaces**: Defines the repository interfaces.

- **CharityHub.Infrastructure**: This layer contains the implementation of external dependencies, such as database access, file storage, and other services. It implements interfaces defined in the application and domain layers.
  - **Repositories**: Implements the repository interfaces defined in the domain layer.
  - **Data**: Contains the database context and migration files.

- **CharityHub.Presentation**: This layer contains the API controllers and is responsible for handling HTTP requests and responses.
  - **Controllers**: Contains the API controllers that handle incoming HTTP requests and map them to application services.
