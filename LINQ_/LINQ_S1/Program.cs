using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using static Rout_LINQ_S1.ListGenerators;

namespace Rout_LINQ_S1
{
    internal class Program
    {
        public static (int , string) ReturnEmp()
        {
            return (3, "Ahmed");
        }
        static void Main(string[] args)
        {
            #region Implicitly Local Variable - Var

            //var Data = 3;
            //Data = "ali"; //// Not Valid, C# is Strongly Typed Language
            //var Y = null;
            //dynamic x = null;
            //Console.WriteLine(x);
            #endregion
            #region Extension Method

            //int x = 12345;
            //int y = IntExtention.Miror(x);
            //y = x.Miror();  // Syntax Sugar
            //Console.WriteLine(y);

            //double k = 4.2;
            //double l = k.Miror();
            //Console.WriteLine(l);

            #endregion
            #region Anonymous

            //var E01 = new { Id = 1 , Name ="ahmed", Salary =400 };
            ////E01.Id = 8;   /// Immutable Object, You Can't Change
            ////var E02 = E01 with { Id = 2 };  ///C# 10.0 Feature 
            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.GetType().Name); //<>f__AnonymousType0`3

            //var E03 = new { Id = 30, Name = "Mohamed", Salary = 500 };
            //Console.WriteLine(E03.GetType().Name);  //<>f__AnonymousType0`3
            ///// Same Anonymous Class as long as =>
            ///// 1. Same Properties Names (Case Sensitive)
            ///// 2. Same Properties Datatype
            ///// 3. Same Properties Order

            //var E04 = new { Name = "Mohamed", Salary = 500, Id = 30 };
            //Console.WriteLine(E04.GetType().Name);  //<>f__AnonymousType1`3
            //Console.WriteLine(E04);

            //var product = new { ID = 102, ProductName = "Meat" };
            //Console.WriteLine(product.GetType().Name);  //<>f__AnonymousType2`2
            //Console.WriteLine(product); //{ ID = 102, ProductName = Meat }

            #endregion
            #region LINQ Intro

            /// LINQ: is stand for Language-Integrated Query
            /// LINQ: +40 Extension Methods Named [Query Operators] Existing in Enumerable Class 
            ///         and Categorized to 13 Categories
            /// Use LINQ Functions Against Data (Any Sequence) Regardless Data Store
            /// Sequence: Any Class Implementing IEnumerable (Like List, Array, Dictionary...)
            /// 1. Local Sequence : L2O, L2XML
            /// 2. Remote Sequence: L2SQL, L2EF
            //List<string> Names = new List<string> { "ahm","aliu","ase"};

            #endregion
            #region LINQ Syntax
            /// 1. Fluent Syntax
            /// 1.1 Calling as Static Method through Enumerable Class 
            //var Result = Enumerable.Where(Numbers, (i) => i % 2 == 0);
            //foreach (var N in Result)
            //    Console.WriteLine(N);

            /// 1.2 Calling as Extension Method
            //Result = Numbers.Where((N) => N % 2 == 0);


            /// 2. Query Syntax [Query Expression]: Like SQL Query Style
            //Result = from N in Numbers
            //         where N % 2 == 0
            //         select N;
            /// Start With from, Introducing Range Variable(N): Represents Each Element At Sequence
            /// End With select Or group by
            /// Some Cases, It's Easier To Write Queries Using Query Expression
            /// Instead Of Fluent Syntax (Join, Group, Let, Into) 
            #endregion
            #region LINQ Execution

            /// Ways Of LINQ Execution
            // 1. Deffered Execution (Latest Update Of Data)
            //All LINQ Operators Except Element, Aggregate, Casting Operators

            //List<int> OddNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            //var EvenNumbers = OddNumbers.Where((i) => i % 2 == 0); 
            //OddNumbers.Remove(2);
            //OddNumbers.AddRange(new int[] { 9, 10, 11, 12 });
            //foreach (var item in EvenNumbers)
            //    Console.Write($"{item},");
            //Console.WriteLine("");

