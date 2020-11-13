CREATE PROCEDURE updateEmpNameById
 @ename NVARCHAR(Max), 
 @eid INT
 AS
 BEGIN
	UPDATE dbo.Employee SET  Name = @ename WHERE id = @eid
 END