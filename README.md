# Bugaboo Shop – Full Stack Web Application

## 🛒 Overview  
This is a full-stack web application for managing a Bugaboo products shop, built with:

- 🌐 **Backend:** ASP.NET Core Web API using Layered Architecture and Dependency Injection (DI)  
- 🖥️ **Frontend:** Angular client application  
- 🗃️ **Database:** SQL Server  
- 📄 DB First approach – models are generated directly from the existing database  

---

## 🔧 Technologies Used

### Backend  
- C# with .NET 6 or later  
- Entity Framework Core  
- DB First (scaffold models from database)  
- Layered architecture:  
  - Controllers – API endpoints  
  - Services – Business logic  
  - Repositories – Data access  
- Built-in Dependency Injection (DI)  

### Frontend  
- Angular 15+  
- TypeScript  
- Angular Material (optional for styling)  

### Database  
- Microsoft SQL Server  
- EF Core using DB First workflow  

---

## 🗂 Project Structure

### Backend (/Server)  
```
/Controllers  
/Services  
/Repositories  
/Models (generated from DB)  
/Data  
Program.cs
```

### Frontend (/Client)  
```
/src/app  
/components  
/services  
/models  
app.module.ts  
main.ts  
angular.json
```

---

## 🚀 Getting Started

### Prerequisites  
- .NET SDK 6.0+  
- Node.js + Angular CLI  
- SQL Server instance  

### ⚙️ Backend Setup  
1. Navigate to the server project folder:  
   ```bash
   cd Server
   ```
2. Configure the connection string in `appsettings.json`:  
   ```json
   "ConnectionStrings": { 
     "DefaultConnection": "Server=localhost;Database=BugabboShopDb;Trusted_Connection=True;" 
   }
   ```
3. Scaffold models from the database:  
   ```bash
   dotnet ef dbcontext scaffold "Server=localhost;Database=BugabboShopDb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -f
   ```
4. Run the Web API:  
   ```bash
   dotnet run
   ```

### 🖥️ Frontend Setup (Angular)  
1. Navigate to the client project folder:  
   ```bash
   cd Client
   ```
2. Install dependencies:  
   ```bash
   npm install
   ```
3. Run the Angular application:  
   ```bash
   ng serve
   ```
4. Open in your browser: [http://localhost:4200](http://localhost:4200)  

---

## 📦 Features

- View list of Bugabbo products  
- Filter by category, price, name  
- SQL Server integration for data persistence  
- Clean and modular architecture  

---

## 🧪 Testing

- Backend: Unit testing with xUnit  
- Frontend: Jasmine / Karma test framework  

---

## 🤝 Contributing

Contributions are welcome! Feel free to open an Issue or submit a Pull Request.

---

## 📄 License

This project is licensed under the MIT License – free to use, modify, and distribute.

---

## 📬 Contact

For support or questions: tamar29455@gmail.com
