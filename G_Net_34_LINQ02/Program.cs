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

            #region Question 6
            //Group all products by Category and print each group with its product count.
            //var groups = ProductList.GroupBy(p => p.Category);

            //foreach (var result in groups)
            //{
            //    Console.WriteLine($"Category: {result.Key}, Count: {result.Count()}");
            //}

            #endregion
            #region Question 7
            //Group products by Category and project only product names per group
            //var result = ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            // Category = g.Key,
            // Products = g.Select(p => p.ProductName)
            //});
            //foreach (var g in result)
            //{
            //    Console.WriteLine(g.Category);
            //    foreach (var name in g.Products)
            //        Console.WriteLine(name);
            //}
            #endregion
            #region Question 8
            //var result = ProductList
            //.GroupBy(p => p.Category)
            //.Where(g => g.Count() > 3)
            //.Select(g => g.Key);
            #endregion

            #region Question 9
            //var result = from c in Source.CustomerList
            //             group c by c.Country into countryGroup
            //             select new
            //             {
            //                 Country = countryGroup.Key,
            //                 Count = countryGroup.Count(),
            //                 TotalOrderValue = countryGroup.Sum(cust => cust.Orders.Sum(o => o.Total))
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Country: {item.Country,-10} | Customers: {item.Count} | Total Sales: {item.TotalOrderValue:C}");
            //}
            #endregion
            #region Question 10
            //int totalUnits = ProductList.Sum(p => p.UnitsInStock);
            #endregion
            #region Question 11
            var minPrice = ProductList.Min(p => p.UnitPrice);
            var maxPrice = ProductList.Max(p => p.UnitPrice);
            #endregion

        }
    }
}
