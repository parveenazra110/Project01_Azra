---Function To Validate User Credentials----
CREATE FUNCTION [dbo].ufn_ValidateUser(
@EmailId VARCHAR(50), 
@Password VARCHAR(20) 
) 
RETURNS INT
AS 
BEGIN  
	DECLARE @Retvalue INT
	SELECT @Retvalue=RoleId FROM Users WHERE EmailId=@EmailId AND Password=@Password 
	IF @Retvalue IS NULL 
		SET @Retvalue=-99
	RETURN @Retvalue	
	 
END

SELECT [dbo].ufn_ValidateUser('Albert@gmail.com','Albert@1234')

-----------------------------------------------------------------------------------------------------------------------------------------

----Function To Get All The Products-----
GO
CREATE FUNCTION [dbo].ufn_GetAllProducts() 
RETURNS TABLE 
AS 
RETURN (SELECT *FROM Products) 

SELECT *FROM [dbo].ufn_GetAllProducts() 

--------------------------------------------------------------------------------------------------------------------------------------------- 
-----Stored Procedure To Insert Sale Details into Sale Table and Generate SaleId.
GO
CREATE PROCEDURE usp_InsertSaleDetails(
@EmailId VARCHAR(50), 
@TotalSaleAmount DECIMAL, 
@SaleId INT OUT 
) 
AS 
BEGIN 
DECLARE @retval int,@tempsaleid INT
	BEGIN TRY 
		IF (@EmailId IS NULL) 
			SET @retval=-1 
		ELSE IF NOT EXISTS(SELECT EmailId FROM Users WHERE EmailId=@EmailId) 
		    SET @retval=-2 
		ELSE IF (@TotalSaleAmount<=0) 
			SET @retval=-3 
		ELSE 
			BEGIN 
				INSERT INTO Sales VALUES(@TotalSaleAmount,@EmailId) 
				SET @retval=1 
				SELECT @SaleId=MAX(SaleId) FROM Sales 
			END 
	END TRY 

	BEGIN CATCH 
		SET @retval=-99 
	END CATCH 
	RETURN @retval  
END 
 

declaRe @sid INT,@retvalu int 
Execute usp_InsertSaleDetails 'Davis@gmail.com',8856.56,@sid out 
print @sid

