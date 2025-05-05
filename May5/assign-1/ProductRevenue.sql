CREATE PROCEDURE GetProductRevenue
     @ProductID INT
AS
BEGIN
   SELECT
      p.ProductID,
	  p.ProductName,
	  SUM(o.Quantity * p.Price) AS TotalRevenue
   FROM  Orders o
   INNER JOIN Products p ON o.ProductID = p.ProductID
   WHERE o.ProductID = @ProductID
END;