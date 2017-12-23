use PharmacyCourseProject;

-----------------------------------------------------------------

create Trigger Drugs_Insert
on Drugs
after insert
as	
insert into History(ProductId, Operation)
Select DrugID, 'Добавлен препарат ' + Name
From inserted
	
drop trigger Drugs_Insert

------------------------------------------------------------------

create trigger Drugs_Delete
on Drugs
After delete
as
insert into History(ProductId, Operation)
select DrugID, 'Удален препарат ' + Name
From deleted

drop trigger Drugs_Delete

------------------------------------------------------------------

create trigger Drugs_Update
on Drugs
after update
as
insert into History(ProductId, Operation)
select DrugID, 'Изменен препарат ' + Name
From inserted

drop trigger Drugs_Update

-------------------------------------------------------------------

select * from Drugs
select * from Discount
select * from History