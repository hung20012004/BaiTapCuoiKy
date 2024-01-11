CREATE PROCEDURE [dbo].[getManufactoryByID]
@id INT
AS
BEGIN
	SELECT * FROM manufactories
	WHERE @id=manufactory_id;
END;
