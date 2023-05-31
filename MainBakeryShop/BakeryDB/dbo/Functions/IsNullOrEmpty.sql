CREATE FUNCTION [dbo].[IsNullOrEmpty](@String NVARCHAR(50)) 
RETURNS bit
As
Begin
    
	Declare @res bit;

	if(ISNULL(LTRIM(RTRIM(@String)),'')='')
		begin
			set @res = 1;
		end
	else
		begin
			set @res = 0;
		end

	Return @res;
End