use PizzaStore;
Go;

Create TABLE CrustType ( 
	ID int,
	Name varchar(255)
);

select * from CrustType;

insert into CrustType (ID, Name) values (1, 'New York');
insert into CrustType (ID, Name) values (2, 'Sicilian');
insert into CrustType (ID, Name) values (3, 'Deep Dish');
