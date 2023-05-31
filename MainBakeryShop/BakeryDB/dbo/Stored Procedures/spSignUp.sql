CREATE PROCEDURE [dbo].[SignUp]
    @UserRole nvarchar(50),
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
	DECLARE @IsUserRoleNull bit;
	DECLARE @IsFirstNameNull bit;
    DECLARE @IsLastNameNull bit; 
    DECLARE @IsAddressNull bit; 
    DECLARE @IsCityNull bit;
    DECLARE @IsPhoneNull bit; 
    DECLARE @IsUserNameNull bit; 
    DECLARE @IsPasswordNull bit; 
    DECLARE @IsEmailNull bit;

	SELECT  @IsUserRoleNull = [dbo].[IsNullOrEmpty](@UserRole);
	SELECT  @IsFirstNameNull = [dbo].[IsNullOrEmpty](@FirstName);
	SELECT  @IsLastNameNull = [dbo].[IsNullOrEmpty](@LastName);
	SELECT  @IsAddressNull = [dbo].[IsNullOrEmpty](@Address);
	SELECT  @IsCityNull = [dbo].[IsNullOrEmpty](@City);
	SELECT  @IsPhoneNull = [dbo].[IsNullOrEmpty](@Phone);
	SELECT  @IsUserNameNull = [dbo].[IsNullOrEmpty](@UserName);
	SELECT  @IsPasswordNull = [dbo].[IsNullOrEmpty](@Password);
	SELECT  @IsEmailNull = [dbo].[IsNullOrEmpty](@Email);

	if(@IsUserRoleNull = 1)
		begin
			select 'UnkonwnUserRole' as Id;
			return 0;
		end
	else
	begin
		if(@UserRole = N'Baker')
			begin
				if(@IsFirstNameNull = 0 and @IsLastNameNull = 0 and @IsAddressNull = 0
				 and @IsPhoneNull = 0 and @IsUserNameNull = 0
				 and @IsPasswordNull = 0 and @IsEmailNull = 0    )
					begin
						 INSERT INTO [dbo].[usrBaker]
									([FirstName]
									,[MiddleName]
									,[LastName]
									,[Address]
									,[Phone]
									,[UserName]
									,[Password]
									,[Email])
							  VALUES
									(@FirstName
									,@MiddleName
									,@LastName
									,@Address
									,@Phone
									,@UserName
									,@Password
									,@Email)
						select SCOPE_IDENTITY() as Id;
						return 1;	
					end
				else
					begin
						select 'SomeNullValuesExists' as Id;
						return 0;
					end
			end
			else if(@UserRole = N'User')
			begin
				if(@IsFirstNameNull = 0 and @IsLastNameNull = 0 and @IsAddressNull = 0
				 and @IsCityNull = 0 and @IsPhoneNull = 0 and @IsUserNameNull = 0
				 and @IsPasswordNull = 0 and @IsEmailNull = 0    )
					begin
						 INSERT INTO [dbo].[usrCostumer]
									([FirstName]
									,[MiddleName]
									,[LastName]
									,[Address]
									,[City]
									,[Phone]
									,[UserName]
									,[Password]
									,[Email])
							  VALUES
									(@FirstName
									,@MiddleName
									,@LastName
									,@Address
									,@Phone
									,@City
									,@UserName
									,@Password
									,@Email)
						select SCOPE_IDENTITY() as Id;
						return 2;
					end
				else
					begin
						select 'SomeNullValuesExists' as Id;
						return 0;
					end
			end
			else
			begin
				select 'InvalidUserType' Id;
				return 0;
			end
	end
end
	
RETURN 0
