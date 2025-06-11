# DB_TechStore
A comprehensive tech management store which includes customers, users and mangers each having its own access.

# Tech Store Management System

## Group Members
- Daniyal Haider (241947)  
- Abdul Moeed Raza Kazmi (241920)

## Project Description
This project is a Tech Store Management System designed as a Windows Forms desktop application using C# (.NET 8) and SQL Server. The system supports three user roles: Customer, Employee, and Manager. Core modules include user registration, product catalog, order placement, payments, and repair management.

The system implements a normalized database schema with 12 interrelated tables: Users, Customers, Employees, Managers, Products, Brands, Categories, Orders, OrderDetails, Payments, Repairs, and Branches.

## Setup Instructions

### Database Setup
1. Open **SQL Server Management Studio**.
2. Create a new database, e.g., `TechStoreDB`.
3. Run the provided SQL script (`CRUD Queries.sql`) to create tables and insert sample data.
4. Update the connection string in your C# application accordingly.

### Application Setup
1. Open the solution in **Visual Studio 2022 or later**.
2. Restore NuGet packages (if required).
3. Build and run the application.


