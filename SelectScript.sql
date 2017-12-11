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