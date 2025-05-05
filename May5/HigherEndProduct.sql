SELECT
     Products.ProductID,
	 Products.ProductName,
     Products.Price,
     'HigherEndProduct' AS ProductCategory,
	 Orders.OrderID,
	 Orders.Quantity,
	 Orders.OrderDate
FROM Products
LEFT JOIN Orders ON Products.ProductID = Orders.ProductID
WHERE Products.Price > 60000;