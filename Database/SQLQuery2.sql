	USE [QuanLyQuanCafe]
GO

SELECT * FROM Food

drop proc USP_InsertBillInfo
ALTER PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT dbo.Bill 
	        ( DateCheckIn ,
	          DateCheckOut ,
	          idTable ,
	          status,
			  discount,
			  total
	        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
	          NULL , -- DateCheckOut - date
	          @idTable , -- idTable - int
	          0,
			  0,
			  0  -- status - int
	        )
   select MAX(id) from Bill
END
GO




exec USP_InsertBill 2

go
ALTER PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE IF(@count > 0)
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, idFood, count )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
END
GO
select * from bill
select * from billinfo
select * from tablefood
USP_InsertBillInfo 3 , 5 , 2
USP_InsertBillInfo 3 , 4 , 2
Alter TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0	
	
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill
	
	IF (@count > 0)
	BEGIN
	
		PRINT @idTable
		PRINT @idBill
		PRINT @count
		
		UPDATE dbo.TableFood SET status = N'Taken' WHERE id = @idTable		
		
	END			
END
GO

alter TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR Delete
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Deleted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0	
	
	DECLARE @count INT
	SELECT  @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill
	
	   Print'id table' 
	    PRINT  @idTable
		 Print ' id Bill'
		PRINT  @idBill
		 Print'count'
		PRINT  @count
 IF (@count < 2)
	BEGIN
	   Print'id table' 
	    PRINT  @idTable
		 Print ' id Bill'
		PRINT  @idBill
		 Print'count'
		PRINT  @count
	UPDATE dbo.TableFood SET status = N'Empty' WHERE id = @idTable
	end
	
END
GO

drop TRIGGER UTG_UpdateTable
ON dbo.TableFood FOR UPDATE
AS
BEGIN
    DECLARE @idTable INT
	DECLARE @status NVARCHAR(100)
	
	SELECT @idTable = id  FROM Inserted

	DECLARE @idBill INT 
	SELECT @idBill = id  FROM dbo.Bill WHERE idTable = @idTable AND status = 0

	DECLARE @countBillInfo INT
	SELECT @countBillInfo = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill

	IF	(@countBillInfo > 0 AND @status <> N'Taken')
	UPDATE dbo.TableFood SET status = N'Taken' WHERE id = @idTable

	ELSE IF	(@countBillInfo < 0 AND @status <> N'Empty')
	UPDATE dbo.TableFood SET status = N'Empty' WHERE id = @idTable
END
go


ALTER TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Empty' WHERE id = @idTable
END
GO

DROP TRIGGER UTG_UpdateBillInfo,UTG_UpdateBill 

SELECT * FROM dbo.Bill

SELECT * FROM dbo.BillInfo

SELECT * FROM dbo.TableFood

DELETE dbo.BillInfo
DELETE dbo.Bill



GO




go
Drop PROC USP_SwitchTable
@idTable1 int , @idTable2 int
AS
BEGIN

DECLARE @idFirstBill INT
DECLARE @idSecondBill int
DECLARE @isFirstTableEmpty INT = 1
DECLARE @isSecondTableEmpty INT = 1
     SELECT  @idSecondBill= id FROM dbo.Bill WHERE idTable = @idTable2 AND status  = 0
	   SELECT  @idFirstBill= id FROM dbo.Bill WHERE idTable = @idTable1 AND status  = 0

	   IF (@idFirstBill IS NULL)
	   BEGIN

	   INSERT INTO dbo.Bill
	   (
	       DateCheckIn,
	       DateCheckOut,
	       idTable,
	       status
	   )
	   VALUES
	   (   GETDATE(), -- DateCheckIn - date
	       NULL, -- DateCheckOut - date
	       @idTable1,         -- idTable - int
	       0       -- status - int
	       )
		   SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0

		  
	   END
	   SELECT @isFirstTableEmpty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill

	   	   IF (@idSecondBill IS NULL)
	   BEGIN
	   INSERT INTO dbo.Bill
	   (
	       DateCheckIn,
	       DateCheckOut,
	       idTable,
	       status
	   )
	   VALUES
	   (   GETDATE(), -- DateCheckIn - date
	       NULL, -- DateCheckOut - date
	       @idTable2 ,         -- idTable - int
	       0       -- status - int
	       )
		   SELECT @idSecondBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0

		   
		   
	   END

	      SELECT @isSecondTableEmpty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSecondBill
  
    SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSecondBill

	UPDATE dbo.BillInfo SET idBill = @idSecondBill WHERE idBill  =	@idFirstBill 

	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id  IN (SELECT * FROM dbo.IDBillInfoTable)  

	DROP TABLE IDBillInfoTable

	IF(@isFirstTableEmpty = 0)
	UPDATE dbo.TableFood SET status = N'Empty' WHERE id = @idTable2

	 IF(@isSecondTableEmpty = 0)
	UPDATE dbo.TableFood SET status = N'Empty' WHERE id = @idTable1

END
GO

EXEC USP_SwitchTable 3, 2


exec USP_GetAllCheckOutBill '06-01-2022' ,'06-30-2022' 
DBCC useroptions


Alter PROC USP_GetAllCheckOutBill
@fromDate datetime,
@toDate datetime
AS
BEGIN

Select bill.id as [ID], DateCheckIn as [Checkin], DateCheckOut as [Checkout], TableFood.Name as [Table Name], discount as Discount, FORMAT (bill.total, '###.##')  as [Total Price] from bill 
join TableFood on TableFood.id = Bill.idTable where bill.status = 1 and DateCheckIn between @fromDate and @toDate

END
GO

SELECT * FROM dbo.TableFood


DBCC CHECKIDENT (Bill , RESEED, 0)
DBCC CHECKIDENT (BillInfo , RESEED, 0)
GO
UPDATE dbo.TableFood SET status = N'Empty'
Delete Bill
Delete Billinfo

select * from bill