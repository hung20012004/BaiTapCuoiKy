CREATE PROC getProviderByID
@provider_id INT
AS
BEGIN
	SELECT * FROM providers
	WHERE provider_id = @provider_id
END;
EXEC GetOrder