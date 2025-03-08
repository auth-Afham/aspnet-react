# ASP.NET + React Project

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Project Structure](#project-structure)
- [Installation](#installation)
- [Usage](#usage)
- [Running Tests](#running-tests)
- [Deployment](#deployment)
- [Contributing](#contributing)
- [License](#license)

## Introduction

This project is a full-stack web application that integrates an ASP.NET Core backend with a React frontend. The backend provides a RESTful API, while the frontend consumes the API to display and interact with data.

## Features

- User management via ASP.NET Core API
- Frontend built with React and Redux
- RESTful API for data operations
- PostgreSQL database integration
- State management using Redux

## Project Structure

```
aspnet-react/
├── my-frontend/             # React frontend application
│   ├── public/             # Static assets
│   ├── src/                # Source code
│   │   ├── components/     # React components
│   │   ├── redux/          # Redux store & reducers
│   │   ├── App.js          # Main App component
│   │   ├── index.js        # Entry point
├── MyAspNetReactApp/       # ASP.NET Core backend
│   ├── Controllers/        # API Controllers
│   ├── Models/             # Data models and DbContext
│   ├── Properties/         # Project properties
│   ├── appsettings.json    # Application configuration
│   ├── Program.cs         # Main application entry point
```

## Installation

### Prerequisites

- .NET 6.0 or later
- Node.js and npm/yarn
- PostgreSQL

### Backend Setup

1. Navigate to the backend directory:
   ```sh
   cd MyAspNetReactApp
   ```
2. Install dependencies and setup the database:
   ```sh
   dotnet restore
   dotnet ef database update
   ```
3. Run the backend:
   ```sh
   dotnet run
   ```

### Frontend Setup

1. Navigate to the frontend directory:
   ```sh
   cd my-frontend
   ```
2. Install dependencies:
   ```sh
   npm install
   ```
3. Start the frontend:
   ```sh
   npm start
   ```

## Usage

Once both the backend and frontend are running, you can access the application at:

- **Backend API**: `http://localhost:5000`
- **Frontend**: `http://localhost:3000`

## Running Tests

### Backend Tests

Run the following command in the `MyAspNetReactApp` directory:
```sh
   dotnet test
```

### Frontend Tests

Run the following command in the `my-frontend` directory:
```sh
   npm test
```

## Deployment

To deploy the backend, use:
```sh
   dotnet publish -c Release
```
For frontend deployment, build the project:
```sh
   npm run build
```

## Contributing

Contributions are welcome! Please submit issues or pull requests to improve the project.

## License

This project is licensed under the MIT License.