            ////2.Immediate Execution
            ////Using Casting For Converting Deffered Executing LINQ Operators
            //EvenNumbers = OddNumbers.Where((i) => i % 2 == 0).ToList();
            //OddNumbers.Remove(2);
            //OddNumbers.AddRange(new int[] { 9, 10, 11, 12 });
            //foreach (var item in EvenNumbers)
            //    Console.Write($"{item},");
            //Console.WriteLine("");

            #endregion
            #region Filtration (Restrictions) Operator - Where
            //Console.WriteLine(ListGenerators.Products[0]);
            //Console.WriteLine(Products[1]);
            //Console.WriteLine(Customers[0]);
            //Console.WriteLine(Customers[1]);

            //var Result = Products.Where((p) => p.UnitsInStock == 0);
            //Result = from p in Products
            //         where p.UnitsInStock == 0
            //         select p;


            //var Result = Products.Where(p => p.UnitsInStock == 0 && p.Category == "Meat/Poultry");

            //Result = from p in Products
            //         where p.UnitsInStock == 0 && p.Category == "Meat/Poultry"
            //         select p;

            // Indexed Where
            // Valid Only at Fluent Syntax
            // Can't be Written Using Query Expression
            /// Get From The First 10 Products, The Products That Are Out Of Stock
            //var Result = Products.Where((P, index) => P.UnitsInStock == 0 && index > 10);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Transformation (Projection Operators) - Select / SelectMany

            //var Result = Products.Select(p => p.ProductName);
            //Result = from p in Products
            //         select p.ProductName;

            //var Result2 = Customers.SelectMany(c => c.Orders);
            //Result2 = from c in Customers
            //          from o in c.Orders
            //          select o;

            //var r3 = Products.Select(p => new {p.ProductID, p.ProductName, p.UnitPrice});
            //r3 = from p in Products
            //     select new
            //     {
            //         p.ProductID,
            //         p.ProductName,
            //         p.UnitPrice
            //     };

            //var r4 = Products.Select(p => new
            //{
            //    Id = p.ProductID,
            //    Name = p.ProductName,
            //    NewPrice = p.UnitPrice * 2M
            //});
            //r4 = from p in Products
            //     select new
            //     {
            //         Id = p.ProductID,
            //         Name = p.ProductName,
            //         NewPrice = p.UnitPrice * 2M
            //     };

            //var DiscountedProudects = Products.Select(p => new
            //{
            //    Id = p.ProductID,
            //    p.ProductName,
            //    Category = p.Category,
            //    NewPrice = p.UnitPrice * 0.8M
            //}).Where(p => p.NewPrice < 80);

            //DiscountedProudects = from p in Products
            //                      select new
            //                      {
            //                          Id = p.ProductID,
            //                          p.ProductName,
            //                          Category = p.Category,
            //                          NewPrice = p.UnitPrice * 0.8M
            //                      }
            //                     into NewP
            //                      where NewP.NewPrice < 80
            //                      select NewP;

            ///Indexed Select (Valid Only at Fluent Syntax)
            //var Result = Products.Select((p, i) => new { Index = i , Name = p.ProductName});
            #endregion
            #region Ordering Operators

            //var r5 = Products.OrderByDescending(p => p.UnitsInStock).ThenByDescending(p => p.UnitPrice);
            //r5 = from p in Products
            //    orderby p.UnitsInStock descending ,p.UnitPrice descending
            //    select p;

            //var r = Products.Where(p => p.UnitsInStock == 0).Reverse();


            // ///Ascending Order
            // var Result01 = Products.OrderBy(P => P.UnitsInStock)
            //                         .Select(P => new { P.ProductName, P.UnitsInStock });
            // Result01 = from P in Products
            //          orderby P.UnitsInStock
            //          select new { P.ProductName, P.UnitsInStock };

