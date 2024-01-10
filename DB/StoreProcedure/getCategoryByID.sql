CREATE PROCEDURE getCategoryByID
@id INT
AS
BEGIN
	SELECT * FROM categories
	where category_id=@id;
END;
EXEC GetCustomer;
DROP PROC GetCustomer