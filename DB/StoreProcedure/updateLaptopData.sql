CREATE PROCEDURE UpdateLaptopData
	@id INT,
	@name VARCHAR(100),
	@category_id INT,
	@manufactory_id INT,
	@CPU VARCHAR(100),
	@RAM VARCHAR(100),
	@hard_drive VARCHAR(100),
	@VGA VARCHAR(100),
	@display VARCHAR(255),
	@battery VARCHAR(255),
	@weight FLOAT,
	@material VARCHAR(100),
	@ports VARCHAR(2000),
	@connection VARCHAR(200),
	@security VARCHAR(100),
	@keyboard VARCHAR(100),
	@audio VARCHAR(100),
	@size VARCHAR(100),
	@OS VARCHAR(100),
	@warranty_period VARCHAR(100),
	@price VARCHAR(100),
	@quantity INT
AS
BEGIN
	UPDATE laptops
	SET
	laptop_name=@name,
	category_id = @category_id,
	manufactory_id=@manufactory_id,
	CPU=@CPU,
	RAM=@RAM,
	hard_drive=@hard_drive,
	VGA=@VGA,
	display=@display,
	battery=@battery,
	weight=@weight,
	materials=@material,
	ports=@ports,
	network_and_connection=@connection,
	security=@security,
	keyboard=@keyboard,
	audio=@audio,
	size=@size,
	OS=@OS,
	warranty_period=@warranty_period,
	price=@price,
	quantity=@quantity
	WHERE laptop_id=@id;
END;