            // ///Descending Order
            // var Result02 = Products.OrderByDescending(P => P.UnitsInStock)
            //                         .Select(P => new { P.ProductName, P.UnitsInStock });
            // Result02 = from P in Products
            //          orderby P.UnitsInStock descending
            //          select new { P.ProductName, P.UnitsInStock };

            /////OrderBy Multiple Columns
            //var Result03 = Products.OrderBy(P => P.UnitsInStock)
            //                        .ThenBy(P => P.UnitPrice)
            //                        .Select(P => new { P.ProductName, P.UnitPrice });
            // Result03 = from P in Products
            //          orderby P.UnitsInStock, P.UnitPrice
            //          select new { P.ProductName, P.UnitPrice };

            // var Result04 = Products.OrderBy(P => P.UnitsInStock)
            //                         .ThenByDescending(P => P.UnitPrice)
            //                         .Select(P => new { P.ProductName, P.UnitPrice });
            // Result04 = from P in Products
            //          orderby P.UnitsInStock, P.UnitPrice descending
            //          select new { P.ProductName, P.UnitPrice };

            // ///Reverse Operator
            // var Result05 = Products.Select(P => P.ProductName).Reverse();

            //foreach (var item in r)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region Element Operators - Immediate Execution

            ////var r05 = Products.First();
            ////r05 = Products.Last();

            ////List<Product> List = new List<Product>();
            ////List.Add(Products[0]);
            ////var r09 = List.Single();

            ////var r05 = Products.FirstOrDefault();
            ////var r06 = Products.LastOrDefault();

            ////var r07 = Products.ElementAt(0);
            ////var r08 = Products.ElementAtOrDefault(1000);

            //Console.WriteLine(r08?.ProductName ?? "NA");

            #endregion
            #region Aggregate Operators - Immediate Execution

            //var r01 = Products.Count();
            //r01 = Products.Count;
            //r01 = Products.Count(p => p.UnitsInStock == 0);

            //var r02 = Products.Max();
            //var r03 = Products.Max(p => p.UnitPrice);

            //var r4 = Products.Min();  
            //var r5 = Products.Min(p =>  p.ProductName.Length);

            //var r6 = (from p in Products
            //          where p.ProductName.Length == Products.Min(p => p.ProductName.Length)
            //          select p).FirstOrDefault(); 
            //Console.WriteLine(r6);

            //Console.WriteLine(Products.Sum(p => p.UnitPrice));
            //Console.WriteLine(Products.Average(p => p.UnitPrice));

            //string[] Names = { "Ahmed", "Nasr", "Eldein", "Hamdy" };
            //var r7 = Names.Aggregate((str1, str2) => $"{str1} {str2}");
            //Console.WriteLine(r7);

            #endregion
            #region Casting Operators - Immediate Execution

            //List<Product> list = Products.Where(p => p.UnitsInStock == 0).ToList();

            //Product[] Arr = Products.Where(p => p.UnitsInStock == 0).ToArray();

            //Dictionary<long, Product> Dic = Products.Where(p => p.UnitsInStock == 0)
            //                                        .ToDictionary(p => p.ProductID);

            //Dictionary<long, string> Dic = Products.Where(p => p.UnitsInStock == 0)
            //                               .ToDictionary(p => p.ProductID, P => P.ProductName);

            //HashSet<Product> Set = Products.Where( p => p.UnitsInStock ==0 ).ToHashSet();
            //Console.WriteLine(Set);

            #endregion
            #region Generation Operators

            //var r01 = Enumerable.Range(0, 100);   /// 0 :99
            //r01 = Enumerable.Repeat(10, 3);
            //foreach (var item in r01)
            //    Console.WriteLine(item);

            //var r01 = Enumerable.Repeat(new Product() { Category = "Meat"}, 3);

            //var r01 = Enumerable.Empty<Product>().ToArray();

