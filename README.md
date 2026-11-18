# BarangayInformationMonitoringSystem
A C# Windows Forms-based Barangay Information Monitoring System integrated with SQLite. Designed to help organize and manage resident records, including Senior Citizens and Persons with Disabilities (PWD), through a simple and user-friendly desktop application.
# Barangay Information Monitoring System

A desktop-based Barangay Information Monitoring System developed using **C# Windows Forms** and **SQLite Database**.

This application is designed to help organize and manage barangay resident information through a simple desktop interface.

## About the Project

The Barangay Information Monitoring System is a C# desktop application intended to provide an organized way of managing resident records and accessing important barangay information.

It uses SQLite as its database and Windows Forms for its graphical user interface.

## Technologies Used

- **Programming Language:** C#
- **Framework:** Windows Forms
- **Database:** SQLite
- **IDE:** Microsoft Visual Studio
- **Database Connectivity:** SQLite

## Project Structure

```text
BarangayInformationMonitoringSystem/
│
├── Forms/
│   ├── DbSqLite.cs
│   ├── frmAuthor.cs
│   ├── frmLogin.cs
│   ├── frmMain.cs
│   ├── frmPWDList.cs
│   ├── frmResidents.cs
│   └── frmSenior.cs
│
├── Resources/
│   └── Picture1.png
│
├── App.config
├── packages.config
└── Program.cs
```

## Main Components

| File | Description |
|---|---|
| DbSqLite.cs | SQLite database connection |
| frmLogin.cs | Login interface |
| frmMain.cs | Main application interface |
| frmResidents.cs | Resident management interface |
| frmPWDList.cs | Persons with Disabilities list interface |
| frmSenior.cs | Senior citizens list interface |
| frmAuthor.cs | Author information interface |
| Program.cs | Application entry point |

## Key Features

- User Login Interface
- Resident Information Management
- SQLite Database Connectivity
- Senior Citizens Records Interface
- PWD Records Interface
- Main Dashboard
- Author Information

*Note: Feature descriptions reflect the project structure. Actual implemented functionality may vary.*

## Installation and Setup

1. Clone or download this repository.
2. Open the solution file using Microsoft Visual Studio.
3. Restore the required NuGet packages.
4. Check the SQLite database connection configuration.
5. Build the solution.
6. Run the application.

## Database

This project uses SQLite for local database storage.

Database operations are managed through the `DbSqLite.cs` class.

## Project Status

**Development / Portfolio Project**

This project is intended for educational purposes and as part of a software development portfolio.

## Developer

**James Gerald Estrada**

Student Developer | C# Programmer

## License

This project is intended for educational and portfolio purposes. Please contact the developer before redistributing or using it commercially.
