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
SET @DynamicSQL2 = @DynamicSQL2 + ');';
EXEC (@DynamicSQL+@DynamicSQL2);
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
		@vLoveStatus nvarchar(50)

DECLARE MyCursor CURSOR --Khai báo CUSSOR
FOR
    SELECT v.UserID ,v.sSex, v.sHometown, v.sHometown, v.Birthday, v.sTrangThaiTinhCam  
	FROM viewEncryptedUsers AS v
OPEN MyCursor;
FETCH NEXT FROM MyCursor INTO  @vUserID, @vGioiTinh,@vHometown,@vNowLiving,@vBirthdayMonth,@vLoveStatus;
WHILE @@FETCH_STATUS <> -1
	BEGIN
		DECLARE @DynamicUpdateSQL nvarchar(4000);
		SET @DynamicUpdateSQL = 'UPDATE BinaryUsers SET '+ 
		'['+@vGioiTinh+'] = 1,'+
		'[HT_'+@vHometown+'] = 1,'+
		'[NL_'+@vNowLiving+'] = 1,'+
		'[BM_'+@vBirthdayMonth+'] = 1,'+
		'['+@vLoveStatus+'] = 1 '+
		'WHERE UserID ='+CAST(@vUserID AS nvarchar)+';'
		PRINT @DynamicUpdateSQL;
		EXEC (@DynamicUpdateSQL)
		FETCH NEXT FROM MyCursor INTO  @vUserID, @vGioiTinh,@vHometown,@vNowLiving,@vBirthdayMonth,@vLoveStatus;
	END;
CLOSE MyCursor;
DEALLOCATE MyCursor;
GO
SELECT * FROM BinaryUsers;
GO
SELECT v.UserID ,v.sSex, v.sHometown, v.sHometown, v.Birthday, v.sTrangThaiTinhCam  
FROM viewEncryptedUsers AS v;	