use CodinovaDB  
---Insert Records into Roles Table----
INSERT INTO Roles VALUES('Admin')
INSERT INTO Roles VALUES('Customer')  

-----Insert Records into Users Table-----
INSERT INTO Users VALUES('Albert@gmail.com','Albert@1234',1) 
INSERT INTO Users VALUES('Anabela@gmail.com','Anabela@1234',2)
INSERT INTO Users VALUES('Ann@gmail.com','Ann@1234',2)
INSERT INTO Users VALUES('Annette@gmail.com','Annette@1234',2)
INSERT INTO Users VALUES('Aria@gmail.com','Aria@1234',2)
INSERT INTO Users VALUES('Carine@gmail.com','Carine@1234',2)
INSERT INTO Users VALUES('Carlos@gmail.com','Carlos@1234',2)
INSERT INTO Users VALUES('Daniel@gmail.com','Daniel@1234',2)
INSERT INTO Users VALUES('Davis@gmail.com','Davis@1234',2)
INSERT INTO Users VALUES('Diego@gmail.com','Diego@1234',2) 

----Insert Records into Categories Table----
INSERT INTO Categories VALUES('Clothing')
INSERT INTO Categories VALUES('Computers')
INSERT INTO Categories VALUES('Fruits') 

----Insert Records into Products Table----
INSERT INTO Products VALUES('P101','Sweater',1,895.78)
INSERT INTO Products VALUES('P102','Tie',1,564.4)
INSERT INTO Products VALUES('P103','Jacket',1,2654.46)
INSERT INTO Products VALUES('P104','Shirt',1,256.8)
INSERT INTO Products VALUES('P105','Monitor',2,5000.56)
INSERT INTO Products VALUES('P106','Mouse',2,562.5)
INSERT INTO Products VALUES('P107','Keyboard',2,2315.23)
INSERT INTO Products VALUES('P108','CPU',2,10000.54)
INSERT INTO Products VALUES('P109','Grapes',3,52.1)
INSERT INTO Products VALUES('P110','Mango',3,43.12)
INSERT INTO Products VALUES('P111','Pineapple',3,74.2)
INSERT INTO Products VALUES('P112','Kiwi',3,56.15)
INSERT INTO Products VALUES('P113','Guava',3,58.45)

---Insert Records into Sales Table----
INSERT INTO Sales VALUES(456.56,'Anabela@gmail.com')
INSERT INTO Sales VALUES(4992.85,'Ann@gmail.com')
INSERT INTO Sales VALUES(4896.78,'Anabela@gmail.com')
INSERT INTO Sales VALUES(4954.84,'Annette@gmail.com')
INSERT INTO Sales VALUES(4575.865,'Aria@gmail.com')
INSERT INTO Sales VALUES(4768.78,'Ann@gmail.com')

SELECT *FROM Users
SELECT *FROM Roles  
SELECT *FROM Categories 
SELECT *FROM Products
SELECT *FROM Sales





