# 🚀 User Management API - ASP.NET Core

This project is a RESTful API for user management, developed as part of the final assignment for implementing APIs with the assistance of AI.

## 🛠️ Technologies Used
* **Language:** C#
* **Framework:** .NET 8.0 (ASP.NET Core)
* **AI Tools:** GitHub Copilot (for code generation and debugging)
* **Environment:** Linux

---

## 📋 Project Requirements (Evaluation Checklist)

### 1. GitHub Repository (5pts)
This project is hosted in a public repository for review and feedback.

### 2. CRUD Endpoints (5pts)
The API implements all essential operations:
* `GET /api/users`: Lists all users.
* `POST /api/users`: Creates a new user.
* `PUT /api/users/{id}`: Updates an existing user.
* `DELETE /api/users/{id}`: Removes a user.

### 3. Debugging with GitHub Copilot (5pts)
Copilot was essential for:
* **Bug Resolution:** Identifying a `NullReferenceException` in the `PUT` method logic.
* **Refactoring:** Suggesting the use of *LINQ* (`.FirstOrDefault`) to make user searching cleaner and more efficient.
* **Status Code Suggestions:** Copilot suggested using `CreatedAtAction` to correctly return the `201 Created` code in the POST method.

### 4. Data Validation (5pts)
Implemented via `DataAnnotations` in the `User.cs` model:
* **Name:** Required field with minimum length validation.
* **Email:** Format validation and required field.
* **Feedback:** Automatically returns `400 Bad Request` if the data is invalid.

### 5. Middleware (5pts)
A custom **Logging Middleware** (`Middlewares/LoggingMiddleware.cs`) was implemented to:
* Intercept all HTTP requests.
* Log the Method (GET/POST/etc.), Path, and Timestamp to the server console.

---

## 🚀 How to Run the Project (Linux)

1. **Ensure you have the .NET 8 SDK installed:**
   ```bash
   dotnet --version
