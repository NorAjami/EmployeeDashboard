# 🧠👥 EmployeeDashboard

An internal system for employees to:

- 🧘‍♂️ View Quote of the Day
- 📝 Write Daily Logs
- ✅ Track Tasks
- 📢 Read Announcements

A professional, cloud-ready Employee Dashboard built with ASP.NET Core Razor Pages and MongoDB.  
This application is designed to help employees log their daily work activities in a clean and structured way.

---

## 📌 Features

- ✅ Create daily work logs via a simple form
- ✅ View recent logs in a clean, dark-themed dashboard
- ✅ Store data in MongoDB Atlas (cloud)
- ✅ Ready for GitHub Actions, Docker, and Azure deployment

---

## ⚙️ Technologies Used

- ASP.NET Core 8 (Razor Pages)
- MongoDB Atlas (Cloud Database)
- Git & GitHub
- Visual Studio Code
- GitHub Actions (CI/CD ready)
- Docker (optional containerization)
- Azure (optional deployment)

---

## 🗂 Project Structure

EmployeeDashboard/
│
├── Models/ # DailyLog model (MongoDB-friendly)
├── Services/ # MongoDB service layer
├── Pages/ # Razor Pages frontend
│
├── Shared/ # Layout and shared views
│
└── Index.cshtml # Main dashboard page
├── appsettings.json # Configuration incl. MongoDB
├── Program.cs # App entrypoint
└── README.md # Project overview

---

## 🚀 Getting Started

1. Clone the repository:

git clone https://github.com/NorAjami/EmployeeDashboard.git
cd EmployeeDashboard

2. Add your MongoDB connection string using secrets:
dotnet user-secrets init dotnet user-secrets set "MongoDB:ConnectionString" "<your-connection-string>"

3. Run the app:
dotnet run

4. Visit `http://localhost:xxxx` and log your day!

---

## 💡 Future Plans

- GitHub Actions integration
- Docker support
- Azure App Service deployment
- Authentication (optional)

---

## 📸 Screenshots

Coming soon...

---

Built with ❤️ by [NorAjami](https://github.com/NorAjami)