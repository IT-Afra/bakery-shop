CREATE PROCEDURE [dbo].[SignUp]
    @FirstName NVARCHAR(50) , 
    @MiddleName NVARCHAR(50) , 
    @LastName NVARCHAR(50) , 
    @Address NVARCHAR(250) , 
    @City NVARCHAR(50), 
    @Phone NVARCHAR(50) , 
    @UserName NVARCHAR(50), 
    @Password NVARCHAR(50) , 
    @Email NVARCHAR(100) 
AS
begin
      (select * from usrCostumer where FirstName=@FirstName and MiddleName = @MiddleName and LastName=@LastName and Address=@Address and City=@City and Phone=@Phone and  UserName=@UserName and  Password=@Password and Email=@Email)
SELECT @param1, @param2
scope_
end
	
RETURN 0
