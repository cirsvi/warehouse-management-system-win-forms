SET IDENTITY_INSERT Roles ON;
INSERT INTO Roles (roleID, roleName) VALUES (1, 'Admin');
INSERT INTO Roles (roleID, roleName) VALUES (2, 'Warehouse Worker');
INSERT INTO Roles (roleID, roleName) VALUES (3, 'Accountant');
SET IDENTITY_INSERT Roles OFF;

SET IDENTITY_INSERT Users ON;
INSERT INTO Users (userID, username, passwordHash, roleID) VALUES (1, 'admin', '$2a$11$AQYGKD77NmA2hDCVbEjb6.Yr1bZMhXohT/0eXmqmCOY.3D.ekR.n2', 1);
INSERT INTO Users (userID, username, passwordHash, roleID) VALUES (2, 'w_worker', '$2a$11$AQYGKD77NmA2hDCVbEjb6.Yr1bZMhXohT/0eXmqmCOY.3D.ekR.n2', 2);
INSERT INTO Users (userID, username, passwordHash, roleID) VALUES (3, 'accountant', '$2a$11$AQYGKD77NmA2hDCVbEjb6.Yr1bZMhXohT/0eXmqmCOY.3D.ekR.n2', 3);
SET IDENTITY_INSERT Users OFF;

SET IDENTITY_INSERT Categories ON;
INSERT INTO Categories (categoryID, categoryName, createdByID) VALUES (1, 'Electronics', 1);
INSERT INTO Categories (categoryID, categoryName, createdByID) VALUES (2, 'Office Supplies', 1);
SET IDENTITY_INSERT Categories OFF;

SET IDENTITY_INSERT Suppliers ON;
INSERT Suppliers(supplierID, supplierName, contactPerson, phone, createdByID) VALUES (1, 'Ebbix SIA', 'Andris Pals', '+37122229023', 1);
INSERT Suppliers(supplierID, supplierName, contactPerson, phone, email, createdByID) VALUES (2, 'Zabbia SIA', 'Marina Reza', '+37123338011', 'marina.reza@example.com', 1);
SET IDENTITY_INSERT Suppliers OFF;

SET IDENTITY_INSERT Products ON;
INSERT Products(productID, productName, categoryID, createdByID) VALUES (1, 'HP Victus Laptop', 1, 1);
INSERT Products(productID, productName, categoryID, createdByID) VALUES (2, 'JBL Headphones', 1, 2);
INSERT Products(productID, productName, categoryID, createdByID) VALUES (3, 'Steppler (Blue)', 2, 1);
SET IDENTITY_INSERT Products OFF;

INSERT SupplierProduct(supplierID, productID, pricePerUnit, createdByID) VALUES (1, 1, 799.99, 1);
INSERT SupplierProduct(supplierID, productID, pricePerUnit, createdByID) VALUES (2, 1, 759.99, 1);
INSERT SupplierProduct(supplierID, productID, pricePerUnit, createdByID) VALUES (1, 2, 49.99, 1);
INSERT SupplierProduct(supplierID, productID, pricePerUnit, createdByID) VALUES (2, 3, 5.99, 1);

SET IDENTITY_INSERT StockMovements ON;
INSERT StockMovements (movementID, productID, supplierID, movementType, quantity, createdByID)  VALUES (1, 1, 1, 'IN', 5, 1);
INSERT StockMovements (movementID, productID, movementType, quantity, createdByID)  VALUES (2, 1, 'OUT', 1, 2);
INSERT StockMovements (movementID, productID, supplierID, movementType, quantity, createdByID)  VALUES (3, 1, 2, 'IN', 3, 1);
INSERT StockMovements (movementID, productID, supplierID, movementType, quantity, createdByID)  VALUES (4, 2, 1, 'IN', 20, 2);
INSERT StockMovements (movementID, productID, supplierID, movementType, quantity, createdByID)  VALUES (5, 3, 2, 'IN', 50, 1);
INSERT StockMovements (movementID, productID, movementType, quantity, createdByID)  VALUES (6, 3, 'OUT', 13, 2);
SET IDENTITY_INSERT StockMovements OFF;