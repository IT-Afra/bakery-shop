CREATE PROCEDURE [dbo].[Login]
	@Email nvarchar(100),
	@Password nvarchar(50)
AS
begin
	if(EXISTS(select * from usrCostumer where Email=@Email and Password=@Password))
		begin
			select * from usrCostumer where Email=@Email and Password=@Password
			RETURN 1
		end
	else if(EXISTS(select * from usrBaker where Email=@Email and Password=@Password))
		begin
			select * from usrBaker where Email=@Email and Password=@Password 
			RETURN 1
		end
	else
		begin
			RETURN 0
		end

end

