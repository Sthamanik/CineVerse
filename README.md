# 🎬 Cineverse

**Cineverse** is a comprehensive movie management system designed to track films, actors, and characters while providing deep analytics into box office performance. Built with modern web technologies, it offers a premium experience for movie database management.

![Cineverse Home](https://img.shields.io/badge/Status-Beta-purple)
![.NET 9](https://img.shields.io/badge/.NET-9.0-blue)
![SQLite](https://img.shields.io/badge/Database-SQLite-lightgrey)

---

## 🚀 Features

### 🎞️ Movie Library
Manage a complete collection of films with detailed financial and production data:
- Track Budgets & Box Office Gross.
- MPAA Ratings (PG-13, R, etc.).
- Runtime and Genre categorization.
- Comprehensive summaries for every title.

### 🎭 Actor Profiles
Maintain detailed biographies for industry talent:
- Birth details (Date, City, Country).
- Physical statistics (Height).
- Net Worth tracking.
- Gender and personal biographies.

### 🎭 Character Mapping
Link actors to movies through specific roles:
- Track specific "Pay" for each role.
- Monitor on-screen time for characters.
- Link multiple actors to a single movie through their unique roles.

### 📊 Analytics Dashboard
Gain insights into your database performance:
- **Top Earners**: Identify the highest-paid actor roles.
- **Financial Performance**: Automatic calculation of "Flop" movies (Budget vs. Gross).
- **Stat Summaries**: Instant view of total movies, actors, and character counts.

---

## 🛠️ Tech Stack

- **Framework**: ASP.NET Core MVC (Targeting .NET 9.0)
- **Database**: SQLite (Local development convenience)
- **ORM**: Entity Framework Core
- **Authentication**: ASP.NET Core Identity
- **Styling**: Vanilla CSS with a custom design system ("CineDesign"):
  - **Typography**: [Outfit](https://fonts.google.com/specimen/Outfit) (Google Fonts)
  - **Color Palette**: Soft Purple (`#8d74cd`) and Deep Carbon (`#1a1a1a`)
  - **UI/UX**: Glassmorphism, card-based layouts, and responsive components.

---

## ⚙️ Getting Started

### Prerequisites
- [.NET SDK 9.0](https://dotnet.microsoft.com/download/dotnet/9.0)
- [sqlite3](https://www.sqlite.org/download.html) (Optional, for manual DB inspections)

### Installation & Setup

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd Cineverse
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Database initialization**
   The project uses Entity Framework Migrations. Apply them to create your local SQLite database:
   ```bash
   dotnet ef database update
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```
   Access the portal at `http://localhost:5000` (or the port specified in your console).

---

## 📁 Project Structure

- `Controllers/`: Implementation of business logic and routing.
- `Models/`: Data structures and EF Core entities.
- `Views/`: Razor templates for the premium UI.
- `Data/`: Database context and migrations.
- `wwwroot/`: Static assets (Modern CSS and JS).

---

## 🤝 Contributing

We welcome contributions to Cineverse! Whether it's a bug fix or a new feature, feel free to submit a Pull Request.

---

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.
