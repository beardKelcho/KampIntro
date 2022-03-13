select p.ProductName as [Ürün Adı], Sum(od.UnitPrice*od.Quantity) as [Kazanılan Toplam Miktar] 
from Products p inner join [Order Details] od
on p.ProductID=od.ProductID   group by ProductName  