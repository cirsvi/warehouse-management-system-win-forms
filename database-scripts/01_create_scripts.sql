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
    roleName NVARCHAR(50) NOT NULL,
    isActive BIT NOT NULL DEFAULT 1
);

CREATE TABLE Users (
    userID INT PRIMARY KEY IDENTITY,
    username NVARCHAR(100) NOT NULL,
    passwordHash NVARCHAR(100) NOT NULL,
    isActive BIT NOT NULL DEFAULT 1,
    roleID INT NOT NULL,
    createdOn DATETIME2 DEFAULT GETDATE() NOT NULL,
    alteredLastByID INT NULL,
    alteredLastOn  DATETIME2,
    CONSTRAINT FK_Users_Roles FOREIGN KEY (roleID) REFERENCES Roles(roleID),
    CONSTRAINT FK_Users_Users_Alter FOREIGN KEY (alteredLastByID) REFERENCES Users(userID)
);

CREATE TABLE Categories (
    categoryID INT PRIMARY KEY IDENTITY,
    categoryName NVARCHAR(255) NOT NULL,
    isActive BIT NOT NULL DEFAULT 1,
    createdByID INT NOT NULL,
    alteredLastByID INT NULL,
    createdOn DATETIME2 DEFAULT GETDATE() NOT NULL,
    alteredLastOn  DATETIME2,
    CONSTRAINT FK_Categories_Users_Create FOREIGN KEY (createdByID) REFERENCES Users(userID),
    CONSTRAINT FK_Categories_Users_Alter FOREIGN KEY (alteredLastByID) REFERENCES Users(userID)
);

CREATE TABLE Products (
    productID INT PRIMARY KEY IDENTITY,
    productName NVARCHAR(255) NOT NULL,
    isActive BIT NOT NULL DEFAULT 1,
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
    supplierName NVARCHAR(100) NOT NULL,
    contactPerson NVARCHAR(100),
    phone NVARCHAR(50) UNIQUE NULL,
    email NVARCHAR(255) UNIQUE NULL,
    isActive BIT NOT NULL DEFAULT 1,
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

GO

CREATE UNIQUE INDEX UX_Roles_RoleName_Active ON Roles(roleName) WHERE isActive = 1;
CREATE UNIQUE INDEX UX_Users_Username_Active ON Users(username) WHERE isActive = 1;
CREATE UNIQUE INDEX UX_Categories_CategoryName_Active ON Categories(categoryName) WHERE isActive = 1;
CREATE UNIQUE INDEX UX_Products_ProductName_Active ON Products(productName) WHERE isActive = 1;
CREATE UNIQUE INDEX UX_Suppliers_SupplierName_Active ON Suppliers(supplierName) WHERE isActive = 1;
CREATE UNIQUE INDEX UX_Suppliers_SupplierPhone_Active ON Suppliers(phone) WHERE isActive = 1;
CREATE UNIQUE INDEX UX_Suppliers_SupplierEmail_Active ON Suppliers(email) WHERE isActive = 1;