CREATE DATABASE EmployeeDB;
USE EmployeeDB;

-- Create Employees table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    Department VARCHAR(50)
);

-- Create Departments table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY IDENTITY(1,1),
    DepartmentName VARCHAR(100)
);

-- Create Attendance table
CREATE TABLE Attendance (
    AttendanceID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT,
    AttendanceDate DATE,
    Status VARCHAR(10),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Create Performance table
CREATE TABLE Performance (
    PerformanceID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT,
    Rating INT,
    ReviewDate DATE,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Sample Data
INSERT INTO Employees (FirstName, LastName, Email, Department)
VALUES ('John', 'Doe', 'john.doe@example.com', 'HR'),
       ('Jane', 'Smith', 'jane.smith@example.com', 'IT');

INSERT INTO Departments (DepartmentName)
VALUES ('HR'), ('IT'), ('Finance');
