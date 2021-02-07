SELECT p.ProductName as 'Ürün Adı', 
SUM(p.UnitPrice*od.Quantity) as 'Kazanılan Toplam Miktar' 
FROM Products p inner join [Order Details] od 
on p.ProductID = od.ProductID
inner join Orders o on o.OrderID = od.OrderID
group by p.ProductName