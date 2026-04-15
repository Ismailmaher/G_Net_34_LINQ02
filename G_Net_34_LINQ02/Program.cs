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
        }
    }
}
