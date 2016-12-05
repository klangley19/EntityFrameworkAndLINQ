using System;
using System.Collections.Generic;
using System.Data;
using System.Data.EntityClient;
using System.Linq;
using System.Text;

using Projections.Sales;
using Projections.SalesPeople;

namespace Projections
{
    class Program
    {
        static void Main(string[] args)
        {

            #region example #1

            //using (var context = new AdventureWorks2008R2Entities())
            //{

            //    var salesPeople = from sp in context.SalesPersons
            //                      where sp.Employee.Person.FirstName == "Stephen"
            //                      select sp;

            //    foreach (var person in salesPeople)
            //    {
            //        Console.WriteLine("{0} {1}",
            //        person.Employee.Person.FirstName.Trim(),
            //        person.Employee.Person.LastName);
            //    }
            //}
            //Console.Write("Press Enter...");
            //Console.ReadLine();
            #endregion

            #region example #2

            //using (var context = new AdventureWorks2008R2Entities())
            //{

            //    var salesPeople = from sp in context.SalesPersons
            //                      where sp.Employee.Person.FirstName == "Stephen"
            //                      select new { sp.Employee.Person.FirstName, sp.Employee.Person.LastName };

            //    foreach (var person in salesPeople)
            //    {
            //        Console.WriteLine("{0} {1}",
            //        person.FirstName.Trim(),
            //        person.LastName);
            //    }
            //}
            //Console.Write("Press Enter...");
            //Console.ReadLine();
            #endregion

            #region example #3

            //using (var context = new AdventureWorks2008R2Entities())
            //{

            //    var salesPeople = from sp in context.SalesPersons
            //                      where sp.Employee.Person.FirstName == "Stephen"
            //                      let SalesPersonName = new { sp.Employee.Person.FirstName, sp.Employee.Person.LastName }
            //                      select SalesPersonName;

            //    foreach (var person in salesPeople)
            //    {
            //        Console.WriteLine("{0} {1}",
            //        person.FirstName.Trim(),
            //        person.LastName);
            //    }
            //}
            //Console.Write("Press Enter...");
            //Console.ReadLine();
            #endregion        
        
            #region example #4

            //using (var context = new AdventureWorks2008R2Entities())
            //{

            //    var salesPeople = from sp in context.SalesPersons
            //                      where sp.Employee.JobTitle == "Sales Representative"
            //                      let SalesPerson = new
            //                      {
            //                          SalePersonName = new { sp.Employee.Person.FirstName, sp.Employee.Person.LastName },
            //                          sp.Employee
            //                      }
            //                      orderby SalesPerson.SalePersonName.LastName
            //                      select SalesPerson;

            //    foreach (var person in salesPeople)
            //    {
            //        Console.WriteLine("{0} {1}, {2}",
            //        person.SalePersonName.FirstName.Trim(),
            //        person.SalePersonName.LastName,
            //        person.Employee.Gender);
            //    }
            //}
            //Console.Write("Press Enter...");
            //Console.ReadLine();
            #endregion     
        
            #region example #5

            //using (var context = new AdventureWorks2008R2Entities())
            //{


            //    var salesPeople = context.SalesPersons
            //                        .Where(sp => sp.Employee.JobTitle == "Sales Representative")
            //                        .Select(sp => new { sp.Employee.Person.FirstName, sp.Employee.Person.LastName, sp.Employee });


            //    foreach (var person in salesPeople)
            //    {
            //        Console.WriteLine("{0} {1}, {2}",
            //        person.FirstName.Trim(),
            //        person.LastName,
            //        person.Employee.Gender);
            //    }
            //}
            //Console.Write("Press Enter...");
            //Console.ReadLine();
            #endregion

            #region example #6

            //using (var context = new AdventureWorks2008R2Entities())
            //{


            //    var salesPeople = context.SalesPersons
            //                        .Where(sp => sp.Employee.JobTitle == "Sales Representative")
            //                        .Select(sp => new { sp.Employee.Person.FirstName, sp.Employee.Person.LastName, sp.Employee });




            //    foreach (var person in salesPeople)
            //    {
            //        var salesPersonAddresses = context.BusinessEntityAddresses
            //            .Where(spa => spa.BusinessEntityID == person.Employee.BusinessEntityID)
            //            .Select(spa => new { spa.Address, spa.Address.StateProvince, spa.AddressType, spa.BusinessEntity });

            //        Console.WriteLine("{0} {1}, {2}", person.FirstName.Trim(), person.LastName, person.Employee.Gender);

            //        foreach (var address in salesPersonAddresses)
            //        {
            //            Console.WriteLine("{0}, {1}, {2}", address.Address.AddressLine1, address.Address.City, address.Address.StateProvince.Name);
            //        }
            //    }
            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();
            #endregion

            #region example #7

            //using (var context = new AdventureWorks2008R2Entities())
            //{


            //    var salesPeople = context.SalesPersons
            //                        .Where(sp => sp.Employee.JobTitle == "Sales Representative")
            //                        .Select(sp => new
            //                        {
            //                            sp.Employee.Person.FirstName,
            //                            sp.Employee.Person.LastName,
            //                            sp.Employee,
            //                            salesPersonAddresses = context.BusinessEntityAddresses
            //                                                    .Where(spa => spa.BusinessEntityID == sp.Employee.BusinessEntityID)
            //                                                    .Select(spa => new { spa.Address, spa.Address.StateProvince, spa.AddressType, spa.BusinessEntity })
            //                        });




            //    foreach (var person in salesPeople)
            //    {

            //        Console.WriteLine("{0} {1}, {2}", person.FirstName.Trim(), person.LastName, person.Employee.Gender);

            //        foreach (var address in person.salesPersonAddresses)
            //        {
            //            Console.WriteLine("{0}, {1}, {2}", address.Address.AddressLine1, address.Address.City, address.Address.StateProvince.Name);
            //        }
            //    }
            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();
            #endregion


            #region example #8

            //using (var context = new AdventureWorks2008R2Entities1())
            //{



            //    var customers = context.Customers
            //                .Where(c => c.Person != null)
            //                .OrderBy(c => c.Person.LastName)
            //                .ThenBy(c => c.Person.FirstName)
            //                .Select(c => new
            //                {
            //                    c.CustomerID,
            //                    c.AccountNumber,
            //                    c.Person,
            //                    Sales = c.SalesOrderHeaders
            //                            .Select(s => new { s.OrderDate, s.PurchaseOrderNumber, s.TotalDue, s.SalesOrderID, s.SalesOrderNumber, Details = s.SalesOrderDetails }),
            //                });

            //    foreach (var customer in customers)
            //    {
            //        string title = customer.Person.Title ?? string.Empty;
            //        title = (title.Length > 0) ? title + " " : title;

            //        Console.WriteLine("{0}{1} {2}", title, customer.Person.FirstName.Trim(), customer.Person.LastName);

            //        foreach (var sale in customer.Sales)
            //        {
            //            Console.WriteLine("Order Number: {0} :: Order Date: {1} :: Order Amount:  ${2}", sale.SalesOrderNumber, sale.OrderDate, sale.TotalDue);

            //            foreach (var detail in sale.Details)
            //            {
            //                Console.WriteLine("Product: {0} :: Quantity: {1} :: Line Amount:  ${2}", detail.Product.Name, detail.OrderQty, detail.LineTotal);
            //            }
            //        }

            //    }


            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();



            #endregion     
        

            #region example #9

            //using (var context = new AdventureWorks2008R2Entities1())
            //{


            //    var salesOrders = context.SalesOrderHeaders
            //            .Where(soh => soh.TotalDue > 150000)
            //            .OrderByDescending(soh => soh.TotalDue)
            //            .Select(soh => new { soh.SalesOrderID, soh.SalesOrderNumber, soh.OrderDate, soh.TotalDue, soh.SalesOrderDetails, Customer = soh.Customer.Person });




            //    foreach (var sale in salesOrders)
            //    {
            //        string title = sale.Customer.Title ?? string.Empty;
            //        title = (title.Length > 0) ? title + " " : title;

            //        Console.WriteLine("Order Number: {0} :: Order Date: {1} :: Order Amount:  ${2}", sale.SalesOrderNumber, sale.OrderDate, sale.TotalDue);
            //        Console.WriteLine("Customer: {0}{1} {2}", title, sale.Customer.FirstName.Trim(), sale.Customer.LastName);

            //    }


            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();

            #endregion     


            #region example #10

            //using (var context = new AdventureWorks2008R2Entities1())
            //{


            //    var salesOrders = context.SalesOrderHeaders
            //            .Where(soh => soh.TotalDue > 150000)
            //            .OrderByDescending(soh => soh.TotalDue)
            //            .Select(soh => new { soh.SalesOrderID, soh.SalesOrderNumber, soh.OrderDate, soh.TotalDue, soh.SalesOrderDetails, Customer = soh.Customer.Person });




            //    foreach (var sale in salesOrders)
            //    {
            //        string title = sale.Customer.Title ?? string.Empty;
            //        title = (title.Length > 0) ? title + " " : title;

            //        Console.WriteLine("Order Number: {0} :: Order Date: {1} :: Order Amount:  ${2}", sale.SalesOrderNumber, sale.OrderDate, sale.TotalDue);
            //        Console.WriteLine("Customer: {0}{1} {2}", title, sale.Customer.FirstName.Trim(), sale.Customer.LastName);

            //        foreach (var detail in sale.SalesOrderDetails)
            //        {
            //            Console.WriteLine("Product: {0} :: Quantity: {1} :: Line Amount:  ${2}", detail.Product.Name, detail.OrderQty, detail.LineTotal);
            //        }
            //    }


            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();

            #endregion 

            #region example #11

            //using (var context = new AdventureWorks2008R2Entities1())
            //{


            //    var salesOrders = context.SalesOrderHeaders
            //            .Where(soh => soh.SalesOrderDetails.Any(sod => sod.Product.ProductSubcategory.Name.Trim() == "Mountain Bikes"))
            //        //.OrderByDescending(soh => soh.TotalDue)
            //            .Select(soh => new { soh.SalesOrderID, soh.SalesOrderNumber, soh.OrderDate, soh.TotalDue, soh.SalesOrderDetails, Customer = soh.Customer.Person });




            //    foreach (var sale in salesOrders)
            //    {
            //        string title = sale.Customer.Title ?? string.Empty;
            //        title = (title.Length > 0) ? title + " " : title;

            //        Console.WriteLine("Order Number: {0} :: Order Date: {1} :: Order Amount:  ${2}", sale.SalesOrderNumber, sale.OrderDate, sale.TotalDue);
            //        Console.WriteLine("Customer: {0}{1} {2}", title, sale.Customer.FirstName.Trim(), sale.Customer.LastName);

            //        foreach (var detail in sale.SalesOrderDetails)
            //        {
            //            Console.WriteLine("Product: {0} :: Quantity: {1} :: Line Amount:  ${2}", detail.Product.Name, detail.OrderQty, detail.LineTotal);
            //        }
            //    }


            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();

            #endregion 

            #region example #12

            //using (var context = new AdventureWorks2008R2Entities1())
            //{


            //    var customers = context.Customers
            //                .Where(c => c.Person != null)
            //                .OrderBy(c => c.Person.LastName)
            //                .ThenBy(c => c.Person.FirstName)
            //                .Select(c => new
            //                {
            //                    c.CustomerID,
            //                    c.AccountNumber,
            //                    c.Person,
            //                    SalesCount = c.SalesOrderHeaders.Count
            //                });



            //    foreach (var customer in customers)
            //    {
            //        string title = customer.Person.Title ?? string.Empty;
            //        title = (title.Length > 0) ? title + " " : title;
            //        Console.WriteLine("{0}{1} {2}  :: Sales Count : {3}", title, customer.Person.FirstName.Trim(), customer.Person.LastName, customer.SalesCount);
            //    }


            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();

            #endregion 


            #region example #13

            //using (var context = new AdventureWorks2008R2Entities1())
            //{


            //    var customers = context.Customers
            //                .Where(c => c.Person != null && c.SalesOrderHeaders.Sum(soh => soh.TotalDue) > 100000)
            //                .OrderBy(c => c.Person.LastName)
            //                .ThenBy(c => c.Person.FirstName)
            //                .Select(c => new
            //                {
            //                    c.CustomerID,
            //                    c.AccountNumber,
            //                    c.Person,
            //                    SalesCount = c.SalesOrderHeaders.Count,
            //                    SalesTotal = c.SalesOrderHeaders.Sum(soh => soh.TotalDue)
            //                });



            //    foreach (var customer in customers)
            //    {
            //        string title = customer.Person.Title ?? string.Empty;
            //        title = (title.Length > 0) ? title + " " : title;
            //        Console.WriteLine("{0}{1} {2}  :: Sales Total : {3}", title, customer.Person.FirstName.Trim(), customer.Person.LastName, customer.SalesTotal);
            //    }


            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();

            #endregion 


            
            #region example #14

            //using (var context = new AdventureWorks2008R2Entities1())
            //{

            //    var customers = context.Customers
            //            .Where(c => c.Store != null && c.SalesOrderHeaders.Count != 0)
            //            .OrderBy(c => c.Store.Name)
            //            .Select(c => new { Store = c.Store, SalesTotal = c.SalesOrderHeaders.Sum(soh => soh.TotalDue) });


            //    foreach (var customer in customers)
            //    {
            //        Console.WriteLine("Store: {0} :: Sales Total : {1}", customer.Store.Name.Trim(), customer.SalesTotal);
            //    }


            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();

            #endregion 


            #region example #15

            //using (var context = new AdventureWorks2008R2Entities1())
            //{


            //    var customers = from c in context.Customers
            //                    where c.Store != null && c.SalesOrderHeaders.Count > 0
            //                    orderby c.Store.Name
            //                    select new { Store = c.Store, SalesTotal = c.SalesOrderHeaders.Sum(soh => soh.TotalDue) };

            //    foreach (var customer in customers)
            //    {
            //        Console.WriteLine("Store: {0} :: Sales Total : {1}", customer.Store.Name.Trim(), customer.SalesTotal);
            //    }

            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();

            #endregion 


            #region example #16

            //using (var context = new AdventureWorks2008R2Entities())
            //{
            //    using (var context1 = new AdventureWorks2008R2Entities1())
            //    {
            //        var salesPeople = (from sp in context.SalesPersons
            //                           select sp).ToList();

            //        var customers = (from c in context1.Customers
            //                         where c.Store != null
            //                         orderby c.Store.Name
            //                         select c).ToList();


            //        var data = from c in customers
            //                   join sp in salesPeople on c.Store.SalesPersonID equals sp.BusinessEntityID
            //                   select new { Store = c.Store, SalesPeople = sp.Employee.Person };

            //        foreach (var d in data)
            //        {
            //            Console.WriteLine("Store: {0} :: Sales Person : {1}, {2}", d.Store.Name.Trim(), d.SalesPeople.LastName, d.SalesPeople.FirstName);
            //        }

            //    }
            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();

            #endregion 



            #region example #17

            //using (var context = new AdventureWorks2008R2Entities())
            //{
            //    using (var context1 = new AdventureWorks2008R2Entities1())
            //    {
            //        var salesPeople = (from sp in context.SalesPersons
            //                           select sp).ToList();

            //        var customers = (from c in context1.Customers
            //                         where c.Store != null && c.SalesOrderHeaders.Count > 0
            //                         orderby c.Store.Name
            //                         select new { Customer = c, SalesTotal = c.SalesOrderHeaders.Sum(soh => soh.TotalDue) }).ToList();


            //        var data = from c in customers
            //                   join sp in salesPeople on c.Customer.Store.SalesPersonID equals sp.BusinessEntityID
            //                   select new { Store = c.Customer.Store, SalesPeople = sp.Employee.Person, SalesTotal = c.SalesTotal };


            //        foreach (var d in data)
            //        {
            //            Console.WriteLine("Store: {0} :: Sales Person : {1}, {2}  :: Sales Total : {3}", d.Store.Name.Trim(), d.SalesPeople.LastName, d.SalesPeople.FirstName, d.SalesTotal);
            //        }


            //    }
            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();

            #endregion 


            #region example #18

            //using (var context = new AdventureWorks2008R2Entities())
            //{
            //    using (var context1 = new AdventureWorks2008R2Entities1())
            //    {
            //        var salesPeople = (from sp in context.SalesPersons
            //                           select sp).ToList();

            //        var customers = (from c in context1.Customers
            //                         where c.Store != null && c.SalesOrderHeaders.Count > 0
            //                         orderby c.Store.Name
            //                         select new { Customer = c, SalesTotal = c.SalesOrderHeaders.Sum(soh => soh.TotalDue) }).ToList();

            //        var data = from c in customers
            //                   select new
            //                   {
            //                       Store = c.Customer.Store,
            //                       SalesTotal = c.SalesTotal,
            //                       SalesPeople = (from sp in salesPeople
            //                                      where c.Customer.Store.SalesPersonID == sp.BusinessEntityID
            //                                      select sp.Employee.Person).FirstOrDefault()
            //                   };



            //        foreach (var d in data)
            //        {
            //            Console.WriteLine("Store: {0} :: Sales Person : {1}, {2}  :: Sales Total : {3}", d.Store.Name.Trim(), d.SalesPeople.LastName, d.SalesPeople.FirstName, d.SalesTotal);
            //        }

            //    }
            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();

            #endregion 

            #region example #19

            //using (var context = new AdventureWorks2008R2Entities())
            //{
            //    using (var context1 = new AdventureWorks2008R2Entities1())
            //    {

            //        //var customers = (from c in context1.Customers
            //        //                 where c.Store != null && c.SalesOrderHeaders.Count > 0
            //        //                 orderby c.Store.Name
            //        //                 select new { Customer = c, Store = c.Store, SalesTotal = c.SalesOrderHeaders.Sum(soh => soh.TotalDue) }).ToList();

            //        //var salesPeople = from c in customers
            //        //                  select new { c, Store = c.Store, salesPerson = (from sp in context.SalesPersons where c.Customer.Store.SalesPersonID == sp.BusinessEntityID select sp) };

            //        var salesPeople = (from sp in context.SalesPersons
            //                           select sp).ToList();

            //        var customers = from sa in salesPeople
            //                        select new
            //                        {
            //                            sa,
            //                            customer = (from c in context1.Customers
            //                                        where c.Store.SalesPersonID == sa.BusinessEntityID //&& c.Store != null && c.SalesOrderHeaders.Count > 0
            //                                        orderby c.Store.Name
            //                                        select c).FirstOrDefault()
            //                        };

            //        foreach (var c in customers.ToList())
            //        {
            //            //Console.WriteLine("Store: {0} :: Sales Person : {1}, {2}  :: Sales Total : {3}", c.customer.Store.Name.Trim(), c.sa.Employee.Person.LastName, c.sa.Employee.Person.FirstName, 0.00);
            //            if (c.customer != null)
            //            {
            //                Console.WriteLine("Store: {0}", c.customer.Store.Name);
            //            }
                        
            //        }




            //    }
            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();

            #endregion 


            


            #region working code commented out

            //var salesPeople = context.SalesPersons
            //                    .Where(sp => sp.Employee.JobTitle == "Sales Representative")
            //                    .Select(sp => new
            //                    {
            //                        sp.Employee.Person.FirstName,
            //                        sp.Employee.Person.LastName,
            //                        sp.Employee,
            //                        salesPersonAddresses = context.BusinessEntityAddresses
            //                                                .Where(spa => spa.BusinessEntityID == sp.Employee.BusinessEntityID)
            //                                                .Select(spa => new { spa.Address, spa.Address.StateProvince, spa.AddressType, spa.BusinessEntity })
            //                    });




            //foreach (var person in salesPeople)
            //{

            //    Console.WriteLine("{0} {1}, {2}", person.FirstName.Trim(), person.LastName, person.Employee.Gender);

            //    foreach (var address in person.salesPersonAddresses)
            //    {
            //        Console.WriteLine("{0}, {1}, {2}", address.Address.AddressLine1, address.Address.City, address.Address.StateProvince.Name);
            //    }
            //}


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //var customers = context.Customers
            //            .Where(c => c.Person != null && c.SalesOrderHeaders.Sum(soh => soh.TotalDue) > 100000)
            //            .OrderBy(c => c.Person.LastName)
            //            .ThenBy(c => c.Person.FirstName)
            //            .Select(c => new
            //            {
            //                c.CustomerID,
            //                c.AccountNumber,
            //                c.Person,
            //                SalesCount = c.SalesOrderHeaders.Count,
            //                SalesTotal = c.SalesOrderHeaders.Sum(soh => soh.TotalDue)
            //            });

            //var customers = context.Customers
            //    .Where(c => c.Store != null && c.SalesOrderHeaders.Any(c1 => c1.TotalDue ==null))
            //    .OrderBy(c => c.Store.Name)
            //    .Select(c => new { Store = c.Store, SalesTotal = c.SalesOrderHeaders.Sum(soh => soh.TotalDue) });

            //var customers = context.Customers
            //        .Where(c => c.Store != null)
            //        .OrderBy(c => c.Store.Name)
            //        .Select(c => new { Store = c.Store, SalesTotal = c.SalesOrderHeaders.Sum(soh => soh.TotalDue)  });

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //var salesPeople = (from sp in context.SalesPersons
            //                   select sp).ToList();

            //var customers = from sa in salesPeople
            //                select new { sa, 
            //                             customer = (from c in context1.Customers 
            //                                         where c.Store != null && c.SalesOrderHeaders.Count > 0
            //                                         orderby c.Store.Name
            //                                         select c) };


            //(from c in context1.Customers
            // where c.Store != null && c.SalesOrderHeaders.Count > 0
            // orderby c.Store.Name
            // select new { Customer = c, SalesTotal = c.SalesOrderHeaders.Sum(soh => soh.TotalDue) }).ToList();





            //var data = from c in customers
            //           select new
            //           {
            //               Store = c.Customer.Store,
            //               SalesTotal = c.SalesTotal,
            //               SalesPeople = (from sp in salesPeople
            //                              where c.Customer.Store.SalesPersonID == sp.BusinessEntityID
            //                              select sp.Employee.Person).FirstOrDefault()
            //           };



            //var universe = from oa in context.vOfficeAddresses
            //    where oa.StateProvince == "Ontario"
            //    select oa;

            //    var query = from oa in universe
            //    select new
            //    {
            //    oa,
            //    contact = (from c in context.Contacts
            //    where c.ContactID == oa.ContactID
            //    select c)

            //foreach (var d in data)
            //{
            //    Console.WriteLine("Store: {0} :: Sales Person : {1}, {2}  :: Sales Total : {3}", d.Store.Name.Trim(), d.SalesPeople.LastName, d.SalesPeople.FirstName, d.SalesTotal);
            //}

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion
        }
    }
}
