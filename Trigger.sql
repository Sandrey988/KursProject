use PharmacyCourseProject;

-----------------------------------------------------------------

create Trigger Drugs_Insert
on Drugs
after insert
as	
insert into History(ProductId, Operation)
Select DrugID, '�������� �������� ' + Name
From inserted
	
drop trigger Drugs_Insert

------------------------------------------------------------------

create trigger Drugs_Delete
on Drugs
After delete
as
insert into History(ProductId, Operation)
select DrugID, '������ �������� ' + Name
From deleted

drop trigger Drugs_Delete

------------------------------------------------------------------
--TODO Update Tridder










