use PharmacyCourseProject;

DECLARE @pathName NVARCHAR(512)
SET @pathName = 'D:\BackUpDB\db_backup_' + Convert(varchar(8), GETDATE(), 112) + '.bak'
BACKUP DATABASE [PharmacyCourseProject] TO  DISK = @pathName WITH NOFORMAT, NOINIT,  NAME = N'db_backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
