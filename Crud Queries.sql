
SELECT m.ManagerID, u.Name, u.Email, b.Location AS BranchLocation, m.JoinDate
FROM Managers m
JOIN Users u ON m.UserID = u.UserID
JOIN Branches b ON m.BranchID = b.BranchID;

-- MANAGER QUERIES
SELECT UserID, Name, Email, Phone
FROM Users
WHERE Role = 'Manager';

DELETE FROM Users
WHERE UserID = 4 AND Role = 'Manager';

-- BRANCH QUERIES

INSERT INTO Branches (Location, OpenDate)
VALUES ('Lahore', '2024-06-01');

SELECT * FROM Branches;

UPDATE Branches
SET Location = 'Karachi'
WHERE BranchID = 1;

DELETE FROM Branches
WHERE BranchID = 2;

-- PRODUCT QUERIES
SELECT p.ProductID, p.Name AS ProductName, b.BrandName, c.CategoryName, p.StockQty, p.Price
FROM Products p
JOIN Brands b ON p.BrandID = b.BrandID
JOIN Categories c ON p.CategoryID = c.CategoryID;

UPDATE Products
SET StockQty = StockQty - 1
WHERE ProductID = 1;

DELETE FROM Products
WHERE ProductID = 1;

-- REPAIR QUERIES

SELECT r.RepairID, u.Name AS CustomerName, r.Device, r.Issue, r.Status, r.Cost
FROM Repairs r
JOIN Customers c ON r.CustomerID = c.CustomerID
JOIN Users u ON c.UserID = u.UserID;

UPDATE Repairs
SET Status = 'Completed'
WHERE RepairID = 6;

DELETE FROM Repairs
WHERE RepairID = 1;

-- ORDER & ORDER DETAIL QUERIES

INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES (3, 4, 5, 250000.00);

SELECT o.OrderID, u.Name AS CustomerName, o.OrderDate, o.Status, p.Name AS ProductName, od.Quantity, od.UnitPrice
FROM Orders o
JOIN Customers c ON o.CustomerID = c.CustomerID
JOIN Users u ON c.UserID = u.UserID
JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID;

-- PAYMENT QUERIES
 

 SELECT p.PaymentID, u.Name AS CustomerName, o.OrderDate, p.Amount, p.PaymentMethod
 FROM Payments p
 JOIN Orders o ON p.OrderID = o.OrderID
 JOIN Customers c ON o.CustomerID = c.CustomerID
 JOIN Users u ON c.UserID = u.UserID;

 -- TRIGGERS

 CREATE TRIGGER trg_UpdateStockOnOrder
ON OrderDetails
AFTER INSERT
AS
BEGIN
    UPDATE Products
    SET StockQty = StockQty - i.Quantity
    FROM Products p
    INNER JOIN inserted i ON p.ProductID = i.ProductID;
END;

select * from Products;

CREATE TRIGGER trg_PreventManagerDelete
ON Users
INSTEAD OF DELETE
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM Employees e
        JOIN deleted d ON e.UserID = d.UserID
    )
    BEGIN
        RAISERROR ('Cannot delete a manager who has assigned employees.', 16, 1);
        ROLLBACK;
    END
    ELSE
    BEGIN
        DELETE FROM Users
        WHERE UserID IN (SELECT UserID FROM deleted);
    END
END;

SELECT * FROM Managers;

SELECT * FROM Customers;
SELECT * FROM Users;
SELECT * FROM OrderDetails;
SELECT * FROM Branches;
SELECT * FROM Orders;
SELECT * FROM Categories;
SELECT * FROM Brands;