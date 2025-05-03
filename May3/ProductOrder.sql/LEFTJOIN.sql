SELECT
     Products.ProductID,
	 Products.ProductName,
	 Orders.OrderID,
	 Orders.Quantity,
	 Orders.OrderDate
From Products
LEFT JOIN Orders ON Products.ProductID = Orders.ProductId;