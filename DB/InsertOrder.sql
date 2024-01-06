CREATE PROC InsertOrder
@customer_id INT,
@seller_id INT,
@order_date DATETIME 
AS
BEGIN
	INSERT INTO orders(customer_id,seller_id,order_date,status,accoutant_id,payment) VALUES(@customer_id,@seller_id,@order_date,0,0,0);
END;
EXEC InsertOrder 
DROP PROC InsertOrder
SET IDENTITY_INSERT orders OFF

