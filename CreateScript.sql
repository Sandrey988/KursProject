use PharmacyCourseProject;
---------------------------

---------------------------------------------------------------------------------------------------------------------------------------------------

-- ���������� ��������� -- ����� ����������
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

exec AddMedications @Name = '�����������', @PharmachologicEffect = '����', @IndicationsForUse = '�������� ����', @ModeOfApplication = '������',
					@SideEffects = '���', @Contraindications = '������������', @Pregnancy = '�� ������������� ��� ������������',
					@DrugInteractions = '�� ��������� � ����� �����������', @Overdose = '���� � �������', @Composition = '���',
					@PharmacologicalGroup = '������������� ��������', @ActiveSubstance = '����', @LeaveConditions= '�� �������',
					@IssueForm = '��������', @StorageConditions = '� ����� �����'




----------------------------------------------------------------------------------------------------------------------------------------------

-- ���������� ������� -- ����� ���������� ���������
create procedure AddAnalogs(@DrugName nvarchar(50), @AnalogName nvarchar(50), @PharmacologicalGroup nvarchar(100))
as begin
declare @Name nvarchar(50)
declare @AlanogNamed nvarchar(50)
declare @PharmaGroup nvarchar(50)
set @Name =			(	
					select Name 
					from Medications 
					where Name = @DrugName 
					)

set @AnalogName =  (	
					select Name
					from Medications
					where Name = @AnalogName
				   )
select 

end
go

select * from Medications

declare @PharmacologicalGroup nvarchar(50) = '�������������';
select	t1.PharmacologicalGroup 
		from Medications t1 join Medications t2 on (t1.PharmacologicalGroup = @PharmacologicalGroup and t2.PharmacologicalGroup = @PharmacologicalGroup)




--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- ���������� �������������
create procedure AddProducers(@FirmName nvarchar(50), @Country nvarchar(50))
as begin
insert into Producers values(@FirmName, @Country)
end
go


--exec AddProducers @FirmName = '������������', @Country = '���'



----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--���������� ������ --����� ���������� ���������
create procedure AddDiscount(@DrugId int, @Discount int)
as begin

if @Discount >=0 and @DrugId

insert into Discount values(@DrugId, @Discount)
end
go

--exec AddDiscount @DrugId = '', @Discount = ''


----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- ���������� ����������
create procedure AddPharmaGroup(@PharmacologicalGroup nvarchar(100))
as begin
insert into PharmacologicalGroup values(@PharmacologicalGroup)
end
go

--exec AddPharmaGroup @PharmacologicalGroup = ''
--delete PharmacologicalGroup where PharmacologicalGroup = ''
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- ���������� ��������� -- ����� ���������� ���������
create procedure AddDrug (@Name nvarchar(50), @ManufactureDate date, @DisposeDate date, @Cost float, @ProducerId int, @Count int)
as begin

if @ManufactureDate < @DisposeDate and @Cost > 0  and @Count >= 0 and @ProducerId= @ProducerI


insert into Drugs values()
end
go



----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

