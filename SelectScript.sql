use PharmacyCourseProject;
----------------------------


--SELECT ALL
----------------------------------------------
-- Discount
create procedure SelectAllDiscount
	as begin
		select * from Discount
	end

exec SelectAllDiscount

drop procedure SelectAllDiscount

------------------------------------------------
-- PharmacologicalGroup
create procedure SelectAllPharmacologicalGroup
	as begin
	   select * from PharmacologicalGroup
	end	

exec SelectAllPharmacologicalGroup

drop procedure SelectAllPharmacologicalGroup

--------------------------------------------------
-- Drugs
create procedure SelectAllDrugs
	as begin
	   select * from Drugs
	end	

exec SelectAllDrugs

drop procedure SelectAllDrugs
--------------------------------------------------
-- Medications
create procedure SelectAllMedications
	as begin
	   select * from Medications
	end	

exec SelectAllMedications

drop procedure SelectAllMedications

---------------------------------------------------
-- Producers
create procedure SelectAllProducers
	as begin
		select * from Producers
	end

exec SelectAllProducers

drop procedure SelectAllProducers

---------------------------------------------------
-- Analogs
create procedure SelectAllAnalogs
	as begin
		select * from Analogs
	end

exec SelectAllAnalogs

drop procedure SelectAllAnalogs

---------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- Search Drugs 

---------------------------------------------------------------
-- Name

create procedure SelectName(@Name nvarchar(50))
	as begin
		select * from Drugs where Drugs.Name = @Name
	end

exec SelectName @Name = 'Андрей'

drop procedure SelectName

---------------------------------------------------------------
-- Producers

create procedure SelectProducers(@Producer int)
	as begin
		select * from Drugs where Drugs.ProducerId = @Producer
	end

exec SelectProducers @Producer = '2'

drop procedure SelectProducers

----------------------------------------------------------------
-- ActiveSubstance

create procedure SelectSubstance(@ActiveSubstance nvarchar(50))
	as begin
		select distinct Drugs.* from Drugs inner join Medications on Medications.ActiveSubstance = @ActiveSubstance and Drugs.Name = Medications.Name
	end

exec SelectSubstance @ActiveSubstance = 'Макароны'

drop procedure SelectSubstance

------------------------------------------------------------------
-- Analogs
create procedure SelectAnalogs(@Analogs nvarchar(50))
	as begin
		select distinct Drugs.* from Drugs inner join Analogs on Analogs.AnalogName =  @Analogs and Drugs.Name = Analogs.DrugName
	end

exec SelectAnalogs @Analogs = 'Илья'

drop procedure SelectAnalogs

-------------------------------------------------------------------
--Cost
create procedure SelectCost(@CostMin int, @CostMax int = null)
	as begin
	if @CostMax is not null
		select * from Drugs where Drugs.Cost between @CostMin and @CostMax 
	else
		select * from Drugs where Drugs.Cost = @CostMin
	end

select * from Drugs

exec SelectCost @CostMin = '150' , @CostMax = '200'

drop procedure SelectCost


