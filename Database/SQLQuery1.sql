go
CREATE PROC USP_GetTableBill @tableid INT
as
BEGIN
SELECT dbo.Food.name, dbo.BillInfo.count, dbo.Food.price, (dbo.BillInfo.count * dbo.Food.price) AS [Total] FROM  dbo.Food, dbo.Bill,dbo.BillInfo, dbo.TableFood
WHERE dbo.Bill.id = dbo.BillInfo.idBill AND dbo.BillInfo.idFood = dbo.Food.id AND dbo.Bill.idTable= dbo.TableFood.id AND dbo.Bill.status = 0 AND dbo.TableFood.id = @tableid
END
GO


DROP  PROC dbo.USP_GetTableBill
EXEC dbo.USP_GetTableBill
 @tableid = 3

 select * from Bill
  select * from BillInfo

 select * from TableFood

