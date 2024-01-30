CREATE PROC [dbo].[pr_AddOrder]
@Surname NVARCHAR (50),
@Name NVARCHAR (50),
@Patronymic NVARCHAR (50),
@Num NVARCHAR (20),
@City NVARCHAR (50),
@Street NVARCHAR (50),
@House NVARCHAR (10),
@Apartment NVARCHAR (10),
@ID INT  OUTPUT
AS
BEGIN
	INSERT INTO [dbo].[Order]
	(surname, name, patronymic, number, city, street, house, apartment)
	VALUES (@Surname, @Name, @Patronymic, @Num, @City, @Street, @House, @Apartment);
END