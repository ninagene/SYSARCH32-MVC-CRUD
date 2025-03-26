# SYSARCH32 Midterm Project

## Project Overview
This project is a C# MVC-based CRUD application developed as part of the SYSARCH32 course midterm project. The application demonstrates fundamental CRUD operations, integrates Git for version control, and follows a structured Git workflow for collaborative development.

## Cloning and Running the Application

### Prerequisites
Ensure you have the following installed:
- [Visual Studio](https://visualstudio.microsoft.com/) (with .NET and ASP.NET Core support)
- [Git](https://git-scm.com/)
- SQL Server (or an alternative database, if required)

### Steps to Clone and Run
1. Open a terminal or VS Code terminal.
2. Clone the repository:
   ```sh
   git clone <repository_url>
   ```
3. Navigate into the project directory:
   ```sh
   cd <project_directory>
   ```
4. Open the project in Visual Studio and restore dependencies:
   ```sh
   dotnet restore
   ```
5. Configure the database connection string in `appsettings.json`.
6. Apply database migrations (if applicable):
   ```sh
   dotnet ef database update
   ```
7. Run the application:
   ```sh
   dotnet run
   ```
8. Open the browser and navigate to `https://localhost:<port>`.

## Git Workflow

### Branching Strategy
- The `main` branch is the stable version of the project.
- The `develop` branch is used for ongoing development.
- Feature branches (`feature/branch-name`) are used for new features.
- Bugfix branches (`bugfix/branch-name`) are used for fixing issues.

### Workflow Process
1. **Pull latest changes** from `main` before creating a new branch:
   ```sh
   git pull origin main
   ```
2. **Create a new branch** for your feature or fix:
   ```sh
   git checkout -b feature/new-feature
   ```
3. **Make changes and commit** them:
   ```sh
   git add .
   git commit -m "Added new feature"
   ```
4. **Push the branch** to the repository:
   ```sh
   git push origin feature/new-feature
   ```
5. **Create a Pull Request (PR)** from GitHub to merge changes into `develop`.
6. **Review the PR**, get approval, and merge it.
7. **Delete the merged branch** if it's no longer needed:
   ```sh
   git branch -d feature/new-feature
   git push origin --delete feature/new-feature
   ```
