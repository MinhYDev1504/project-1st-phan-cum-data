Use FacebookUsers;
GO
CREATE PROCEDURE dbo.uspGetEncryptedUser
AS
SELECT	u.UserID,u.UserName,gt.MaGT AS Sex,
		u.Age,sn.MaSN AS Birthday,
		tp.MaCity AS Hometown,tp2.MaCity AS NowLiving,
		u.SoBanBe,tttc.MaTTTC AS TrangThaiTinhCam,u.Followers
FROM Users AS u
JOIN SinhNhat AS sn ON DATEPART(mm,u.BirthDay) = sn.ThangSN
JOIN GioiTinh AS gt ON u.Sex = gt.TenGT
JOIN ThanhPho AS tp ON u.Hometown = tp.TenCity
JOIN ThanhPho AS tp2 ON u.NowLiving = tp2.TenCity
JOIN TrangThaiTinhCam AS tttc ON u.TrangThaiTinhCam = tttc.TenTTTC
GO
EXEC uspGetEncryptedUser;