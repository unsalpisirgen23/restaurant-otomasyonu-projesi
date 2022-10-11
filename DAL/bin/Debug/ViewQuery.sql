/*
SELECT 
(case when (select COUNT(ID) from Payments) > 0 then (select PlugID from Payments S where S.PlugID = P.ID) else '0' end) as 'Payments_ID',*
FROM Orders O 
 join Plugs P on P.ID = O.PlugID
 */

 /*
 SELECT * FROM Orders O join Plugs P on P.ID = O.PlugID or (select PlugID  from Payments).PlugID != P.ID
 */

 /*
 IF(SELECT count(*) FROM dbo.Payments) > 0
BEGIN


select 
O.ID as 'Order_ID',
O.PlugID as 'Order_PlugID',
P.ID as 'Plug_ID',
P.TableID as 'Plug_TableID',
P.ParentID as 'Plug_ParentID'
from Orders O 
inner join Plugs P on P.ID = O.PlugID
where P.ID = O.PlugID



END 
ELSE
BEGIN

declare @plugID int

set @plugID = (select ID from Plugs)

select @plugID
go;

*/

/*
select O.ID as 'OrderID',O.PlugID as 'OrderPlugID',P.ID as 'PlugID',P.TableID as 'PlugTableID' from Orders O 
inner join Plugs  P on P.ID = O.PlugID  
where  P.ID = O.PlugID and P.TableID = 2
*/
 
 /*
 CREATE PROCEDURE SpOrderIsNullInsertPlug (@PlugID int,@AddDate DateTime,@ParentID int,@SessionMovementLoginID int,@TableID int)
AS 
begin 
 if(select COUNT(O.ID) from Orders O where O.PlugID = @PlugID) > 0 and (select COUNT(S.ID) from Payments S where S.PlugID != @PlugID) < 1
 begin
 select * from Plugs where ID = @PlugID
 end
 else
 begin
  insert into Plugs (AddDate,ParentID,SeriNo,SessionMovementLoginID,TableID)Values(@AddDate,@ParentID,NEWID(),@SessionMovementLoginID,@TableID)
 end;
END;
go
*/
/*
 exec dbo.SpOrderIsNullInsertPlug 7,0,1,2



CREATE PROCEDURE SpOrderStatusOfTable (@TableID int)
AS 
begin 
select O.ID as 'OrderID',O.PlugID as 'OrderPlugID',P.ID as 'PlugID',P.TableID as 'PlugTableID' from Orders O 
inner join Plugs  P on P.ID = O.PlugID  
where  P.ID = O.PlugID and P.TableID = @TableID
END;

go
*/



exec dbo.SpOrderStatusOfTable 2
 



/*
select 
O.ID as 'Order_ID',
O.PlugID as 'Order_PlugID',
P.ID as 'Plug_ID',
P.TableID as 'Plug_TableID',
P.ParentID as 'Plug_ParentID'
from Orders O 
inner join Plugs P on P.ID = O.PlugID
where P.ID = O.PlugID
 */



 /*

   if(SELECT COUNT(*) FROM dbo.Orders O inner join Payments P on P.PlugID = O.PlugID where O.PlugID = P.PlugID) > 0
  BEGIN
  SELECT 1
  END;
*/

/*

IF(SELECT count(*) FROM dbo.Payments) > 0
BEGIN
select 
O.ID as 'Order_ID',
O.PlugID as 'Order_PlugID',
P.ID as 'Plug_ID',
P.TableID as 'Plug_TableID',
P.ParentID as 'Plug_ParentID'
from Orders O 
inner join Plugs P on P.ID = O.PlugID
where P.ID = O.PlugID
END 
ELSE
BEGIN
select 
O.ID as 'Order_ID',
O.PlugID as 'Order_PlugID',
P.ID as 'Plug_ID',
P.TableID as 'Plug_TableID',
P.ParentID as 'Plug_ParentID'
from Orders O 
inner join Plugs P on P.ID = O.PlugID
where P.ID = O.PlugID
END;
GO

*/

/*
CREATE PROCEDURE SelectAllCustomers (@City nvarchar(30), @PostalCode nvarchar(10))
AS  

END;
*/
/*
CREATE PROCEDURE SelectAllCustomersDeneme1 (@PlugID int)
AS 
begin 
	select * from Payments where Payments.PlugID = @PlugID;
END;
*/

/*
CREATE VIEW view_name AS
IF(SELECT count(*) FROM dbo.Payments) > 0
BEGIN
select 
O.ID as 'Order_ID',
O.PlugID as 'Order_PlugID',
P.ID as 'Plug_ID',
P.TableID as 'Plug_TableID',
P.ParentID as 'Plug_ParentID'
from Orders O 
inner join Plugs P on P.ID = O.PlugID
where P.ID = O.PlugID
END 
ELSE
BEGIN
select 
O.ID as 'Order_ID',
O.PlugID as 'Order_PlugID',
P.ID as 'Plug_ID',
P.TableID as 'Plug_TableID',
P.ParentID as 'Plug_ParentID'
from Orders O 
inner join Plugs P on P.ID = O.PlugID
where P.ID = O.PlugID
END;
*/

