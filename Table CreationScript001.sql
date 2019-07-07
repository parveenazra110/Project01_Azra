----Create DataBase CodinovaDB
create database CodinovaDB 
use CodinovaDB 

----Create Table Roles
CREATE TABLE Roles(
RoleId TINYINT IDENTITY(1,1),
RoleName VARCHAR(20) NOT NULL,
CONSTRAINT PK_RoleId PRIMARY KEY(RoleId)
)

----Create Table Users
CREATE TABLE Users(
UserId INT IDENTITY(1,1),
EmailId VARCHAR(50),
[Password] VARCHAR(20) NOT NULL,
RoleId TINYINT NOT NULL, 
CONSTRAINT PK_EmailId PRIMARY KEY(EmailId), 
CONSTRAINT FK_UserRoleId FOREIGN KEY(RoleId) REFERENCES Roles(RoleId)
)  

----Create Table Categories
CREATE TABLE Categories(
CategoryId TINYINT IDENTITY(1,1), 
CategoryName VARCHAR(20) NOT NULL, 
CONSTRAINT PK_CategoryId PRIMARY KEY(CategoryId) 
) 

----Create Table Products
CREATE TABLE Products(
ProductId CHAR(4), 
ProductName VARCHAR(50) NOT NULL, 
CategoryId TINYINT, 
CONSTRAINT PK_ProductId PRIMARY KEY(ProductId), 
CONSTRAINT FK_ProductCategoryId FOREIGN KEY(CategoryId) REFERENCES Categories(CategoryId) 
)

----Create Table Products
CREATE TABLE Sales(
SaleId INT IDENTITY(100,1), 
TotalSaleAmount DECIMAL(18,2), 
EmailId VARCHAR(50), 
CONSTRAINT PK_SaleId PRIMARY KEY(SaleId), 
CONSTRAINT FK_UserSaleId FOREIGN KEY(EmailId) REFERENCES Users(EmailId)
)   








