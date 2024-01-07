CREATE PROC InsertImportInvoiceData
@provider_id INT,
@staff_id INT,
@import_time DATETIME 
AS
BEGIN
	INSERT INTO import_invoices(provider_id,staff_id,import_time) 
	VALUES(@provider_id,@staff_id,@import_time);
END;