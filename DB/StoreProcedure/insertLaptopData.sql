CREATE PROCEDURE InsertLaptopData
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
	INSERT INTO laptops(laptop_name,category_id,manufactory_id,CPU,RAM,hard_drive,VGA,display,battery,weight,materials,ports,network_and_connection,security,keyboard,audio,size,OS,warranty_period,price,quantity)
	VALUES(@name,@category_id,@manufactory_id,@CPU,@RAM,@hard_drive,@VGA,@display,@battery,@weight,@material,@ports,@connection,@security,@keyboard,@audio,@size,@OS,@warranty_period,@price,@quantity);
END;
DROP PROC InsertLaptopData;