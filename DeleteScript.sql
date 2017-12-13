use PharmacyCourseProject;


----------------------------------------------------------------------------------

create procedure DeleteAllDrugs
as begin
delete Drugs
end

exec DeleteAllDrugs

drop procedure DeleteAllDrugs

-----------------------------------------------------------------------------------

create procedure DeleteAllMedic
as begin
delete Medications
end

exec DeleteAllMedic

drop procedure DeleteAllMedic

-------------------------------------------------------------------------------------

create procedure DeleteDrugs(@Id int)
as begin
	if(select Drugs.DrugID from Drugs where Drugs.DrugID = @Id) is not null
		delete Drugs where Drugs.DrugID = @Id
end

exec DeleteDrugs @Id = '75'

drop procedure DeleteDrugs

----------------------------------------------------------------------------------------

create procedure DeleteProducer(@ProdName nvarchar(50))
as begin
	if(select Producers.FirmName from Producers where Producers.FirmName = @ProdName) is not null
		delete Producers where Producers.FirmName = @ProdName
	end

exec DeleteProducer @ProdName = 'Teva'

select * from Producers

drop procedure DeleteProducer

----------------------------------------------------------------------------------------