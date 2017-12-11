use PharmacyCourseProject;
---------------------------

---------------------------------------------------------------------------------------------------------------------------------------------------

-- добавление аннотации -- после фармГруппы
create procedure AddMedications(@Name nvarchar(50), @PharmachologicEffect nvarchar(3000), @IndicationsForUse nvarchar(1000), @ModeOfApplication nvarchar(1000),
                                @SideEffects nvarchar(1000), @Contraindications nvarchar(1000), @Pregnancy nvarchar(1000), @DrugInteractions nvarchar(1000),
								@Overdose nvarchar(1000), @Composition nvarchar(1000), @PharmacologicalGroup nvarchar(100), @ActiveSubstance nvarchar(50),
								@LeaveConditions nvarchar(20), @IssueForm nvarchar(500), @StorageConditions nvarchar(500))
as begin
insert into Medications values (@Name, @PharmachologicEffect, @IndicationsForUse, @ModeOfApplication, @SideEffects, @Contraindications,
								@Pregnancy, @DrugInteractions, @Overdose, @Composition, @PharmacologicalGroup, @ActiveSubstance, 
								@LeaveConditions, @IssueForm, @StorageConditions)
end
go

exec AddMedications @Name = 'Илья', @PharmachologicEffect = 'Каеф', @IndicationsForUse = 'Головная боль', @ModeOfApplication = 'Внутрь',
					@SideEffects = 'Зуд', @Contraindications = 'Беременность', @Pregnancy = 'Не рекомендуется при беременности',
					@DrugInteractions = 'Не применимо с мазью вишневского', @Overdose = 'Боль в желудке', @Composition = 'Мел',
					@PharmacologicalGroup = 'Метаболики', @ActiveSubstance = 'Хрен', @LeaveConditions= 'По рецепту',
					@IssueForm = 'Таблетки', @StorageConditions = 'В сухом месте'




----------------------------------------------------------------------------------------------------------------------------------------------

-- добавление аналога -- после добавления препарата
create procedure AddAnalogs(@DrugName nvarchar(50), @AnalogName nvarchar(50))
as begin
declare @Name nvarchar(50)
declare @AnalogNamed nvarchar(50)
declare @PharmaGroup nvarchar(50)
declare @Id int
set @Name =			(	
					select PharmacologicalGroup 
					from Medications 
					where Name = @DrugName 
					)

set @AnalogNamed =  (	
				    select PharmacologicalGroup
					from Medications
					where Name = @AnalogName
				   )


	set @Id = ( select Analogs.Id from Analogs where	(Analogs.AnalogName = @DrugName and Analogs.DrugName = @AnalogName) or
														(Analogs.AnalogName = @AnalogName and Analogs.DrugName = @DrugName))

	if (@Name = @AnalogNamed) and (@DrugName <> @AnalogName) and @Id is null
		begin
			insert into Analogs values(@DrugName, @AnalogName)
		end
end
go

exec AddAnalogs @DrugName = 'Пашка', @AnalogName = 'Пашка'

delete Analogs;
drop procedure AddAnalogs
select * from Medications
select * from Analogs
select * from PharmacologicalGroup



--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- добавление производителя
create procedure AddProducers(@FirmName nvarchar(50), @Country nvarchar(50))
as begin
insert into Producers values(@FirmName, @Country)
end
go


--exec AddProducers @FirmName = 'ФармаГрупИнк', @Country = 'США'



----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--добавление скидки --после добавления препарата
create procedure AddDiscount(@DrugId int, @Discount int)
as begin

declare @DrugIq int;

set @DrugIq = (select Drugs.DrugID from Drugs where Drugs.DrugID = @DrugId)

if @Discount >=0 and @DrugId is not null

insert into Discount values(@DrugId, @Discount)
end
go

drop procedure AddDiscount

exec AddDiscount @DrugId = '45', @Discount = '50'
select * from Discount

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- добавление фармГруппы
create procedure AddPharmaGroup(@PharmacologicalGroup nvarchar(100))
as begin
insert into PharmacologicalGroup values(@PharmacologicalGroup)
end
go

--exec AddPharmaGroup @PharmacologicalGroup = ''
--delete PharmacologicalGroup where PharmacologicalGroup = ''
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- добавление препарата -- после добавления аннотации
create procedure AddDrug (@Name nvarchar(50), @ManufactureDate date, @DisposeDate date, @Cost float, @Count int, @FirmName nvarchar(50))
as begin

declare @Producer int
declare @Nick nvarchar(50) 
declare @Id int;

set @Nick =		( select Medications.Name from Medications where Medications.Name = @Name );
set @Producer = ( select Producers.ProducerID from Producers where Producers.FirmName = @FirmName );
set @Id =		( select Drugs.DrugID from Drugs where Drugs.Name = @Name and Drugs.ManufactureDate = @ManufactureDate and Drugs.DisposeDate = @DisposeDate and Drugs.Cost = @Cost and Drugs.ProducerId = @Producer)

-- добавление препаратов одной партии
if @Id is not null
	begin
		update Drugs set Drugs.Count = Drugs.Count + @Count where Drugs.DrugID = @Id
	end
	else
	begin


if @Producer <> 0 and @Nick is  not null
	begin
		print 'Hello'
		if @ManufactureDate < @DisposeDate and @Cost > 0  and @Count >= 0 
			insert into Drugs values(@Name, @ManufactureDate, @DisposeDate, @Cost, @Producer,  @Count)
	end

	end
end
go

exec AddDrug @Name = 'Илья', @ManufactureDate = '10-10-2017', @DisposeDate = '20-10-2019', @Cost = '150', @Count = '100', @FirmName = 'Фармак'
drop procedure AddDrug
select * from Drugs
delete Drugs;
select * from Medications
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

