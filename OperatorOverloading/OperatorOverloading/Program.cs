// See https://aka.ms/new-console-template for more information
using OperatorOverloading;

Console.WriteLine("Hello, World!");
var value1 = 3;
var value2 = 4;
var word = "Merhaba";

var total = value1 + value2;
Console.WriteLine(total);
var result = word  + total;
//Console.WriteLine(result);
//Product product1 = new Product();
//Product product2 = new Product();
//var result2 = product1 + product2;

ProductCart productCart = new ProductCart();
productCart.Add(new Product() { Id = 1, Name = "Ürün 1", Price = 100, Quantity=2 });
productCart.Add(new Product() { Id = 2, Name = "Ürün 2", Price = 300, Quantity = 1 });
productCart.Add(new Product() { Id = 3, Name = "Ürün 3", Price = 200, Quantity = 3 });

productCart.ShowAll();
Console.WriteLine("Toplam Fiyat: " + productCart.Total());
Console.WriteLine(productCart["Ürün 2"]);
Console.WriteLine(productCart[3]);






