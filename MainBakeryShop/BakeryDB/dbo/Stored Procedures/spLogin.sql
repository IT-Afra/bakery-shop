CREATE PROCEDURE [dbo].[Login]
	@Email nvarchar(100),
	@UserName nvarchar(50),
	@Password nvarchar(50)
AS
begin
	if(EXISTS(select * from usrCostumer where(Email=@Email or  UserName=@UserName) and  Password=@Password))
		begin
			select * from usrCostumer where (Email=@Email or  UserName=@UserName) and  Password=@Password
			RETURN 1
		end
	else if(EXISTS(select * from usrBaker where (Email=@Email or  UserName=@UserName) and  Password=@Password))
		begin
			select * from usrBaker where (Email=@Email or  UserName=@UserName) and  Password=@Password  
			RETURN 2
		end
	else
		begin
			RETURN 0
		end

end

