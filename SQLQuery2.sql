--select
select ContactName Adi, CompanyName Sirketadi,City Sehir from Customers

select * from Customers where City='London'

select * from Products where CategoryId=1 or CategoryID=3

select * from Products where CategoryId=1 and UnitPrice>=10
 
select * from Products where CategoryID=1 order by UnitPrice desc  --descending Azalan  

select * from Products order by UnitPrice asc  --ascending Artan

select count(*) Adet from Products  -- where CategoryID=2 -- veritabanında ki verinin kaçtane olduğunu öğrenmek içiçn gerekli sorgu

select categoryID, count(*) from products where UnitPrice>20 
group by CategoryID having count(*)<10

select Products.ProductID,Products.ProductName, Products.UnitPrice ,Categories.CategoryName 
--inner join iki tabloda da eşleşiyorsa birleştirir
from Products inner join Categories -- products tablosuyla birlikte categories tablosunu kullanmak için join liyoruz
on Products.CategoryID=Categories.CategoryID -- bu şart altında çalış anlamında on keyword ü kullanılır.
where Products.UnitPrice>10

-- left solda olup sağda olmayanları da getir demek right join de geçerlidir sağda olup solda olmayanları getiri
select * from Products p inner join [Order Details] od
on p.ProductID =od.ProductID
inner join Orders o
on o.OrderID=od.OrderID

select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null


