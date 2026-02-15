# tasks-manager
TaskManager.sln

TaskManager.Domain
│
├── Entities
|   ├── User.cs
|   ├── TaskItem.cs
|   └── TaskStatus.cs
|
└── Enums
    └── TaskStaus 


TaskManager.DAL
│
├── Context
│   └── DbConnectionFactory.cs
│
├── Interfaces
│   ├── IUserRepository.cs
│   ├── ITaskRepository.cs
│   └── ITaskStatusRepository.cs
│
└── Repositories
    ├── UserRepository.cs
    ├── TaskRepository.cs
    └── TaskStatusRepository.cs


TaskManager.BLL
│
├── Interfaces
│   ├── IAuthService.cs
│   └── ITaskService.cs
│
├── Services
│   ├── AuthService.cs
│   └── TaskService.cs
│
└── Security
    └── PasswordHasher.cs


TaskManager.UI
│
├── Forms
│   ├── LoginForm.cs
│   ├── MainForm.cs
│   └── TaskEditForm.cs
│
├── Program.cs
└── App.config
