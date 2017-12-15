use PharmacyCourseProject;

---------------------------------------------------------------------------------------------------------
exec  SP_HELPINDEX 'Producers'

CREATE PROC insertProcuderFromXML 
@path nvarchar(256) 
AS 
begin 
SET NOCOUNT ON 
SET XACT_ABORT ON 

BEGIN TRAN 

declare @results table (x xml) 
declare @sql nvarchar(300)= 
'SELECT 
CAST(REPLACE(CAST(x AS VARCHAR(MAX)), ''encoding="utf-16"'', ''encoding="utf-8"'') AS XML) 
FROM OPENROWSET(BULK '''+@path+''', SINGLE_BLOB) AS T(x)'; 

INSERT INTO @results EXEC (@sql) 

declare @xml XML = (SELECT TOP 1 x from @results); 

INSERT INTO Producers(FirmName, County) 
SELECT 
C3.value('Firm_Names[1]', 'NVARCHAR(50)') AS FirmName, 
C3.value('Country_Names[1]', 'NVARCHAR(50)') AS County 
FROM @xml.nodes('Root/Order') AS T3(C3) 

COMMIT; 
end; 
GO

exec insertProcuderFromXML 'D:\Pharmacy\comp.xml'

select Producers.FirmName from Producers
delete Producers
drop procedure insertProcuderFromXML

-----------------------------------------------------------------------------------------------------------------------------------
--план запроса
--todo index

CREATE index #EX_TKEY on Producers(FirmName) 
drop index #EX_TKEY on Producers