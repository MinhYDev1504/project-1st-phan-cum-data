USE FacebookUsers;
GO
--Dynamic SQL create Table BinaryUsers
DECLARE @DynamicSQL nvarchar(4000);
IF OBJECT_ID('BinaryUsers') IS NOT NULL
    DROP TABLE BinaryUsers;
SET @DynamicSQL = 'CREATE TABLE BinaryUsers ([UserID] int,[UserName] nvarchar(255),'
	SELECT @DynamicSQL = @DynamicSQL + '[' + CAST(TenGT as nvarchar) + '] int default 0,'
	FROM GioiTinh;
    SELECT @DynamicSQL = @DynamicSQL + '[HT_' + CONVERT(nvarchar,TenCity)+ '] int default 0,'
    FROM ThanhPho;
	SELECT @DynamicSQL = @DynamicSQL + '[NL_' + CONVERT(nvarchar,TenCity) + '] int default 0,'
    FROM ThanhPho;
DECLARE @DynamicSQL2 nvarchar(4000);
SET @DynamicSQL2=''
	SELECT @DynamicSQL2 = @DynamicSQL2 +'[BM_' + CONVERT(nvarchar,ThangSN) + '] int default 0,'
    FROM SinhNhat;
	SELECT @DynamicSQL2 = @DynamicSQL2 + '[' + CONVERT(nvarchar,TenTTTC) + '] int default 0,'
    FROM TrangThaiTinhCam;
DECLARE @DynamicSQL3 nvarchar(4000);
	SET @DynamicSQL3 =
	'[Nhi Dong] int default 0,'
	+'[Thieu Nien] int default 0,'
	+'[Thanh Nien] int default 0,'
	+'[Trung Nien] int default 0,'
	+'[Ngưoi Gia] int default 0,'
	+'[FR_Qua It] int default 0,'
	+'[FR_It] int default 0,'
	+'[FR_Kha It] int default 0,'
	+'[FR_Trung Binh] int default 0,'
	+'[FR_Kha Nhieu] int default 0,'
	+'[FR_Nhieu] int default 0,'
	+'[FR_Qua Nhieu] int default 0,'
	+'[FO_Qua It] int default 0,'
	+'[FO_It] int default 0,'
	+'[FO_Kha It] int default 0,'
	+'[FO_Trung Binh] int default 0,'
	+'[FO_Kha Nhieu] int default 0,'
	+'[FO_Nhieu] int default 0,'
	+'[FO_Qua Nhieu] int default 0);';
EXEC (@DynamicSQL+@DynamicSQL2+@DynamicSQL3);
GO
SELECT * FROM BinaryUsers;
GO
INSERT INTO BinaryUsers (UserID, UserName)
SELECT UserID, UserName
FROM Users;
GO
SELECT * FROM BinaryUsers;
GO
--CREATE VIEW Get EncryptedUsers
IF OBJECT_ID('viewEncryptedUsers') IS NOT NULL
    DROP VIEW viewEncryptedUsers;
GO
CREATE VIEW viewEncryptedUsers
AS
SELECT	u.UserID,u.UserName,u.Sex AS sSex,gt.MaGT AS Sex,
		u.Age,sn.MaSN AS Birthday,u.Hometown AS sHometown,
		tp.MaCity AS Hometown,tp2.MaCity AS NowLiving,u.NowLiving AS sNowLiving,
		u.SoBanBe,u.TrangThaiTinhCam AS sTrangThaiTinhCam, tttc.MaTTTC AS TrangThaiTinhCam,u.Followers
FROM Users AS u
JOIN SinhNhat AS sn ON DATEPART(mm,u.BirthDay) = sn.ThangSN
JOIN GioiTinh AS gt ON u.Sex = gt.TenGT
JOIN ThanhPho AS tp ON u.Hometown = tp.TenCity
JOIN ThanhPho AS tp2 ON u.NowLiving = tp2.TenCity
JOIN TrangThaiTinhCam AS tttc ON u.TrangThaiTinhCam = tttc.TenTTTC
GO
SELECT * FROM viewEncryptedUsers;
--Update For BinaryUsers
USE FacebookUsers;
DECLARE	@vUserID int,
		@vGioiTinh nvarchar(50),
		@vHometown nvarchar(50),
		@vNowLiving nvarchar(50),
		@vBirthdayMonth nvarchar(50),
		@vLoveStatus nvarchar(50),
		@vAgeType int,
		@vFriendsType int,
		@vFollowersType int

