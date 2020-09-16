use PizzaStore;
Go;

Create TABLE Topping ( 
	ID int,
	Name varchar(255)
);

select * from Topping;

insert into Topping (ID, Name) values (1, 'Cheese');
insert into Topping (ID, Name) values (2, 'Pepperoni');
insert into Topping (ID, Name) values (3, 'Supreme');
