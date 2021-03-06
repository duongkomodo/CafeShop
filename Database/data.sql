USE [QuanLyQuanCafe]
GO
/****** Object:  StoredProcedure [dbo].[USP_SwitchTable]    Script Date: 14-Jun-22 8:32:49 PM ******/
DROP PROCEDURE [dbo].[USP_SwitchTable]
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 14-Jun-22 8:32:49 PM ******/
DROP PROCEDURE [dbo].[USP_Login]
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 14-Jun-22 8:32:49 PM ******/
DROP PROCEDURE [dbo].[USP_InsertBillInfo]
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 14-Jun-22 8:32:49 PM ******/
DROP PROCEDURE [dbo].[USP_InsertBill]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableList]    Script Date: 14-Jun-22 8:32:49 PM ******/
DROP PROCEDURE [dbo].[USP_GetTableList]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableBill]    Script Date: 14-Jun-22 8:32:49 PM ******/
DROP PROCEDURE [dbo].[USP_GetTableBill]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 14-Jun-22 8:32:49 PM ******/
DROP PROCEDURE [dbo].[USP_GetAccountByUserName]
GO
/****** Object:  StoredProcedure [dbo].[USP_ChangeTableStatus]    Script Date: 14-Jun-22 8:32:49 PM ******/
DROP PROCEDURE [dbo].[USP_ChangeTableStatus]
GO
ALTER TABLE [dbo].[Food] DROP CONSTRAINT [FK__Food__price__1DE57479]
GO
ALTER TABLE [dbo].[BillInfo] DROP CONSTRAINT [FK__BillInfo__idFood__276EDEB3]
GO
ALTER TABLE [dbo].[BillInfo] DROP CONSTRAINT [FK__BillInfo__count__267ABA7A]
GO
ALTER TABLE [dbo].[Bill] DROP CONSTRAINT [FK__Bill__status__22AA2996]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 14-Jun-22 8:32:49 PM ******/
DROP TABLE [dbo].[TableFood]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 14-Jun-22 8:32:49 PM ******/
DROP TABLE [dbo].[FoodCategory]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 14-Jun-22 8:32:49 PM ******/
DROP TABLE [dbo].[Food]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 14-Jun-22 8:32:49 PM ******/
DROP TABLE [dbo].[BillInfo]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 14-Jun-22 8:32:49 PM ******/
DROP TABLE [dbo].[Bill]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 14-Jun-22 8:32:49 PM ******/
DROP TABLE [dbo].[Account]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 14-Jun-22 8:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL DEFAULT (N'Kter'),
	[PassWord] [nvarchar](1000) NOT NULL DEFAULT ((0)),
	[Type] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bill]    Script Date: 14-Jun-22 8:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NOT NULL DEFAULT (getdate()),
	[DateCheckOut] [date] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL DEFAULT ((0)),
	[discount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 14-Jun-22 8:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[count] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Food]    Script Date: 14-Jun-22 8:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL DEFAULT (N'Chưa đặt tên'),
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 14-Jun-22 8:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL DEFAULT (N'Chưa đặt tên'),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 14-Jun-22 8:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL DEFAULT (N'Bàn chưa có tên'),
	[status] [nvarchar](100) NOT NULL DEFAULT (N'Trống'),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'admin', N'Duong', N'admin', 1)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'staff', N'Staff', N'staff', 0)
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount]) VALUES (1, CAST(N'2022-06-11' AS Date), NULL, 6, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount]) VALUES (11, CAST(N'2022-06-11' AS Date), NULL, 1, 0, 0)
SET IDENTITY_INSERT [dbo].[Bill] OFF
SET IDENTITY_INSERT [dbo].[BillInfo] ON 

INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (1, 1, 4, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (2, 11, 4, 1)
SET IDENTITY_INSERT [dbo].[BillInfo] OFF
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1, N'Classic Buble Tea', 2, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2, N'Brown Sugar Milk Tea', 2, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3, N'Cheese Foam Tea', 2, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4, N'Sting', 1, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5, N'7-Up', 1, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6, N'Beer Heineken', 1, 23000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7, N'Beer 333', 1, 12000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (8, N'Orange Juice Twitster', 1, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (9, N'Melon (5 Pieces)', 3, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (10, N'Pomelo (5 Pieces)', 3, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (11, N'Guava (5 Pieces)', 3, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (12, N'Espressso', 4, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (13, N'Macchiato', 4, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (14, N'Latte', 4, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (15, N'Cappuccino', 4, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (16, N'Spicy shredded chicken', 5, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (17, N'Spicy shredded pork', 5, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (18, N'French Fries', 5, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (19, N'Sweet Potato Fried', 5, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (20, N'Banh Mi Pate', 6, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (21, N'Banh Mi Ap Chao', 6, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (22, N'Bun Tron', 6, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (23, N'Bun Dau Mam tom', 6, 50000)
SET IDENTITY_INSERT [dbo].[Food] OFF
SET IDENTITY_INSERT [dbo].[FoodCategory] ON 

INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (1, N'Other Drinks')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (2, N'Bubble Tea')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (3, N'Fruit')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (4, N'Cafe')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (5, N'Snacks')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (6, N'Savory Dishes')
SET IDENTITY_INSERT [dbo].[FoodCategory] OFF
SET IDENTITY_INSERT [dbo].[TableFood] ON 

INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (1, N'Table1', N'Taken')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (2, N'Table2', N'Empty')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (3, N'Table3', N'Empty')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (4, N'Table4', N'Empty')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (5, N'Table5', N'Empty')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (6, N'Table6', N'Taken')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (7, N'Table7', N'Empty')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (8, N'Table8', N'Empty')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (9, N'Table9', N'Empty')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (10, N'Table10', N'Empty')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (11, N'Table11', N'Empty')
SET IDENTITY_INSERT [dbo].[TableFood] OFF
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [dbo].[TableFood] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[FoodCategory] ([id])
GO
/****** Object:  StoredProcedure [dbo].[USP_ChangeTableStatus]    Script Date: 14-Jun-22 8:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_ChangeTableStatus] @tableid INT
AS
BEGIN
update dbo.TableFood
  set  status = case
                  when status = 'Empty' then 'Taken'
                  else  'Empty'
                 end
WHERE
id = @tableid
END

GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 14-Jun-22 8:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_GetAccountByUserName]
@userName nvarchar(100)
AS 
BEGIN
SELECT * FROM dbo.Account
WHERE UserName LIKE '%'+ @userName+'%'

END 
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableBill]    Script Date: 14-Jun-22 8:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetTableBill] @tableid INT
as
BEGIN
SELECT dbo.Food.name, dbo.BillInfo.count, dbo.Food.price, (dbo.BillInfo.count * dbo.Food.price) AS [Total] FROM  dbo.Food, dbo.Bill,dbo.BillInfo, dbo.TableFood
WHERE dbo.Bill.id = dbo.BillInfo.idBill AND dbo.BillInfo.idFood = dbo.Food.id AND dbo.Bill.idTable= dbo.TableFood.id AND dbo.Bill.status = 0 AND dbo.TableFood.id = @tableid
END

GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableList]    Script Date: 14-Jun-22 8:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Alter PROC [dbo].[USP_GetTableList]
AS
BEGIN
SELECT * FROM dbo.TableFood where inUse = 1
END

GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 14-Jun-22 8:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBill]
@idTable INT
AS
BEGIN
	INSERT dbo.Bill 
	        ( DateCheckIn ,
	          DateCheckOut ,
	          idTable ,
	          status,
			  discount
	        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
	          NULL , -- DateCheckOut - date
	          @idTable , -- idTable - int
	          0,
			  0  -- status - int
	        )
			select * from Bill
END

GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 14-Jun-22 8:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBillInfo]
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
	ELSE
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
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 14-Jun-22 8:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_Login] @username NVARCHAR(200), @password NVARCHAR(200)
AS
BEGIN 
SELECT * FROM dbo.Account WHERE UserName = @username AND PassWord = @password

END

GO
/****** Object:  StoredProcedure [dbo].[USP_SwitchTable]    Script Date: 14-Jun-22 8:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_SwitchTable]
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
