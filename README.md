# Solmile Guest House Management System

A comprehensive guest house management system built with C# .NET, featuring a Windows Forms UI application and a RESTful API backend.

## Project Structure

The solution consists of three main projects:

### 1. SGH_API (Backend)
A .NET Web API project that serves as the backend service for the guest house management system. Key components include:
- Controllers for handling HTTP requests
- Repository pattern implementation for data access
- DTO models for data transfer
- Database migrations and data context
- Helper utilities and interfaces
- Printing functionality
- Asset management

### 2. SolmileGuestHouseUI (Frontend)
A Windows Forms application that provides the user interface for the guest house management system. Features include:
- Forms-based user interface
- Service layer for API communication
- Interface definitions
- Asset management
- Resource handling

### 3. SharedModel
A shared library containing common models and DTOs used across both the API and UI projects.

## Technology Stack

- **Backend**: .NET Web API
- **Frontend**: Windows Forms
- **Database**: Entity Framework Core with migrations
- **Architecture**: Repository pattern with dependency injection

## Project Features

- Guest house management functionality
- Asset tracking and management
- Printing capabilities
- Data transfer using DTOs
- Repository-based data access
- Interface-based service implementation

## Getting Started

### Prerequisites
- Visual Studio 2022 or later
- .NET SDK
- SQL Server (for database)

### Setup
1. Clone the repository
2. Open the solution in Visual Studio
3. Restore NuGet packages
4. Update the connection string in `appsettings.json`
5. Run database migrations
6. Build and run the solution

## Development

The project follows a clean architecture approach with:
- Clear separation of concerns
- Repository pattern for data access
- Interface-based design
- DTO pattern for data transfer
- Helper utilities for common operations

## License

This project is licensed under the terms included in the LICENSE file.

## Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request 