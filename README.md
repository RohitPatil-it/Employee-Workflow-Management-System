# 👨‍💼 Employee Workflow App

This is a simple ASP.NET MVC web application that helps manage employee records.  
The project includes login, employee listing, and add/edit functionality.

---

## ✅ Project Tasks & Features

### 1. 🔐 Login Page
- The user must enter a **username** and **password** to log in.
- Login details are verified from the **Users** table in the SQL Server database.
- If login is successful, the user is redirected to the employee list page.

---

### 2. 📃 Employee List Page
- After login, a list of all employees is displayed in a table format.
- The list includes:
  - Employee Name
  - Department
  - Date of Joining
- Each row has **Edit** and **Delete** buttons.
- A **Search Box** is provided to search employees by name.
- An **"Add New"** button allows the user to add a new employee.

---

### 3. ➕ Add/Edit Employee Page
- This form allows the user to add a new employee or edit existing details.
- The form includes the following fields:
  - **Name** – Text input
  - **Department** – Dropdown list
  - **Date of Joining** – Date picker
  - **Address** – Textarea box
  - **Gender** – Radio buttons (Male/Female)
  - **Hobbies** – Checkboxes (Reading, Swimming, Singing, etc.)
- When saved, the data is stored in the **Employees** table in SQL Server.
- If the form is opened with an employee ID, it loads existing data for editing.

---

### 4. 🗑️ Delete Function
- The **Delete** button removes an employee record from the database.
- A confirmation may be added before deleting (optional).

---

### 5. 📦 Database Tables

#### a) Users Table
Used for login authentication.

| Field     | Type        |
|-----------|-------------|
| UserID    | int (PK)    |
| Username  | varchar     |
| Password  | varchar     |

#### b) Employees Table
Stores all employee details.

| Field         | Type        |
|---------------|-------------|
| EmployeeID    | int (PK)    |
| Name          | varchar     |
| Department    | varchar     |
| DateOfJoining | date        |
| Address       | text        |
| Gender        | varchar     |
| Hobbies       | varchar     |

---

## 💻 Technologies Used
- **C# ASP.NET MVC (Web Forms)**
- **HTML/CSS**
- **SQL Server**
- **ADO.NET**
- **Visual Studio**

---

## 📚 Use of This Project
- Understand basic **login and authentication**
- Learn **CRUD operations** using ASP.NET MVC
- Practice using **forms**, **radio buttons**, **checkboxes**, and **dropdowns**
- Connect frontend to **SQL Server database** using ADO.NET

---

## 🙋‍♂️ Developed by
**Rohit Patil**  
GitHub: [github.com/RohitPatil-it](https://github.com/RohitPatil-it)

