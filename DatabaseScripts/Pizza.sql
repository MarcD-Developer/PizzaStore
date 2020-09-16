use PizzaStore;
Go;

Create TABLE Pizza ( 
	ID int NOT NULL PRIMARY KEY,
	Size varchar(255),
	Toppings varchar(255),
	CrustType varchar(255)
);

select * from Pizza;

insert into Pizza (ID, Size, Toppings, CrustType) values (1, 'Small', 'Cheese', 'New York');
insert into Pizza (ID, Size, Toppings, CrustType) values (2, 'Medium', 'Pepperoni', 'Sicilian');
insert into Pizza (ID, Size, Toppings, CrustType) values (3, 'Large', 'Supreme', 'Deep Dish');

update Pizza set ID = 3 where Size = 'Large';


Drop TABLE	Pizza;