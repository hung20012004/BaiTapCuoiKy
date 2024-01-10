CREATE PROC InsertImportInvoiceData
@provider_id INT,
@staff_id INT,
@import_time DATETIME 
AS
BEGIN
	INSERT INTO import_invoices(provider_id,staff_id,import_time,accoutant_id,status) 
	VALUES(@provider_id,@staff_id,@import_time,0,1);
END;
drop proc InsertImportInvoiceData