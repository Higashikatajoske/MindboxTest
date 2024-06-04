SELECT Products.Name, Categories.Name FROM Products
	LEFT JOIN Categories
	On Products.CategoryId = Categories.Id;