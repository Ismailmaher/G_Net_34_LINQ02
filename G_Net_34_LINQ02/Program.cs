using G_Net_34_LINQ02.DataSources;
using G_Net_34_LINQ02.Helper;
using G_Net_34_LINQ02.Models;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using static G_Net_34_LINQ02.DataSources.Source;

namespace G_Net_34_LINQ02

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //1.Get top 3 most expensive products
            //var topthreeExpensiveProducts = ProductList
            //    .OrderByDescending(p => p.UnitPrice)
            //    .Take(3)
            //    .ToList();
            //foreach (var product in topthreeExpensiveProducts)
            //{
            //    Console.WriteLine($"{product.UnitPrice}");
            //}
            #endregion
            #region Question 2
            //show page 2 of products, with page size = 5
            //var result = ProductList
            //.Skip(5) 
            //.Take(5)                 
            //.ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"ID: {item.ProductID} | Product: {item.ProductName} | Price: {item.UnitPrice:C}");
            //}
            #endregion
            #region Question 3
            //            Take products from the list as long as Their UnitPrice is less than
            //$25(list is ordered by price).
            // var result = ProductList
            //.OrderBy(p => p.UnitPrice)
            //.TakeWhile(p => p.UnitPrice < 25.00m)
            //.ToList();
            //var result = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25.00m).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Price: {item.UnitPrice:C} | Product: {item.ProductName}");
            //}
            #endregion
            #region Question 4
            // Check if ALL products in the "Seafood" category are in stock
            //var result = ProductList.ToLookup(p => p.Category);
            //bool allInStock = result["Seafood"]
            //    .All(p => p.UnitsInStock > 0);
            //Console.WriteLine(allInStock);   
            #endregion
            #region Question 5
           // int[] ids = { 3, 9, 13, 18 };
           //// bool exists = ids.Contains(9);
           // bool exists = ids.Any(x => x == 9);
           // Console.WriteLine(exists);
            #endregion

        }
    }
}
