-- 1. USERS
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Phone NVARCHAR(20),
    Role NVARCHAR(20) CHECK (Role IN ('Customer', 'Employee', 'Manager'))
);

-- 2. BRANCHES
CREATE TABLE Branches (
    BranchID INT PRIMARY KEY IDENTITY(1,1),
    Location NVARCHAR(100),
    OpenDate DATE
);

-- 3. CUSTOMERS
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT UNIQUE,
    Address NVARCHAR(200),
    JoinDate DATE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- 4. EMPLOYEES
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT UNIQUE,
    BranchID INT,
    Position NVARCHAR(50),
    HireDate DATE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (BranchID) REFERENCES Branches(BranchID)
);

-- 5. CATEGORIES
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(50)
);

-- 6. BRANDS
CREATE TABLE Brands (
    BrandID INT PRIMARY KEY IDENTITY(1,1),
    BrandName NVARCHAR(50)
);

-- 7. PRODUCTS
CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    BrandID INT,
    CategoryID INT,
    StockQty INT,
    Price DECIMAL(10,2),
    Description NVARCHAR(200),
    FOREIGN KEY (BrandID) REFERENCES Brands(BrandID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- 8. ORDERS
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    OrderDate DATE,
    TotalAmount DECIMAL(10,2),
    Status NVARCHAR(20),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- 9. ORDERDETAILS
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT,
    ProductID INT,
    Quantity INT,
    UnitPrice DECIMAL(10,2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- 10. REPAIRS
CREATE TABLE Repairs (
    RepairID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    Device NVARCHAR(100),
    Issue NVARCHAR(200),
    Cost DECIMAL(10,2),
    Status NVARCHAR(20),
    ReceivedDate DATE,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- 11. Payments
CREATE TABLE Payments (
	PaymentID INT PRIMARY KEY IDENTITY, 
	OrderID INT, Amount DECIMAL(10,2), 
	PaymentMethod NVARCHAR(50), 
	PaymentDate DATE, 
	FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);

-- 12. Managers
CREATE TABLE Managers (
    ManagerID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT UNIQUE,
    BranchID INT,
    JoinDate DATE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (BranchID) REFERENCES Branches(BranchID)
);


INSERT INTO Users (Name, Email, Phone, Role) VALUES
('Ahmed Raza', 'ahmedraza@example.com', '03001234567', 'Customer'),
('Ayesha Khan', 'ayeshakhan@example.com', '03111234567', 'Customer'),
('Usman Ali', 'usman.ali@example.com', '03211234567', 'Employee'),
('Fatima Noor', 'fatima.noor@example.com', '03321234567', 'Manager'),
('Bilal Tariq', 'bilal.tariq@example.com', '03451234567', 'Customer'),
('Maryam Zafar', 'maryam.zafar@example.com', '03561234567', 'Employee'),
('Hamza Sheikh', 'hamza.sheikh@example.com', '03021234567', 'Manager'),
('Iqra Javed', 'iqra.javed@example.com', '03031234567', 'Customer'),
('Hassan Abbas', 'hassan.abbas@example.com', '03041234567', 'Employee'),
('Zainab Rizvi', 'zainab.rizvi@example.com', '03051234567', 'Customer'),
('Fahad Mehmood', 'fahad.mehmood@example.com', '03061234567', 'Manager'),
('Rabia Ahmed', 'rabia.ahmed@example.com', '03071234567', 'Customer'),
('Umar Naveed', 'umar.naveed@example.com', '03081234567', 'Employee'),
('Mehwish Fatima', 'mehwish.fatima@example.com', '03091234567', 'Customer'),
('Imran Saeed', 'imran.saeed@example.com', '03101234567', 'Manager');

INSERT INTO Branches (Location, OpenDate) VALUES
('Karachi', '2012-04-15'),
('Lahore', '2015-06-10'),
('Islamabad', '2016-01-01'),
('Rawalpindi', '2013-09-22'),
('Faisalabad', '2018-07-30');

INSERT INTO Customers (UserID, Address, JoinDate) VALUES
(1, 'House 12, Street 5, DHA Karachi', '2021-01-10'),
(2, 'Flat 34, Block B, Model Town Lahore', '2022-03-15'),
(5, '123 Jinnah Road, Faisalabad', '2020-11-05'),
(8, 'Gulberg III, Lahore', '2021-08-12'),
(10, 'Satellite Town, Rawalpindi', '2023-02-14'),
(12, 'I-8/3, Islamabad', '2020-06-20'),
(14, 'Cantt Area, Multan', '2021-12-01');

INSERT INTO Employees (UserID, BranchID, Position, HireDate) VALUES
(3, 1, 'Sales Associate', '2020-02-15'),
(6, 2, 'Technician', '2021-09-01'),
(9, 3, 'Inventory Clerk', '2022-01-10'),
(13, 4, 'Cashier', '2019-07-23');

INSERT INTO Managers (UserID, BranchID, JoinDate) VALUES
(4, 1, '2018-01-01'),
(7, 2, '2019-05-12'),
(11, 3, '2020-06-14'),
(15, 4, '2022-08-19');

INSERT INTO Categories (CategoryName) VALUES
('Laptops'),
('Smartphones'),
('Accessories'),
('Tablets'),
('Printers');

INSERT INTO Brands (BrandName) VALUES
('Dell'),
('HP'),
('Lenovo'),
('Samsung'),
('Apple');

INSERT INTO Products (Name, BrandID, CategoryID, StockQty, Price, Description) VALUES
('XPS 13', 1, 1, 10, 220000.00, 'High-end Dell ultrabook.'),
('Pavilion 15', 2, 1, 15, 140000.00, 'Mid-range HP laptop.'),
('ThinkPad X1', 3, 1, 8, 210000.00, 'Business-grade Lenovo laptop.'),
('Galaxy S21', 4, 2, 25, 180000.00, 'Flagship Samsung smartphone.'),
('iPhone 13', 5, 2, 12, 240000.00, 'Apple smartphone with iOS.'),
('Magic Mouse', 5, 3, 30, 12000.00, 'Wireless mouse by Apple.'),
('Galaxy Tab S7', 4, 4, 9, 130000.00, 'Samsung Android tablet.'),
('DeskJet 2330', 2, 5, 5, 25000.00, 'HP all-in-one printer.'),
('AirPods Pro', 5, 3, 20, 45000.00, 'Apple wireless earbuds.'),
('Latitude 5420', 1, 1, 6, 190000.00, 'Dell business laptop.'),
('IdeaPad 3', 3, 1, 18, 125000.00, 'Lenovo budget laptop.'),
('Samsung M33', 4, 2, 40, 95000.00, 'Mid-range smartphone.'),
('Canon LBP6030', 2, 5, 7, 38000.00, 'Laser printer.'),
('HP Envy x360', 2, 1, 11, 165000.00, 'Convertible laptop.'),
('Redmi Note 12', 4, 2, 33, 75000.00, 'Affordable smartphone.');

INSERT INTO Orders (CustomerID, OrderDate, TotalAmount, Status) VALUES
(1, '2023-02-01', 220000.00, 'Delivered'),
(2, '2023-04-15', 180000.00, 'Pending'),
(5, '2022-12-22', 45000.00, 'Delivered'),
(6, '2023-06-18', 95000.00, 'Shipped'),
(3, '2023-08-10', 240000.00, 'Delivered'),
(3, '2023-11-01', 25000.00, 'Pending'),
(2, '2024-01-12', 165000.00, 'Delivered'),
(1, '2024-02-20', 12000.00, 'Delivered'),
(5, '2024-03-10', 125000.00, 'Shipped'),
(4, '2024-04-05', 190000.00, 'Delivered'),
(3, '2024-05-09', 75000.00, 'Pending'),
(6, '2024-06-01', 38000.00, 'Delivered');

INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice) VALUES
(11, 1, 1, 220000.00),
(12, 4, 1, 180000.00),
(13, 9, 1, 45000.00),
(14, 12, 1, 95000.00),
(15, 5, 1, 240000.00),
(16, 8, 1, 25000.00),
(17, 14, 1, 165000.00),
(18, 6, 1, 12000.00),
(19, 11, 1, 125000.00),
(8, 10, 1, 190000.00);

INSERT INTO Repairs (CustomerID, Device, Issue, Cost, Status, ReceivedDate) VALUES
(1, 'Laptop', 'Screen broken', 15000.00, 'Completed', '2023-01-15'),
(2, 'Smartphone', 'Battery issue', 6000.00, 'In Progress', '2023-03-01'),
(5, 'Tablet', 'Not turning on', 8000.00, 'Pending', '2023-06-20'),
(2, 'Printer', 'Software issue', 5000.00, 'Completed', '2023-08-11'),
(3, 'Laptop', 'Battery issue', 7000.00, 'Completed', '2023-09-25'),
(4, 'Smartphone', 'Screen broken', 9000.00, 'In Progress', '2023-11-30'),
(7, 'Tablet', 'Not turning on', 7500.00, 'Pending', '2024-01-19');

INSERT INTO Payments (OrderID, Amount, PaymentMethod, PaymentDate) VALUES
(11, 220000.00, 'Card', '2023-02-02'),
(12, 180000.00, 'Bank Transfer', '2023-04-16'),
(13, 45000.00, 'Cash', '2022-12-23'),
(14, 95000.00, 'Card', '2023-06-19'),
(15, 240000.00, 'Bank Transfer', '2023-08-11'),
(16, 25000.00, 'Cash', '2023-11-02'),
(17, 165000.00, 'Card', '2024-01-13'),
(18, 12000.00, 'Cash', '2024-02-21'),
(19, 125000.00, 'Bank Transfer', '2024-03-11'),
(8, 190000.00, 'Card', '2024-04-06'),
(9, 75000.00, 'Cash', '2024-05-10');


