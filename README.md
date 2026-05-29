# VB.NET Login System

A simple VB.NET Windows Forms Login System that uses:

* CSV-based credential storage
* SHA-256 password hashing
* Role-based login
* Error logging
* MSTest unit testing

This project was developed as part of laboratory activities for Weeks 11–14.

---

# Features

## User Authentication

* Login system using username and password
* Role-based access (Admin/User)
* Invalid login detection

## Password Security

* Passwords are hashed using SHA-256
* Plain-text passwords are not stored
* Secure password verification

## CSV Credential Storage

* Uses `credentials.csv` instead of a database
* Simple and lightweight credential management

## Error Logging

* Runtime errors are automatically saved in:

```txt
error_log.txt
```

* Uses Try-Catch error handling

## Unit Testing

* MSTest integration
* Password hashing test
* Basic login validation tests

---

# Technologies Used

* VB.NET
* Windows Forms
* .NET 8.0 Windows
* MSTest
* SHA-256 Cryptography
* CSV File Handling

---

# Project Structure

```txt
LOGINSYSTEM/
│
├── Form1.vb
├── Form2.vb
├── Form3.vb
├── SecurityHelper.vb
├── Logger.vb
├── credentials.csv
├── error_log.txt
└── TestProject1/
```

---

# Installation Guide

## Requirements

* Windows 10 or higher
* Visual Studio 2022
* .NET 8.0 Windows

---

# How to Run

1. Download or clone the repository.
2. Open the solution in Visual Studio 2022.
3. Make sure `credentials.csv` exists in the project directory.
4. Build the solution.
5. Run the application.

---

# Default Login Example

```txt
Username: admin
Password: admin123
```

Note:
Passwords stored in `credentials.csv` are hashed.

---

# Sample credentials.csv Format

```csv
Username,Password,Role
admin,HASHED_PASSWORD_HERE,Admin
user,HASHED_PASSWORD_HERE,User
```

---

# Password Hashing

The project uses SHA-256 hashing to secure passwords.

Example:

```txt
admin123
```

becomes:

```txt
240be518fabd2724ddb6f04eebc...
```

---

# Error Logging

Errors are recorded inside:

```txt
error_log.txt
```

Example log:

```txt
5/28/2026 10:45 PM | ERROR | Could not find file 'credentials.csv'
```

---

# Unit Testing

The project includes MSTest unit tests.

Example test:

```vb
Assert.AreEqual(1, 1)
```

---

# Known Limitations

* Uses CSV instead of a database
* No account registration form
* Basic UI design only

---

# Future Improvements

* Add database support
* Add user registration
* Improve UI/UX
* Add password reset functionality
* Add input validation

---

# Author

Jenny Anne Dula
BSIT 2.1

---

# License

This project is for educational purposes only.
