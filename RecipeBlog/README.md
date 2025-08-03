# Recipe Blog

Welcome to the Recipe Blog project! This application allows users to upload and share their favorite food recipes in a blog format.

## Features

- **Recipe Management**: Users can create, view, and list recipes.
- **User-Friendly Interface**: A simple and intuitive design for easy navigation.
- **Responsive Design**: The application is designed to work on various devices.

## Project Structure

- **Controllers**: Contains the `RecipesController` which handles HTTP requests related to recipes.
- **Models**: Includes the `Recipe` class that defines the recipe data model.
- **Views**: Contains Razor views for displaying recipes, including:
  - `Index.cshtml`: Lists all recipes.
  - `Create.cshtml`: Form for creating a new recipe.
  - `Details.cshtml`: Displays details of a specific recipe.
- **Shared Views**: Contains layout files for consistent design across the application.
- **wwwroot**: Contains static files such as CSS for styling the application.
- **Configuration Files**: Includes `appsettings.json` for application settings, `Program.cs` for the entry point, and `Startup.cs` for configuring services and middleware.

## Getting Started

1. Clone the repository:
   ```
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```
   cd RecipeBlog
   ```

3. Restore the dependencies:
   ```
   dotnet restore
   ```

4. Run the application:
   ```
   dotnet run
   ```

5. Open your browser and navigate to `http://localhost:5000` to view the application.

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue for any suggestions or improvements.

## License

This project is licensed under the MIT License. See the LICENSE file for details.