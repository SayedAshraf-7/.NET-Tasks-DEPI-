using System;
using System;
using System.Collections;
using System.Collections.Generic;
using DataAccess;
using System.Linq;
using static DataAccess.ListGenerators;
using System.Reflection.Metadata.Ecma335;
using System.Net.WebSockets;
using System.Threading;
using System.Security.Cryptography;
using System.Net.Http.Headers;

namespace ConsoleApp
{
    internal class Program
    {

        static void Main()
        {

            #region Problem 1
            //var res = ProductList.Where((P) => P.UnitsInStock == 0);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Problem 2

            //var res = ProductList.Where((P) => P.UnitsInStock > 0 && P.UnitPrice > 3);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Problem 3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
            //    "nine" };

            //var res = Arr.Where((name , I) => name.Length < I);
            //foreach (var item in res)
            //{

            //    Console.WriteLine(item);
            //}
            #endregion

            #region Problem 4

            //var res = ProductList.FirstOrDefault((P) => P.UnitsInStock == 0);
            //if(res == null)
            //{
            //    Console.WriteLine("All Products Are in Stock");
            //}
            //else
            //{
            //    Console.WriteLine(res);
            //}

            #endregion

            #region Problem 5
            //var res = ProductList.FirstOrDefault((P) => P.UnitPrice > 1000);
            //Console.WriteLine(res == null ? "Not Found" : res);
            #endregion

            #region Problem 6
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // First Way
            //var res = Arr.FirstOrDefault((num) => num != (Arr.FirstOrDefault((num) => num > 5)) && num > 5);
            //Console.WriteLine(res);
            // Second way
            //var res = Arr
            //    .Where((num) => num > 5)
            //    .Skip(1)
            //    .FirstOrDefault(1);
            //Console.WriteLine(res);
            #endregion

            #region Problem 7
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int res = Arr.Count((num) => num % 2 != 0);
            //Console.WriteLine(res);

            #endregion

            #region Problem 8
            //var res = CustomerList.Select((customer) =>
            //new  { 
            //    customer , 
            //    NumberOfOrders = customer.Orders.Length
            //});

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Problem 9
            //var res = ProductList.GroupBy((P) => P.Category);
            //foreach (var item in res)
            //{

            //    Console.WriteLine($"{item.Key}: {item.Count()}");

            //}
            #endregion

            #region Problem 10

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //Console.WriteLine(Arr.Sum());

            #endregion

            #region Problem 11

            //var res = ProductList.GroupBy((P) => P.Category);
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Count()}");
            //}
            #endregion

            #region Problem 12
            //var res = ProductList.GroupBy((p) => p.Category);
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"Category: {item.Key}, Min: {item.Min((p) => p.UnitPrice)}");
            //}

            #endregion

            #region Problem 13
            //var res = ProductList.GroupBy((p) => p.Category);
            //foreach (var item in res)
            //{

            //    Console.WriteLine($"{item.Key}: {item.Max((P)=>P.UnitPrice)}");
            //}
            #endregion

            #region Problem 14
            //var res = ProductList
            //.GroupBy(p => p.Category)
            //.SelectMany(g =>
            //{
            //    var maxPrice = g.Max(p => p.UnitPrice);
            //     return g.Where(p => p.UnitPrice == maxPrice);
            //});

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Problem 15
            // var res = ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    AveragePrice = g.Average(p => p.UnitPrice)
            //});

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.Category}: {item.AveragePrice}");
            //}

            #endregion

            #region Problem 16
            //var res = ProductList.OrderBy((p) => p.ProductName);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Problem 17
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //Array.Sort(Arr , (string a, string b) => string.Compare(a,b,StringComparison.OrdinalIgnoreCase));
            //foreach (var item in Arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Problem 18
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr
            //    .Select((value, index) => new { value, index })
            //    .Where(x => x.value == x.index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.value);
            //}
            #endregion

            #region Problem 19
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = numbersA
            //    .SelectMany(a => numbersB
            //        .Where(b => a < b)
            //        .Select(b => new { a, b }));

            //Console.WriteLine("Pairs where a < b:");

            //foreach (var pair in result)
            //{
            //    Console.WriteLine($"{pair.a} is less than {pair.b}");
            //}
            #endregion

            #region Problem 20
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int result = Arr.Count(x => x % 2 != 0);

            //Console.WriteLine(result);
            #endregion

            #region Problem 21
            //var result = CustomerList.Select(c => new
            //{
            //    c.Name,
            //    OrderCount = c.Orders.Length
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Name}: {item.OrderCount}");
            //}
            #endregion

            #region Problem 22
            //var result = ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    ProductCount = g.Count()
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category}: {item.ProductCount}");
            //}
            #endregion

            #region Problem 23
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int result = Arr.Sum();

            //Console.WriteLine(result);
            #endregion

            #region Problem 24
            //var result = ProductList
            //.OrderBy((p)=> p.ProductName);

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            #endregion

            #region Problem 25
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region Problem 26
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region Problem 27
            //var result = CustomerList
            //.Where((c) => c.City == "Washington")
            //.SelectMany((c) => c.Orders)
            //.Take(3);

            //foreach (var order in result)
            //{
            //    Console.WriteLine($"Order ID: {order.Id}");
            //}
            #endregion

            #region Probelm 28
            //var result = CustomerList
            //.Where(c => c.City == "Washington")
            //.SelectMany(c => c.Orders)
            //.Skip(2);

            //foreach (var order in result)
            //{
            //    Console.WriteLine($"Order ID: {order.Id}");
            //}
            #endregion

            #region Problem 29
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers
            //    .TakeWhile((number, index) => number >= index);

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Problem 30
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers
            //    .SkipWhile(number => number % 3 != 0);

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Problem 31
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers
            //    .SkipWhile((number, index) => number >= index);

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Problem 32
            //var result = CustomerList
            //.Where((c) => c.City == "Washington")
            //.SelectMany((c) => c.Orders)
            //.Take(3);

            //foreach (var order in result)
            //{
            //    Console.WriteLine(order.Id);
            //}
            #endregion

            #region Problem 33
            //var result = CustomerList
            //.Where(c => c.City == "Washington")
            //.SelectMany(c => c.Orders)
            //.Skip(2);

            //foreach (var order in result)
            //{
            //    Console.WriteLine(order.Id);
            //}
            #endregion

            #region Problem 34
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers
            //    .TakeWhile((number, index) => number >= index);

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion


        }

    }
}
