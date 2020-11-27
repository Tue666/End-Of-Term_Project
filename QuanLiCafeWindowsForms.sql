CREATE DATABASE QuanLiCafe
GO

USE QuanLiCafe
GO

CREATE TABLE Account
(
	ID INT IDENTITY PRIMARY KEY,
	UserName NVARCHAR(100) NOT NULL,
	PassWord NVARCHAR(100) NOT NULL,
	AccountType INT NOT NULL,
	Name NVARCHAR(100),
	Sex NVARCHAR(10),
	Age INT,
	Number NVARCHAR(20),
	Email NVARCHAR(30),
	Adress NVARCHAR(30)
)
GO

CREATE TABLE TableFood
(
	ID INT IDENTITY PRIMARY KEY,
	TableName NVARCHAR(100) NOT NULL,
	Status NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE Food
(
	ID INT IDENTITY PRIMARY KEY,
	FoodName NVARCHAR(100) NOT NULL,
	FoodCategory INT NOT NULL,
	Price FLOAT NOT NULL DEFAULT 0,
	Discount FLOAT DEFAULT 0

	FOREIGN KEY (FoodCategory) REFERENCES dbo.FoodCategory(ID)
)
GO

CREATE TABLE FoodCategory
(
	ID INT IDENTITY PRIMARY KEY,
	CategoryName NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE Bill
(
	ID INT IDENTITY PRIMARY KEY,
	idTable INT NOT NULL,
	Status INT NOT NULL,
	DayCheckIn DATE DEFAULT GETDATE(),
	DayCheckOut DATE,
	totalPrice FLOAT,
	allDiscount FLOAT

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(ID)
)
GO

CREATE TABLE BillInFo
(
	ID INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	QuantityFood INT NOT NULL

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(ID),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(ID)
)
GO
-----------------------------------------------------------------------------
SELECT * FROM dbo.TableFood
GO
SELECT * FROM dbo.Food
GO
SELECT * FROM dbo.FoodCategory
GO
SELECT * FROM dbo.Bill
GO
SELECT * FROM dbo.BillInFo
GO
-----------------------------------------------------------------------------
DBCC CHECKIDENT (BillInFo,RESEED, 0)
GO
DBCC CHECKIDENT (Bill,RESEED, 0)
GO
DELETE BillInFo
GO
DELETE Bill
GO
-----------------------------------------------------------------------------
INSERT INTO dbo.Account(UserName,Password,AccountType) VALUES
(N'admin2',123,1),
(N'user2',123,0),
(N'user3',123,0),
(N'user4',123,0)
GO
------------------------------------------------------------------------------
DECLARE @i INT = 1
WHILE @i <= 8
BEGIN
	INSERT INTO TableFood(TableName, Status) VALUES (N'Bàn ' + CAST(@i AS NVARCHAR(100)), N'Trống')
	SET @i = @i+1
END
GO
--Thêm foodcate--
INSERT INTO FoodCategory VALUES
(N'Quán ăn'),
(N'Đồ ăn chay'),
(N'Bánh ngọt'),
(N'Đồ uống các loại'),
(N'Tráng miệng')
GO
--Thêm food--
INSERT INTO Food(FoodName,FoodCategory,Price) VALUES
(N'Lẩu nướng tự chọn',1,20000),
(N'Mỳ Ý',1,20000),
(N'Bún đậu mắm tôm',1,30000),
(N'Đậu hủ um chao',2,15000),
(N'Mì xào chay',2,10000),
(N'Nấm bào ngư xào',2,30000),
(N'Bánh pho mát',3,20000),
(N'Tiramisy',3,30000),
(N'Cocacola',4,15000),
(N'Sting đen',4,15000),
(N'Dưa hấu',5,15000),
(N'Ổi',5,15000),
(N'Nho không hột',5,30000)
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @QuantityFood INT
AS
BEGIN
	DECLARE @checkExit INT
	DECLARE @quantity INT
	SELECT @checkExit = ID, @quantity = QuantityFood FROM BillInFo WHERE idBill = @idBill AND idFood = @idFood
	IF (@checkExit > 0)
	BEGIN
		DECLARE @newQuantity INT = @quantity + @QuantityFood
		IF (@newQuantity > 0)
			UPDATE BillInFo SET QuantityFood = @quantity + @QuantityFood WHERE idFood = @idFood
		ELSE
			DELETE BillInFo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		IF (@QuantityFood != 0)
			INSERT INTO BillInFo (idBill, idFood, QuantityFood) VALUES (@idBill,@idFood,@QuantityFood)
	END
END
GO

CREATE PROC USP_InserBill
@idTable INT
AS
BEGIN
	INSERT INTO dbo.Bill (idTable, Status, DayCheckIn, DayCheckOut) VALUES (@idTable,0,GETDATE(),NULL)
END
GO

CREATE PROC USP_CheckOut
@idBill INT, @totalPrice FLOAT, @allDiscount FLOAT
AS
BEGIN
	UPDATE dbo.Bill SET allDiscount = @allDiscount WHERE ID = @idBill AND Status = 0
	UPDATE dbo.Bill SET totalPrice = @totalPrice WHERE ID = @idBill AND Status = 0
	UPDATE dbo.Bill SET DayCheckOut = GETDATE() WHERE ID = @idBill AND Status = 0
	UPDATE Bill SET Status = 1 WHERE ID = @idBill AND Status = 0
END
GO

CREATE PROC USP_TableList
@idBill INT
AS
BEGIN
	DECLARE @idTable INT, @status INT
	SELECT @idTable = idTable, @status = Status FROM Bill WHERE ID = @idBill
	IF (@status = 0)
	BEGIN
		UPDATE TableFood SET Status = N'Có người' WHERE ID = @idTable
	END
	ELSE
	BEGIN
		UPDATE TableFood SET Status = N'Trống' WHERE ID = @idTable
	END
END
GO

SELECT f.FoodName, bi.QuantityFood, f.Price*bi.QuantityFood AS TotalPrice FROM BillInFo as bi, Bill as b, Food as f 
WHERE bi.idBill = b.ID AND bi.idFood = f.ID AND b.idTable = 2 AND b.Status = 0
GO

CREATE PROC USP_SwapTable
@idTable1 INT, @idTable2 INT
AS
BEGIN
	DECLARE @idBill1 INT
	SELECT @idBill1 = ID FROM Bill WHERE idTable = @idTable1 AND Status = 0
	DECLARE @idBill2 INT
	--INSERT Bill VALUES (@idTable2,0)
	INSERT INTO dbo.Bill (idTable, Status, DayCheckIn, DayCheckOut) VALUES (@idTable2,0,GETDATE(),NULL)
	SELECT @idBill2 = MAX(ID) FROM Bill
	SELECT ID INTO IDBillInfoTable FROM BillInFo WHERE idBill = @idBill1
	UPDATE BillInFo SET idBill = @idBill2 WHERE ID IN (SELECT * FROM IDBillInfoTable)
	DROP TABLE IDBillInfoTable
	UPDATE Bill SET Status = 1 WHERE ID = @idBill1
	UPDATE TableFood SET Status = N'Trống' WHERE ID = @idTable1
	UPDATE TableFood SET Status = N'Có người' WHERE ID = @idTable2
END
GO

CREATE FUNCTION [dbo].[ChuyenTiengVietCoDauThanhKhongDau](@strInput NVARCHAR(4000)) 
RETURNS NVARCHAR(4000)
AS
BEGIN     
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(4000)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)

    SET @SIGN_CHARS       = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'+NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'

    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
    SET @COUNTER = 1
 
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN   
      SET @COUNTER1 = 1
      --Tim trong chuoi mau
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN           
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)                   
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)    
              BREAK         
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tim tiep
       SET @COUNTER = @COUNTER +1
    END
    RETURN @strInput
