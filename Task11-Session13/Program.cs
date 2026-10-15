using Day_01_G03;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static Day_01_G03.ListGenerator;
using static System.Net.WebRequestMethods;


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

            // 1- Get the first 3 orders from customers in Washington 

            var result = CustomersList.Where(c => c.City == "Washington").SelectMany(c => c.Orders).Take(3);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            // 2- Get all but the first 2 orders from customers in Washington. 
            var result2 = CustomersList.Where(c => c.City == "Washington").SelectMany(c => c.Orders).Skip(2);

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            #endregion 
        }
    }
}
