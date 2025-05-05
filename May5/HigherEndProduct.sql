SELECT
     Products.ProductID,
	 Products.ProductName,
	 Orders.OrderID,
	 Orders.Quantity,
	 Orders.OrderDate
FROM Products
LEFT JOIN Orders ON Products.ProductID = Orders.ProductID
WHERE Products.Price > 60000;