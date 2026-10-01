USE WarehouseDB;

DROP TABLE IF EXISTS StockMovements;
DROP TABLE IF EXISTS SupplierProduct;
DROP TABLE IF EXISTS Suppliers;
DROP TABLE IF EXISTS Products;
DROP TABLE IF EXISTS Categories;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS Roles;

CREATE TABLE Roles (
    roleID INT PRIMARY KEY IDENTITY,
    roleName NVARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Users (
    userID INT PRIMARY KEY IDENTITY,
    username NVARCHAR(100) NOT NULL UNIQUE,
    passwordHash NVARCHAR(100) NOT NULL,
    roleID INT NOT NULL,
    createdOn DATETIME2 DEFAULT GETDATE() NOT NULL,
    CONSTRAINT FK_Users_Roles FOREIGN KEY (roleID) REFERENCES Roles(roleID)
);

CREATE TABLE Categories (
    categoryID INT PRIMARY KEY IDENTITY,
    categoryName NVARCHAR(255) NOT NULL UNIQUE,
    createdByID INT NOT NULL,
    alteredLastByID INT NULL,
    createdOn DATETIME2 DEFAULT GETDATE() NOT NULL,
    alteredLastOn  DATETIME2,
    CONSTRAINT FK_Categories_Users_Create FOREIGN KEY (createdByID) REFERENCES Users(userID),
    CONSTRAINT FK_Categories_Users_Alter FOREIGN KEY (alteredLastByID) REFERENCES Users(userID)
);

CREATE TABLE Products (
    productID INT PRIMARY KEY IDENTITY,
    productName NVARCHAR(255) UNIQUE NOT NULL,
    categoryID INT NOT NULL,
    createdByID INT NOT NULL,
    alteredLastByID INT NULL,
    createdOn DATETIME2 DEFAULT GETDATE() NOT NULL,
    alteredLastOn  DATETIME2,
    CONSTRAINT FK_Products_Category FOREIGN KEY (categoryID) REFERENCES Categories(categoryID),
    CONSTRAINT FK_Products_Users_Create FOREIGN KEY (createdByID) REFERENCES Users(userID),
    CONSTRAINT FK_Products_Users_Alter FOREIGN KEY (alteredLastByID) REFERENCES Users(userID)
);

CREATE TABLE Suppliers (
    supplierID INT PRIMARY KEY IDENTITY,
    supplierName NVARCHAR(100) NOT NULL UNIQUE,
    contactPerson NVARCHAR(100),
    phone NVARCHAR(50) UNIQUE NULL,
    email NVARCHAR(255) UNIQUE NULL,
    createdByID INT NOT NULL,
    alteredLastByID INT,
    createdOn DATETIME2 DEFAULT GETDATE() NOT NULL,
    alteredLastOn  DATETIME2,
    CONSTRAINT FK_Suppliers_Users_Create FOREIGN KEY (createdByID) REFERENCES Users(userID),
    CONSTRAINT FK_Suppliers_Users_Alter FOREIGN KEY (alteredLastByID) REFERENCES Users(userID)
);

CREATE TABLE SupplierProduct (
    supplierID INT NOT NULL,
    productID INT NOT NULL,
    pricePerUnit DECIMAL(10, 2) NOT NULL,
    createdByID INT NOT NULL,
    alteredLastByID INT,
    createdOn DATETIME2 DEFAULT GETDATE() NOT NULL,
    alteredLastOn  DATETIME2,
    CONSTRAINT PK_SupplierProduct PRIMARY KEY (supplierID, productID),
    CONSTRAINT FK_SupplierProduct_Suppliers FOREIGN KEY (supplierID) REFERENCES Suppliers(supplierID),
    CONSTRAINT FK_SupplierProduct_Product FOREIGN KEY (productID) REFERENCES Products(productID),
    CONSTRAINT FK_SupplierProduct_Users_Create FOREIGN KEY (createdByID) REFERENCES Users(userID),
    CONSTRAINT FK_SupplierProduct_Users_Alter FOREIGN KEY (alteredLastByID) REFERENCES Users(userID)
);

CREATE TABLE StockMovements(
    movementID INT PRIMARY KEY IDENTITY,
    productID INT NOT NULL,
    supplierID INT NULL,
    movementType NVARCHAR(5) NOT NULL CHECK (movementType IN ('IN','OUT')),
    quantity INT NOT NULL,
    movementDate DATETIME2 NOT NULL DEFAULT GETDATE(),
    createdByID INT NOT NULL,
    alteredLastByID INT,
    createdOn DATETIME2 DEFAULT GETDATE() NOT NULL,
    alteredLastOn  DATETIME2,
    CONSTRAINT FK_StockMovements_Products FOREIGN KEY (productID) REFERENCES Products(productID),
    CONSTRAINT FK_StockMovements_Suppliers FOREIGN KEY (supplierID) REFERENCES Suppliers(supplierID),
    CONSTRAINT FK_StockMovements_Users_Create FOREIGN KEY (createdByID) REFERENCES Users(userID),
    CONSTRAINT FK_StockMovements_Users_Alter FOREIGN KEY (alteredLastByID) REFERENCES Users(userID)
);