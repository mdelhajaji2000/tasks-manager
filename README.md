# Task Manager

A robust, multi-tier desktop application for managing tasks and users, built with C# and .NET. This project follows a clean N-Tier architecture to ensure a strong separation of concerns, making the codebase scalable, testable, and easy to maintain.

## 🏗️ Architecture Overview

The solution (`TaskManager.sln`) is divided into four main layers:

* **UI (User Interface):** Contains the visual elements (Forms) and acts as the entry point of the application.
* **BLL (Business Logic Layer):** Handles the core business rules, services (`TaskService`, `AuthService`), and security operations like password hashing.
* **DAL (Data Access Layer):** Manages all database interactions using the Repository Pattern and a centralized `DbConnectionFactory`.
* **Domain:** The core of the application containing the central entities (`User`, `TaskItem`) and enumerations.

## 📂 Project Structure

```text
TaskManager.sln

├── TaskManager.Domain
│   ├── Entities
│   │   ├── User.cs
│   │   ├── TaskItem.cs
│   │   └── TaskStatus.cs
│   └── Enums
│       └── TaskStatus.cs 
│
├── TaskManager.DAL
│   ├── Context
│   │   └── DbConnectionFactory.cs
│   ├── Interfaces
│   │   ├── IUserRepository.cs
│   │   ├── ITaskRepository.cs
│   │   └── ITaskStatusRepository.cs
│   └── Repositories
│       ├── UserRepository.cs
│       ├── TaskRepository.cs
│       └── TaskStatusRepository.cs
│
├── TaskManager.BLL
│   ├── Interfaces
│   │   ├── IAuthService.cs
│   │   └── ITaskService.cs
│   ├── Services
│   │   ├── AuthService.cs
│   │   └── TaskService.cs
│   └── Security
│       └── PasswordHasher.cs
│
└── TaskManager.UI
    ├── Forms
    │   ├── LoginForm.cs
    │   ├── MainForm.cs
    │   └── TaskEditForm.cs
    ├── Program.cs
    └── App.config