            //Product[] Arr = new Product[0];

            #endregion
            #region Set Operators

            //var sq01 = Enumerable.Range(0, 100);   ///0 : 99
            //var sq02 = Enumerable.Range(50, 100);  ///50 : 149

            //var r01 = sq01.Union(sq02);

            //var r01 = sq01.Concat(sq02);
            //r01 = r01.Distinct();

            //var r01 = sq01.Intersect(sq02);

            //var r01 = sq01.Except(sq02);

            //foreach (var item in r01)
            //{
            //    Console.Write($"{item}, ");
            //}

            #endregion
            #region Quantifiers Operators - Return Boolean Value

            //Console.WriteLine(Products.Any());

            //Console.WriteLine(Products.Any(p => p.UnitsInStock ==0));

            //Console.WriteLine(Products.All(p => p.ProductID == 1));

            //var sq01 = Enumerable.Range(0, 100);   ///0 : 99
            //var sq02 = Enumerable.Range(50, 100);  ///50 : 149
            //Console.WriteLine(sq01.SequenceEqual(sq02));

            #endregion
            #region Zip Operator

            //string[] Name = { "A", "B", "C", "D" };
            //var Num = Enumerable.Range(1, 10);      /// 1 : 10 

            //var r01 = Name.Zip(Num, (Name, Num) => new {StdId = Num, StdName = Name});
            //foreach (var item in r01)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Grouping Operator
            //var r01 = Products.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category);

            //var r02 = Products.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category).Select(p => p.Key);

            //var r01 = from p in Products
            //          where p.UnitsInStock > 0
            //          group p by p.Category;

            //foreach (var group in r01)
            //{
            //    Console.WriteLine(group.Key);
            //}

            //foreach (var group in r01)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"------------{product}");
            //    }
            //}

            //var r01 = Products.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category)
            //                  .Where(G => G.Count() > 5)
            //                  .Select(G => new { Category = G.Key, Count = G.Count() }); 

            //var r02 = from p in Products
            //          where p.UnitsInStock > 0
            //          group p by p.Category
            //          into ProductGroup
            //          where ProductGroup.Count() > 5
            //          select new {Category =ProductGroup.Key , Count = ProductGroup.Count()};

            //foreach (var item in r01)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Partitioning Operators(Take, Skip, TakeWhile, SkipWhile)

            //var r01 = Products.Where(p => p.UnitsInStock == 0).Take(2);
            //var r02 = Products.Where(p => p.UnitsInStock == 0).TakeLast(2);

            //var r03 = Products.Where(p => p.UnitsInStock == 0).Skip(2);
            //var r04 = Products.Where(p => p.UnitsInStock == 0).SkipLast(2);

            #endregion
            #region Let / Into

            //List<string> Names = new List<string>()
            //{ "Ahmed", "Ali", "Sally", "Mohamed", "Moamen" };

            //var Result01 = from N in Names
            //             select Regex.Replace(N, "[aeoiuAEOIU]", String.Empty)
            //             /// into: Start Query With New Range Variable
            //             into NoVolName
            //               where NoVolName.Length >= 3
            //               orderby NoVolName.Length descending
            //               select NoVolName;

            //var Result02 = from N in Names
            //               let NoVolName = Regex.Replace(N, "[aeoiuAEOIU]", String.Empty
            //         /// let: Continue Query With New Added Range Variable
            //         where NoVolName.Length >= 3
            //               orderby NoVolName.Length descending
            //               select NoVolName;

            #endregion
            #region Index Features C# 8.0

            //int[] Numbers = Enumerable.Range(0, 20).ToArray();

            //Console.WriteLine(Numbers[0]);  /// 0
            //Console.WriteLine(Numbers[^1]); /// 19

            //int[] NumArr = Numbers[0..9];   ///0..8

            //foreach (int num in NumArr)
            //    Console.WriteLine(num);

            #endregion
        }
    }
}
