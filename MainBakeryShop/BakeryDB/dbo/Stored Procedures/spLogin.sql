CREATE PROCEDURE [dbo].[Login]
	@Email nvarchar(100),
	@UserName nvarchar(50),
	@Password nvarchar(50)
AS
begin
	if(EXISTS(select * from usrCostumer where(Email=@Email or  UserName=@UserName) and  Password=@Password))
		begin
			select * from usrCostumer where (Email=@Email or  UserName=@UserName) and  Password=@Password
			RETURN "User"
		end
	else if(EXISTS(select * from usrBaker where (Email=@Email or  UserName=@UserName) and  Password=@Password))
		begin
			select * from usrBaker where (Email=@Email or  UserName=@UserName) and  Password=@Password  
			RETURN "Baker"
		end
	else
		begin
			RETURN "NotFound"
		end

end

