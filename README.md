# 📄 Document Management System (DMS)

A simple and secure web application to upload, manage, and share documents online.

## 🛠 Technologies Used

- **Backend**: ASP.NET Core Web API (C#)
- **Frontend**: React JS
- **Database**: SQL Server
- **Authentication**: JWT Token
- **IDE**:
  - Visual Studio (for backend)
  - Visual Studio Code (for frontend)

---

## 📁 Project Structure

### Backend (ASP.NET Core Web API)

- Located in the `DMS` folder (solution name)
- Contains folders for:
  - Controllers
  - Models
  - DTOs
  - Services
  - Data
  - Middleware

### Frontend (React)

- Created in a separate folder (outside of Visual Studio)
- Developed using React + Axios to call backend APIs

---

## 🔧 How to Run

### Backend

1. Open the solution in **Visual Studio**.
2. Update your connection string in:
   - `appsettings.Development.json` (your local settings)
3. Run the project using IIS Express or `dotnet run`.

### Frontend

1. Open frontend folder in **VS Code**.
2. Run the following:
   ```bash
   npm install
   npm run dev


### Showing Error “This file came from another computer and might be blocked”
Right-click each project folder (DMS.API, DMS.Service, DMS.DAL, etc.).
Go to Properties.
At the bottom, if you see a checkbox or button saying:
“This file came from another computer and might be blocked to help protect this computer”.
Go to Advance.
Click on "Unblock" or check the box and click Apply.
Repeat this for every main folder in the solution.
