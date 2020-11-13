CREATE PROCEDURE insertEmployee
                        
       @ename     NVARCHAR(Max), 
       @eslary    float
AS 
BEGIN 
  INSERT INTO dbo.Employee( Name ,Salary )    VALUES (  @ename, @esalary )
 End