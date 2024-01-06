CREATE PROC UpdateOrder
@order_id INT,
@payment INT,
@status INT,
@accountant_id INT
AS
BEGIN
    UPDATE orders 
	SET payment = @payment, status = @status, accoutant_id = @accountant_id
	WHERE order_id = @order_id
END;
DROP PROC UpdateOrder