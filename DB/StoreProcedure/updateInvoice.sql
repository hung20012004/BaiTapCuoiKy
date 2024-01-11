CREATE PROC updateInvoice
@invoice_id INT,
@update_status_date DATETIME,
@accountant_id INT,
@status INT
AS
BEGIN
    UPDATE import_invoices 
	SET accoutant_id = @accountant_id,
		status=@status,
		update_status_time=@update_status_date
	WHERE invoice_id = @invoice_id
END;
exec updateInvoice 1,2,0,1
DROP PROC updateInvoice 