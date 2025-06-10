# WindowsFormsApp1

## 📑 Table of Contents
- [Overview](#-overview)
- [Features](#-features)
- [Technologies Used](#-technologies-used)
- [Installation](#-installation)
- [Usage](#-usage)
- [Examples](#-examples)
- [Project Structure](#-project-structure)
- [License](#-license)

---

## 📝 Overview

**WindowsFormsApp1** is a Windows Forms application for managing and interacting with a relational database in an enterprise or manufacturing context. The app provides a user-friendly interface for CRUD operations (Create, Read, Update, Delete) on entities such as Enterprises, Workshops, Areas, Brigades, Workers, Product Categories, Product Types, Product Attributes, Workcycles, and Testing Products.

---

## 🚀 Features

- **Entity Management:** Add, edit, delete, and search for Enterprises, Workshops, Areas, Brigades, Workers, Product Categories, Product Types, Product Attributes, Workcycles, and Testing Products.
- **Search & Filtering:** Quick search panels for filtering records.
- **Data Visualization:** DataGridView controls for tabular data display.
- **Dialog Forms:** Modal forms for inserting, updating, and deleting records.
- **Database Integration:** Centralized database logic for all entities.
- **Modern UI:** Organized panels, menus, and table layouts for a clean user experience.

---

## 🛠 Technologies Used

- .NET Framework 4.8
- C#
- Windows Forms (WinForms)
- ADO.NET (for database access)
- Visual Studio (recommended IDE)

---

## ⚙️ Installation

1. **Clone the repository:**
   ```sh
   git clone <your-repo-url>
   ```
2. **Open the solution:**
   - Open `WindowsFormsApp1.sln` in Visual Studio.
3. **Restore NuGet packages:**
   - Visual Studio will prompt you to restore any missing packages.
4. **Configure the database connection:**
   - Edit `WindowsFormsApp1/App.config` to set your database connection string.
5. **Build the project:**
   - Press `Ctrl+Shift+B` or use the Build menu.
6. **Run the application:**
   - Press `F5` or click "Start".

---

## ▶️ Usage

- **Main Menu:** Use the main menu to navigate between different entity management forms.
- **CRUD Operations:** Each entity has dedicated forms for adding, editing, and deleting records.
- **Search:** Use the search box at the top of each main form to filter records.
- **Data Entry:** Use modal forms to input or update entity data.

---

## 💡 Examples

- **Add a new Worker:**
  1. Open the "Workers" section from the main menu.
  2. Click "Insert".
  3. Fill in the worker details and submit.

- **Delete a Product Type:**
  1. Open the "Product Types" section.
  2. Click "Delete".
  3. Enter the ID and confirm deletion.

- **Search for an Enterprise:**
  1. Open the "Enterprises" section.
  2. Use the search box to filter by name or ID.

---

## 📁 Project Structure

```
WindowsFormsApp1/
│   App.config
│   WindowsFormsApp1.sln
│
├── WindowsFormsApp1/
│   ├── DataBase.cs
│   ├── FormArea.cs
│   ├── FormBrigade.cs
│   ├── FormEnterprise.cs
│   ├── FormProductCategory.cs
│   ├── FormProductType.cs
│   ├── FormProductAttributes.cs
│   ├── FormWorkcycle.cs
│   ├── FormTestingProduct.cs
│   ├── FormWorkers.cs
│   ├── ... (other forms and designer files)
│
└── README.md
```

---

## 📜 License

This project is for educational and demonstration purposes. Please refer to the repository for license details.

---

> **Note:**  
> Make sure your database is set up and accessible as per the connection string in `App.config`.  
> For further customization or troubleshooting, refer to the code comments and documentation within each form.
