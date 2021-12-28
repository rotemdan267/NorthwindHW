// See https://aka.ms/new-console-template for more information

using NorthwindHW.Models;


#region Q1

//using (var db = new NorthwindContext())
//{
//    var products = db.Products.ToList();
//    string str = "";
//    foreach (var product in products)
//    {
//        str += product.ProductName + " " + product.QuantityPerUnit + "\n";
//    }
//    Console.WriteLine(str);
//}

#endregion


#region Q2

//using (var db = new NorthwindContext())
//{
//    var products = db.Products.ToList();
//    string str = "";
//    foreach (var product in products)
//    {
//        str += "ProductId: " + product.ProductId + " ProductName: " + product.ProductName + "\n";
//    }
//    Console.WriteLine(str);
//}

#endregion

#region Q3

//using (var db = new NorthwindContext())
//{
//    var products = db.Products.Where(p => p.Discontinued == true).ToList();
//    string str = "";
//    foreach (var product in products)
//    {
//        str += "ProductId: " + product.ProductId + " ProductName: " + product.ProductName + "\n";
//    }
//    Console.WriteLine(str);
//}

#endregion

#region Q4

//using (var db = new NorthwindContext())
//{
//    var products = db.Products.ToList();
//    var sortedProducts = products.OrderByDescending(products => products.UnitPrice).ToList();
//    string str = "";
//    foreach (var product in sortedProducts)
//    {
//        str += product.ProductName + " UnitPrice: " + product.UnitPrice + "\n";
//    }
//    Console.WriteLine(str);
//}

#endregion

#region Q5

//using (var db = new NorthwindContext())
//{
//    var products = db.Products.Where(p => p.UnitPrice < 20).ToList();
//    string str = "";
//    foreach (var product in products)
//    {
//        str += "ProductId: " + product.ProductId +
//            " ProductName: " + product.ProductName +
//            " UnitPrice: " + product.UnitPrice + "\n";
//    }
//    Console.WriteLine(str);
//}

#endregion

#region Q6

//using (var db = new NorthwindContext())
//{
//    var products = db.Products.Where(p => p.UnitPrice < 25 && p.UnitPrice > 15).ToList();
//    string str = "";
//    foreach (var product in products)
//    {
//        str += "ProductId: " + product.ProductId +
//            " ProductName: " + product.ProductName +
//            " UnitPrice: " + product.UnitPrice + "\n";
//    }
//    Console.WriteLine(str);
//}

#endregion

#region Q7

//using (var db = new NorthwindContext())
//{
//    var products = db.Products.ToList();
//    decimal? avg = 0;
//    foreach (var item in products)
//    {
//        avg += item.UnitPrice;
//    }
//    avg = avg / products.Count;
//    products = db.Products.Where(p => p.UnitPrice > avg).ToList();
//    string str = "";
//    foreach (var product in products)
//    {
//        str += product.ProductName + " UnitPrice: " + product.UnitPrice + "\n";
//    }
//    Console.WriteLine(str);
//}

#endregion

#region Q8

//using (var db = new NorthwindContext())
//{
//    var products = db.Products.ToList();
//    var sortedProducts = products.OrderByDescending(products => products.UnitPrice).ToList();
//    products = sortedProducts.Take(10).ToList();
//    string str = "";
//    foreach (var product in products)
//    {
//        str += product.ProductName + " UnitPrice: " + product.UnitPrice + "\n";
//    }
//    Console.WriteLine(str);
//}

#endregion

#region Q9

//using (var db = new NorthwindContext())
//{
//    var discountedProducts = db.Products.Where(p => p.Discontinued == true).ToList();
//    var products = db.Products.Where(p => p.Discontinued == false).ToList();
//    Console.WriteLine($"Discounted products = {discountedProducts.Count}. Not discounted = {products.Count}");
//}

#endregion

#region Q10

using (var db = new NorthwindContext())
{
    var products = db.Products.Where(p => p.UnitsInStock < p.UnitsOnOrder).ToList();
    string str = "";
    foreach (var product in products)
    {
        str += " ProductName: " + product.ProductName + 
            " UnitsInStock: " + product.UnitsInStock + 
            " UnitsOnOrder: " + product.UnitsOnOrder + "\n";
    }
    Console.WriteLine(str);
}

#endregion
