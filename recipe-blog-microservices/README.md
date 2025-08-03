# Recipe Blog Microservices

This project is a microservices-based application for managing recipes and blog posts. It consists of three main services: RecipeService, UserService, and BlogService. Each service is responsible for a specific domain and can be developed, deployed, and scaled independently.

## Services Overview

### RecipeService
- **Purpose**: Manages recipes.
- **Endpoints**:
  - `GET /recipes`: Retrieve all recipes.
  - `GET /recipes/{id}`: Retrieve a specific recipe by ID.
  - `POST /recipes`: Create a new recipe.
  - `PUT /recipes/{id}`: Update an existing recipe.
  - `DELETE /recipes/{id}`: Delete a recipe.

### UserService
- **Purpose**: Manages users.
- **Endpoints**:
  - `GET /users`: Retrieve all users.
  - `GET /users/{id}`: Retrieve a specific user by ID.
  - `POST /users`: Create a new user.
  - `PUT /users/{id}`: Update an existing user.
  - `DELETE /users/{id}`: Delete a user.

### BlogService
- **Purpose**: Manages blog posts.
- **Endpoints**:
  - `GET /blogposts`: Retrieve all blog posts.
  - `GET /blogposts/{id}`: Retrieve a specific blog post by ID.
  - `POST /blogposts`: Create a new blog post.
  - `PUT /blogposts/{id}`: Update an existing blog post.
  - `DELETE /blogposts/{id}`: Delete a blog post.

## Getting Started

### Prerequisites
- .NET SDK
- Docker and Docker Compose

### Setup Instructions

1. Clone the repository:
   ```
   git clone <repository-url>
   cd recipe-blog-microservices
   ```

2. Build and run the services using Docker Compose:
   ```
   docker-compose up --build
   ```

3. Access the services:
   - RecipeService: `http://localhost:5000`
   - UserService: `http://localhost:5001`
   - BlogService: `http://localhost:5002`

## Usage Guidelines

- Each service can be accessed independently via its respective endpoints.
- Ensure that the services are running before making requests.
- Use tools like Postman or curl to test the API endpoints.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for details.