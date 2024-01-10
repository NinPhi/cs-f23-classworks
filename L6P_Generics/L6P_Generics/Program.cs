
using L6P_Generics;

AppleProduct product = AppleProduct.AirPods;

Type enumType = typeof(AppleProduct);

//string productName = product.ToString();
string productName = "MacBook";

AppleProduct product2 = EnumHelper.ParseOrFirst(productName);
var product3 = EnumHelper.ParseOrFirst<ConsoleColor>("Blue");

Console.WriteLine("Before: " + product);
Console.WriteLine("After: " + product2);
Console.WriteLine("Generic: " + product3);