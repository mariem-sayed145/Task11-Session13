using Day_01_G03;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Day_01_G03.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using File = System.IO.File;


namespace Task11_Session13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // part 1 , 2  Element Operators and  Aggregate Operators had been solved in task 10 Session 12 

            #region Set Operators 

            //// 1- Find the unique Category names from Product List 
            //var result = ProductsList.Select(p => p.Category).Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("--------------------------------------------------------------------------------------------------");

            //// 2- Produce a Sequence containing the unique first letter from both product and customer name 
            //var result2 = ProductsList.Select(p => p.ProductName[0]).Union(CustomersList.Select(c => c.CustomerName[0])).Distinct();

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("--------------------------------------------------------------------------------------------------");

            //// 3-  Create one sequence that contains the common first letter from both product and customer names. 
            //var result3 = ProductsList.Select(p => p.ProductName[0]).Intersect(CustomersList.Select(c => c.CustomerName[0]));

            //foreach (var item in result3)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("--------------------------------------------------------------------------------------------------");

            //// 4- Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var result4 = ProductsList.Select(p => p.ProductName[0]).Except(CustomersList.Select(c => c.CustomerName[0]));
            //foreach (var item in result4)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("--------------------------------------------------------------------------------------------------");

            //// 5- Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var result5 = ProductsList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3)).Concat(CustomersList.Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3)));

            //foreach (var item in result5)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("--------------------------------------------------------------------------------------------------");

            #endregion

            #region Partitioning Operators

            //// 1- Get the first 3 orders from customers in Washington 

            //var result = CustomersList.Where(c => c.City == "Washington").SelectMany(c => c.Orders).Take(3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("==========================================================================");


            //// 2- Get all but the first 2 orders from customers in Washington. 
            //var result2 = CustomersList.Where(c => c.City == "Washington").SelectMany(c => c.Orders).Skip(2);

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("==========================================================================");


            //// 3-  Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result3 = numbers.TakeWhile((n, index) => n >= index);

            //foreach (var item in result3)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("==========================================================================");


            ////4 - Get the elements of the array starting from the first element divisible by 3. 
            //int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result4 = numbers2.Where(n => n % 3 == 0);

            //foreach (var item in result4)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("==========================================================================");

            //// 5- . Get the elements of the array starting from the first element less than its position.
            //int[] numbers3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result5 = numbers3.SkipWhile((n, index) => n >= index);

            //foreach (var item in result5)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Quantifiers 
            //// 1 - Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            // string[] words = File.ReadAllLines("dictionary_english.txt");

            // bool result = words.Any(word => word.Contains("ei"));

            // Console.WriteLine(result);

            //// 2 - Return a grouped a list of products only for categories that have at least one product that is out of stock.


            //var result2 = ProductsList.GroupBy(p => p.Category)
            //                          .Where(g => g.Any(p => p.UnitsInStock == 0));

            // foreach (var group in result2)
            //     {
            //         Console.WriteLine($"Category: {group.Key}");
            //         foreach (var product in group)
            //         {
            //             Console.WriteLine($"  Product: {product.ProductName}, UnitsInStock: {product.UnitsInStock}");
            //         }
            //     }

            // Console.WriteLine("*****************************************************************************************");

            //// 3 - Return a grouped a list of products only for categories that have all of their products in stock.

            //var result3 = ProductsList.GroupBy(p => p.Category)
            //                          .Where(g => g.All(p => p.UnitsInStock > 0));

            // foreach (var group in result3)
            //     {
            //         Console.WriteLine($"Category: {group.Key}");
            //         foreach (var product in group)
            //         {
            //             Console.WriteLine($"  Product: {product.ProductName}, UnitsInStock: {product.UnitsInStock}");
            //         }
            //     }
            #endregion

            #region Grouping Operators
            //// 1- Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }; 

            //var groupedNumbers = numbers.GroupBy(n => n % 5);

            //foreach (var group in groupedNumbers)
            //{
            //    Console.WriteLine($"Numbers with remainder {group.Key} when divided by 5:");
            //    foreach (var number in group)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //Console.WriteLine("=========================================================================");

            //// 2- Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input
            //String[] words = File.ReadAllLines("dictionary_english.txt");
            //var groupedWords = words.GroupBy(w => w[0]);

            ////foreach (var group in groupedWords)
            ////{
            ////    Console.WriteLine($"Words starting with '{group.Key}':");
            ////    foreach (var word in group)
            ////    {
            ////        Console.WriteLine(word);
            ////    }
            ////}

            //Console.WriteLine("=========================================================================");

            //// 3- Consider this Array as an Input
            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            ////Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //var groupedAnagrams = Arr.GroupBy(word => String.Concat(word.OrderBy(c => c)));

            //foreach (var group in groupedAnagrams)
            //{
            //    Console.WriteLine($"Anagrams for '{group.Key}':");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}


            #endregion
        }
    }
}
