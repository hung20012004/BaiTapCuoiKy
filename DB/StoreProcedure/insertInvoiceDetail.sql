CREATE PROC InsertInvoiceDetail
@invoice_id INT,
@quantity_import INT,
@laptop_id INT

AS
BEGIN
	INSERT INTO invoice_detail(invoice_id,quantity,laptop_id) VALUES (@invoice_id,@quantity_import,@laptop_id)
END;
drop proc InsertInvoiceDetail
EXEC InsertOrderDetail 2,5,188	