# 🧠 EmployeeDashboard

A clean, cloud-ready internal system for employees to:

- ✨ View Quote of the Day
- 📝 Write Daily Logs
- ✅ Track Tasks
- 📢 Read Announcements

Built with **ASP.NET Core Razor Pages** and **MongoDB Atlas**, this dashboard helps employees reflect, stay organized, and keep track of important updates.

---

## 🔧 Tech Stack

- ASP.NET Core 8 (Razor Pages)
- MongoDB Atlas (Cloud NoSQL)
- GitHub & GitHub Actions
- Docker (optional)
- Azure App Service (planned)

---

## 📁 Project Structure

```
EmployeeDashboard/
├── Models/
├── Services/
├── Pages/
├── wwwroot/
├── appsettings.json
├── Program.cs
└── README.md
```

---

## 🚀 Getting Started

1. **Clone the repository:**

```bash
git clone https://github.com/NorAjami/EmployeeDashboard.git
cd EmployeeDashboard
```

2. **Add your MongoDB connection string as a secret:**

```bash
dotnet user-secrets init
dotnet user-secrets set "MongoDB:ConnectionString" "<your-connection-string>"
```

3. **Run the project locally:**

```bash
dotnet run
```

4. **Open in browser:**

```
http://localhost:xxxx
```

---

## ✅ Features Implemented

- Create and store daily work logs
- View daily logs on a dashboard
- Quotes of the day
- Responsive UI using Razor Pages
- MongoDB Atlas integration for persistent data
- Dark mode design

---

## 🔮 Roadmap

- Add task tracking module
- Add announcement creation/editing for admins
- Implement authentication and user roles
- Add GitHub Actions CI/CD pipeline
- Deploy to Azure App Service
- Add Docker support for containerization

---

## 📸 Screenshots

*Add your screenshots in a ****`/screenshots`**** folder and reference them here.*

---

## 👩‍💻 Author

Made with ❤️ by [@NorAjami](https://github.com/NorAjami)

---

## 💡 Tips

- Use `dotnet user-secrets list` to confirm your secret is set.
- MongoDB Atlas requires a cluster, user, and IP whitelist.
- When deploying, secrets should be added to GitHub or Azure environment variables.

