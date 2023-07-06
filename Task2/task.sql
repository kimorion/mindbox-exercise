create database testdb;

CREATE TABLE Product
(
    Id   int NOT NULL PRIMARY KEY,
    Name varchar(255),
);

CREATE TABLE Category
(
    Id   int NOT NULL PRIMARY KEY,
    Name varchar(255),
);

CREATE TABLE ProductCategory
(
    ProductId  int NOT NULL,
    CategoryId int NOT NULL,
    CONSTRAINT UQ_ProductId_CategoryId UNIQUE (ProductId, CategoryId),
    CONSTRAINT FK_Product_ProductID FOREIGN KEY (ProductId) REFERENCES Product (id) ON DELETE CASCADE,
    CONSTRAINT FK_Category_CategoryID FOREIGN KEY (CategoryId) REFERENCES Category (id) ON DELETE CASCADE,
);

INSERT INTO Product(Id, Name)
VALUES (1, 'product_1'),
       (2, 'product_2'),
       (3, 'product_3');

INSERT INTO Category(Id, Name)
VALUES (1, 'category_1'),
       (2, 'category_2');

INSERT INTO ProductCategory(ProductId, CategoryId)
VALUES (1, 1),
       (1, 2),
       (2, 1);

---

SELECT p.Name, c.Name
FROM Product p
         LEFT JOIN ProductCategory pc ON p.Id = pc.ProductId
         LEFT JOIN Category c on c.Id = pc.CategoryId;