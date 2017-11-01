Use FacebookUsers;
GO
DROP PROCEDURE IF EXISTS uspGetEncryptedBinaryUser
GO
CREATE PROCEDURE dbo.uspGetEncryptedBinaryUser
AS
SELECT	*
FROM BinaryUsers
GO