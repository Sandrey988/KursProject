use PharmacyCourseProject;

---------------------------------------------------------------------------------------------------------

CREATE PROC insertCountryFromXML 
	@path nvarchar(256)
AS 
begin
	SET NOCOUNT ON  
	SET XACT_ABORT ON  

	declare @count1 int=0;
	declare @count2 int=0;
	set @count1 = (select count(*) from Producers)
		
	BEGIN TRAN

	declare @results table (x xml)			
	declare @sql nvarchar(300)=
               'SELECT 
		CAST(REPLACE(CAST(x AS VARCHAR(MAX)), ''encoding="utf-16"'', ''encoding="utf-8"'') AS XML)
		FROM OPENROWSET(BULK '''+@path+''', SINGLE_BLOB) AS T(x)'; 
 
	INSERT INTO @results EXEC (@sql) 

	declare @xml XML = (SELECT  TOP 1 x from  @results);

	declare @ad nvarchar(50);
	set @ad = 
	(	SELECT 
		C3.value('Country_Names[1]', 'NVARCHAR(100)') AS [Country]
		FROM @xml.nodes('Root/Order') AS T3(C3) );

		if @ad is null
		begin
	INSERT INTO [Producers]([FirmName]) 
		SELECT 
		C3.value('Country_Names[1]', 'NVARCHAR(100)') AS [Country]
		FROM @xml.nodes('Root/Order') AS T3(C3) 
	end;
	COMMIT;
	set @count2 = (select count(*) from Producers)
	return @count2 - @count1;
end;
GO


exec insertCountryFromXML 'D:\Pharmacy\producer.xml'

select * from Producers

drop procedure insertCountryFromXML

-----------------------------------------------------------------------------------------------------------------------------------