END

SELECT f.ID AS [Mã khách hàng],f.FoodName AS [Tên món ăn],fc.CategoryName AS [Tên thức ăn],f.Price AS [Đơn giá]
FROM dbo.Food AS f, dbo.FoodCategory AS fc
WHERE f.FoodCategory = fc.ID
GO

DECLARE @foodName NVARCHAR(100) = N'Dưa'
SELECT * FROM dbo.Account WHERE dbo.ChuyenTiengVietCoDauThanhKhongDau(UserName) LIKE N'%'+dbo.ChuyenTiengVietCoDauThanhKhongDau(@foodName)+'%'
GO

CREATE PROC USP_ShowBill
@idTable INT
AS
BEGIN
	SELECT f.FoodName, bi.QuantityFood, f.Discount, f.Price*bi.QuantityFood-((f.Price*bi.QuantityFood)*(f.Discount/100)) AS totalPrice FROM BillInFo AS bi, Bill AS b, Food AS f WHERE bi.idBill = b.ID AND bi.idFood = f.ID AND b.idTable = @idTable AND b.Status = 0
END
GO

--tf.TableName AS [Bàn], b.DayCheckIn AS [Ngày vào], b.DayCheckOut AS [Ngày ra], b.Status AS [Tình trạng]
SELECT tf.TableName AS [Bàn], b.totalPrice AS [Tổng tiền], b.DayCheckIn AS [Ngày vào], b.DayCheckOut AS [Ngày ra], b.Status AS [Tình trạng] FROM dbo.Bill AS b, dbo.TableFood AS tf WHERE b.idTable = tf.ID AND b.DayCheckIn >= '20201001' AND b.DayCheckOut <= '20201031' AND b.Status = 1
GO