DECLARE MyCursor CURSOR --Khai báo CUSSOR
FOR
    SELECT v.UserID ,v.sSex, v.sHometown, v.sHometown, v.Birthday, v.sTrangThaiTinhCam, v.Age, v.SoBanBe, v.Followers
	FROM viewEncryptedUsers AS v
OPEN MyCursor;
FETCH NEXT FROM MyCursor INTO  
		@vUserID, @vGioiTinh,@vHometown,
		@vNowLiving,@vBirthdayMonth,@vLoveStatus, 
		@vAgeType,@vFriendsType,@vFollowersType
WHILE @@FETCH_STATUS <> -1
	BEGIN
		DECLARE @DynamicUpdateSQL nvarchar(4000);
		DECLARE @DynamicUpdateSQL2 nvarchar(4000);
		SET @DynamicUpdateSQL = 'UPDATE BinaryUsers SET '+ 
		'['+@vGioiTinh+'] = 1,'+
		'[HT_'+@vHometown+'] = 1,'+
		'[NL_'+@vNowLiving+'] = 1,'+
		'[BM_'+@vBirthdayMonth+'] = 1,'+
		'['+@vLoveStatus+'] = 1 ,'
		
		SET @DynamicUpdateSQL2='';
		IF @vAgeType <= 9 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[Nhi Dong] = 1 ,';
		IF @vAgeType > 9 AND @vAgeType <=15 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[Thieu Nien] = 1 ,';
		IF @vAgeType > 15 AND @vAgeType <=32 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[Thanh Nien] = 1 ,';
		IF @vAgeType > 32 AND @vAgeType <=50 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[Trung Nien] = 1 ,';
		IF @vAgeType > 50 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[Nguoi Gia] = 1 ,';
		IF @vFriendsType <=100 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[FR_Qua It] = 1, ';
		IF @vFriendsType >100 AND @vFriendsType<=500 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[FR_It] = 1, ';
		IF @vFriendsType >500 AND @vFriendsType<=1000 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[FR_Kha It] = 1, ';
		IF @vFriendsType >1000 AND @vFriendsType<=2000 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[FR_Trung Binh] = 1, ';
		IF @vFriendsType >2000 AND @vFriendsType<=3000 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[FR_Kha Nhieu] = 1, ';
		IF @vFriendsType >3000 AND @vFriendsType<=5000 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[FR_Nhieu] = 1, ';
		IF @vFriendsType >5000 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[FR_Qua Nhieu] = 1, ';
		IF @vFollowersType <=100 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[FO_Qua It] = 1 ';
		IF @vFollowersType >100 AND @vFollowersType<=500 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[FO_It] = 1 ';
		IF @vFollowersType >500 AND @vFollowersType<=1000 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[FO_Kha It] = 1 ';
		IF @vFollowersType >1000 AND @vFollowersType<=2000 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[FO_Trung Binh] = 1 ';
		IF @vFollowersType >2000 AND @vFollowersType<=3000 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[FO_Kha Nhieu] = 1 ';
		IF @vFollowersType >3000 AND @vFollowersType<=5000 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[FO_Nhieu] = 1 ';
		IF @vFollowersType >5000 SET @DynamicUpdateSQL2 = @DynamicUpdateSQL2 +'[FO_Qua Nhieu] = 1 '
		SET @DynamicUpdateSQL2=@DynamicUpdateSQL2+' WHERE UserID ='+CAST(@vUserID AS nvarchar)+';';
		EXEC (@DynamicUpdateSQL+@DynamicUpdateSQL2)
		FETCH NEXT FROM MyCursor INTO  
				@vUserID, @vGioiTinh,@vHometown,
				@vNowLiving,@vBirthdayMonth,@vLoveStatus, 
				@vAgeType,@vFriendsType,@vFollowersType	
END;
CLOSE MyCursor;
DEALLOCATE MyCursor;
GO
--Xem lại kết quả sau khi update
SELECT * FROM BinaryUsers;
GO
	
