SELECT
     Products.ProductID,
	 Products.ProductName,
	 Orders.OrderID,
	 Orders.Quantity,
	 Orders.OrderDate
From Products
RIGHT JOIN Orders ON Products.ProductID = Orders.ProductID;