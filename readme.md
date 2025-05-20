# Micronova 🚀

**Micronova** is a cutting-edge repository designed to leverage modern C# and .NET features. It proposes an architecture that embraces the **Behavior Pattern**, middleware for **global exception handling**, and integration with **Azure Key Vault** using an **isolated worker model**. This project also demonstrates how to inject **HttpClientFactory** for better HTTP request handling.

## Features 🌟

- **Behavior Pattern**: Implements the Behavior design pattern to promote cleaner, more maintainable code with reusable business logic components.
  
- **Global Exception Handling Middleware**: Centralizes exception handling across the application, making it easier to manage errors consistently.
  
- **Azure Key Vault Integration**: Safely stores and retrieves secrets using Azure Key Vault, ensuring sensitive data is managed securely.
  
- **Isolated Worker Model**: Uses the isolated worker model for better separation of concerns, ensuring services can be developed, deployed, and scaled independently.

- **HttpClientFactory Injection**: Demonstrates the best practice of using `HttpClientFactory` to efficiently manage HTTP requests, reducing the overhead of instantiating `HttpClient` objects repeatedly.

## Requirements 🔧

- .NET 6.0 or later
- Azure Subscription (for Azure Key Vault integration)
- Visual Studio or VS Code (for development)

## Installation 📥

1. Clone the repository:

   git clone https://github.com/yourusername/micronova.git
