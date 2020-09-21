use PizzaStore;
Go;

Create TABLE Size ( 
	SizeID int,
	Name varchar(255)
);

select * from size;

insert into Size (SizeID, Name) values (1, 'Small');
insert into Size (SizeID, Name) values (2, 'Medium');
insert into Size (SizeID, Name) values (3, 'Large');
