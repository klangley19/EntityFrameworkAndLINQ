using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data;
using System.Data.EntityClient;

namespace Grouping
{
    class Program
    {
        static void Main(string[] args)
        {


            #region example #1

            //using (var context = new AdventureWorks2008R2Entities())
            //{

            //    var sales = from s in context.SalesOrderHeaders
            //                group s by s.SalesPersonID
            //                    into salesTotals
            //                    select salesTotals;

            //    var salesTotalsGrouping = sales.ToList();



            //}
            //Console.Write("Press Enter...");
            //Console.ReadLine();
            #endregion

            #region example #2

            //using (var context = new AdventureWorks2008R2Entities())
            //{

            //    var sales = from s in context.SalesOrderHeaders
            //                group s by s.SalesPersonID
            //                    into salesTotals
            //                    select new
            //                    {
            //                        salesTotals,
            //                        SalesPersonKeyID = salesTotals.Key,
            //                        TotalSales = salesTotals.Sum(sp => sp.SubTotal),
            //                        SalesCount = salesTotals.Count()
            //                    };

            //    //var salesTotalsGrouping = sales.ToList();


            //    foreach (var person in sales)
            //    {
            //        Console.WriteLine("Sale Person ID: {0} :: Total Sales: ${1}", person.SalesPersonKeyID, person.TotalSales);
            //    }

            //}
            //Console.Write("Press Enter...");
            //Console.ReadLine();
            #endregion

            #region example #3

            //using (var context = new AdventureWorks2008R2Entities())
            //{

            //    var sales = from s in context.SalesOrderHeaders
            //                group s by s.SalesPersonID
            //                    into salesTotals
            //                    select new
            //                    {
            //                        salesTotals,
            //                        SalesPersonKeyID = salesTotals.Key,
            //                        TotalSales = salesTotals.Sum(sp => sp.SubTotal),
            //                        SalesCount = salesTotals.Count()
            //                    };

            //    //var salesTotalsGrouping = sales.ToList();


            //    foreach (var person in sales)
            //    {
            //        Console.WriteLine("Sale Person ID: {0} :: Total Sales: ${1}", person.SalesPersonKeyID, person.TotalSales);

            //    }

            //}
            //Console.Write("Press Enter...");
            //Console.ReadLine();

            #endregion


            #region example #4

            //using (var context = new AdventureWorks2008R2Entities())
            //{



            //    var sales = from s in context.SalesOrderHeaders
            //                let sp = new
            //                {
            //                    LastName = s.SalesPerson.Employee.Person.LastName,
            //                    FirstName = s.SalesPerson.Employee.Person.FirstName,
            //                    SalesPersonID = s.SalesPersonID,
            //                    SalesInformation = s
            //                }
            //                group sp by s.SalesPersonID into TotalSalesGroup
            //                select new
            //                {
            //                    TotalSalesGroup,
            //                    SalesPersonKeyID = TotalSalesGroup.Key,
            //                    TotalSales = TotalSalesGroup.Sum(sp => sp.SalesInformation.SubTotal),
            //                    SalesCount = TotalSalesGroup.Count()
            //                };

            //    foreach (var person in sales)
            //    {
            //        var personDetails = person.TotalSalesGroup.FirstOrDefault();

            //        string lastName = personDetails.LastName ?? "Null";
            //        string firstName = personDetails.FirstName ?? "Null";

            //        Console.WriteLine("Sale Person ID: {0}, {1} :: Total Sales: ${2}", lastName, firstName, person.TotalSales);

            //    }

            //}
            //Console.Write("Press Enter...");
            //Console.ReadLine();

            #endregion


            #region example #5

            //using (var context = new AdventureWorks2008R2Entities())
            //{



            //    var sales = from s in context.SalesOrderHeaders
            //                let sp = new
            //                {
            //                    LastName = s.SalesPerson.Employee.Person.LastName,
            //                    FirstName = s.SalesPerson.Employee.Person.FirstName,
            //                    SalesPersonID = s.SalesPersonID,
            //                    SalesInformation = s
            //                }
            //                where sp.SalesPersonID != null && sp.LastName != null && sp.FirstName != null
            //                group sp by s.SalesPersonID into TotalSalesGroup
            //                select new
            //                {
            //                    TotalSalesGroup,
            //                    LastName = TotalSalesGroup.FirstOrDefault().LastName,
            //                    FirstName = TotalSalesGroup.FirstOrDefault().FirstName,
            //                    SalesPersonKeyID = TotalSalesGroup.Key,
            //                    TotalSales = TotalSalesGroup.Sum(sp => sp.SalesInformation.SubTotal),
            //                    SalesCount = TotalSalesGroup.Count()
            //                };

            //    foreach (var person in sales)
            //    {
            //        string lastName = person.LastName; //?? "Null";
            //        string firstName = person.FirstName; //?? "Null";

            //        Console.WriteLine("Sale Person ID: {0}, {1} :: Total Sales: ${2}", lastName, firstName, person.TotalSales);

            //    }

            //}
            //Console.Write("Press Enter...");
            //Console.ReadLine();

            #endregion


            #region example #6

            //using (var context = new AdventureWorks2008R2Entities())
            //{

            //    var sales = from s in context.SalesOrderHeaders
            //                group s by s.SalesPersonID
            //                    into salesTotals
            //                    select new
            //                    {
            //                        salesTotals,
            //                        SalesPersonKeyID = salesTotals.Key,
            //                        TotalSales = salesTotals.Sum(sp => sp.SubTotal),
            //                        SalesCount = salesTotals.Count()
            //                    };

            //    //var salesTotalsGrouping = sales.ToList();


            //    foreach (var person in sales)
            //    {

            //        //Console.WriteLine("Sale Person ID: {0} :: Total Sales: ${1}", person.SalesPersonKeyID, person.TotalSales);
            //        if (person.salesTotals.FirstOrDefault().SalesPerson != null)
            //        {
            //            var Person = person.salesTotals.FirstOrDefault().SalesPerson.Employee.Person;
            //            Console.WriteLine("Sale Person: {0}, {1} :: Total Sales: ${2}", Person.LastName, Person.FirstName, person.TotalSales);

            //        }
            //    }

            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();
            
            #endregion


            #region example #7

            //using (var context = new AdventureWorks2008R2Entities())
            //{
                //context.ContextOptions.LazyLoadingEnabled = false;

                //var salesData = from s in context.SalesOrderHeaders
                //                select new
                //                {
                //                    s.SalesPersonID,
                //                    LastName = s.SalesPerson.Employee.Person.LastName,
                //                    FirstName = s.SalesPerson.Employee.Person.FirstName,
                //                    SaleAmount = s.SubTotal
                //                };


                //var salesData = (from s in context.SalesOrderHeaders
                //            select new
                //            {
                //                s.SalesPersonID,
                //                LastName = s.SalesPerson.Employee.Person.LastName,
                //                FirstName = s.SalesPerson.Employee.Person.FirstName,
                //                SaleAmount = s.SubTotal
                //            }).ToList();
                                
                //var sales = from sd in salesData
                //            group salesData by new { sd.SalesPersonID, sd.LastName, sd.FirstName } 
                //            into salesTotals
                //                select new
                //                {
                //                    SalesPersonKeyID = salesTotals.Key.SalesPersonID,
                //                    FirstName = salesTotals.Key.FirstName,
                //                    LastName = salesTotals.Key.LastName,
                //                    TotalSales = salesTotals.Sum(),
                //                    SalesCount = salesTotals.Count()
                //                };


                //var sales = salesData
                //                .GroupBy(s => new {
                //                                        s.SalesPersonID, 
                //                                        s.LastName, 
                //                                        s.FirstName
                //                                  })
                //                .Select(g => new { 
                //                                        FirstName = g.Key.FirstName,
                //                                        LastName = g.Key.LastName,
                //                                        SalesPersonID = g.Key.SalesPersonID,
                //                                        TotalSalesAmount = g.Sum(tsa => tsa.SaleAmount),
                //                                        TotalSalesCount = g.Count()
                //                                 });

                //var sales = from s in context.SalesOrderHeaders
                //            group s by new { s.SalesPersonID }
                //                into salesTotals
                //                select new
                //                {
                //                    salesTotals,
                //                    SalesPersonKeyID = salesTotals.Key,
                //                    TotalSales = salesTotals.Sum(sp => sp.SubTotal),
                //                    SalesCount = salesTotals.Count()
                //                };

                ////var salesTotalsGrouping = sales.ToList();


                //foreach (var person in sales)
                //{

                //    //Console.WriteLine("Sale Person ID: {0} :: Total Sales: ${1}", person.SalesPersonKeyID, person.TotalSales);
                //    if (person.salesTotals.FirstOrDefault().SalesPerson != null)
                //    {
                //        var Person = person.salesTotals.FirstOrDefault().SalesPerson.Employee.Person;
                //        Console.WriteLine("Sale Person: {0}, {1} :: Total Sales: ${2}", Person.LastName, Person.FirstName, person.TotalSales);

                //    }
                //}

            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();

            #endregion

            #region example #8


            //using (var context = new AdventureWorks2008R2Entities())
            //{

            //    //var sales = from s in context.SalesOrderHeaders
            //    //            group s by s.SalesPersonID
            //    //                into salesTotals
            //    //                select new
            //    //                {
            //    //                    SalesPersonKeyID = salesTotals.Key,
            //    //                    TotalSales = salesTotals.Sum(sp => sp.SubTotal),
            //    //                    SalesCount = salesTotals.Count()
            //    //                };

            //    //var sales = from s in context.SalesOrderHeaders
            //    //            group s by new { s.SalesPersonID, s.SalesPerson.Employee.Person.FirstName, s.SalesPerson.Employee.Person.LastName }
            //    //            into salesTotals
            //    //            select new
            //    //            {
            //    //                SalesPersonKeyID = salesTotals.Key,
            //    //                TotalSales = salesTotals.Sum(sp => sp.SubTotal),
            //    //                SalesCount = salesTotals.Count()
            //    //            };

            //    var sales = from s in context.SalesOrderHeaders
            //                group s by new { s.SalesPersonID, s.SalesPerson.Employee.Person.FirstName, s.SalesPerson.Employee.Person.LastName }
            //                    into salesTotals
            //                    select new
            //                    {
            //                        SalesPersonKeyID = salesTotals.Key.SalesPersonID,
            //                        LastName = salesTotals.Key.LastName,
            //                        FirstName = salesTotals.Key.FirstName,
            //                        TotalSales = salesTotals.Sum(sp => sp.SubTotal),
            //                        SalesCount = salesTotals.Count()
            //                    };

            //    foreach (var person in sales)
            //    {

            //        //Console.WriteLine("Sale Person ID: {0} :: Total Sales: ${1}", person.SalesPersonKeyID, person.TotalSales);
            //        if (person.SalesPersonKeyID != null && person.FirstName != null && person.LastName != null)
            //        {
            //            Console.WriteLine("Sale Person: {0}, {1} :: Total Sales: ${2}", person.LastName, person.FirstName, person.TotalSales);

            //        }
            //    }

            //    Console.Write("Press Enter...");
            //    Console.ReadLine();

            //}
            #endregion

        }
    }
}
