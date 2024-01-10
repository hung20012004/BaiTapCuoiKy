CREATE PROCEDURE getInvoiceDetailByID
@ID int
AS
BEGIN
	SELECT *
	FROM invoice_detail
	WHERE invoice_id=@ID;
END;
exec getOrderDetailByID 7