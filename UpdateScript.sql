use PharmacyCourseProject;

create procedure UpdateMedications(@Name nvarchar(50),@ActiveSubstance nvarchar(50), @LeaveConditions nvarchar(20), @IssueForm nvarchar(500))
	as begin
	declare @MedicName nvarchar(50)
		
		set @MedicName = (select Medications.Name from Medications where Medications.Name = @Name)

		if(@MedicName is not null)
			begin
				if(@ActiveSubstance is not null)
					begin	
						update Medications set Medications.ActiveSubstance = @ActiveSubstance where Name = @Name
					end
				if(@LeaveConditions is not null)
					begin
						update Medications set Medications.LeaveConditions = @LeaveConditions where Name = @Name
					end
				if(@IssueForm is not null)
					begin
						update Medications set Medications.IssueForm = @IssueForm where Name = @Name
					end

			end	  
	end



drop procedure UpdateMedications

select * from Medications

-----------------------------------------------------

create procedure UpdateDrugs(@DrugID int, @Cost float, @Count int, @Discount int)
	as begin
	declare @Drug int
		set @Drug = (select Drugs.DrugID from Drugs where Drugs.DrugID = @DrugID) -- исключаем дублирование

		if(@Drug is not null)
			begin
				if(@Cost is not null)
				begin
					update Drugs set Drugs.Cost = @Cost where DrugID = @Drug
				end
				if(@Count is not null)
				begin
					update Drugs set Drugs.Count = @Count where DrugID = @Drug
				end
				if(@Discount is not null)
				begin
				if(select Discount.Discount from Discount where Discount.DrugId = @DrugID) is null
					insert into Discount values(@DrugID, @Discount)
				else
					update Discount set Discount.Discount = @Discount where Discount.DrugId = @DrugID

				end

			end

	end

select * from Drugs
select * from History
select * from Discount
drop procedure UpdateDrugs

exec UpdateDrugs @DrugID ='74', @Cost='190', @Count='120', @Discount='1'


