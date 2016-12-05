using System;
using System.Collections.Generic;
using System.Data;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Linq;
using System.Text;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {

            #region example #1
            //using (var context = new AdventureWorks2008R2Entities())
            //{
            //    var salesPeople = context.SalesPersons;
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
            //    ObjectSet<SalesPerson> salesPeople = context.SalesPersons;
            //    foreach (SalesPerson person in salesPeople)
            //    {
            //        Console.WriteLine("{0} {1}",
            //        person.Employee.Person.FirstName.Trim(),
            //        person.Employee.Person.LastName);
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

            #region example #4

            //using (var context = new AdventureWorks2008R2Entities())
            //{

            //    var salesPeople = from sp in context.SalesPersons
            //                      where sp.Employee.Person.FirstName == "Stephen" || sp.Employee.Person.LastName == "Blythe"
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


            #region example #5

            //using (var context = new AdventureWorks2008R2Entities())
            //{

            //    var queryString = "SELECT VALUE sp " +
            //                        "FROM AdventureWorks2008R2Entities.SalesPersons AS sp " +
            //                        "WHERE sp.Employee.Person.FirstName == 'Stephen'";

            //    ObjectQuery<SalesPerson> salesPeople = context.CreateQuery<SalesPerson>(queryString);


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

            #region example #6

            //using (var context = new AdventureWorks2008R2Entities())
            //{

            //    var queryString = "SELECT VALUE sp " +
            //                        "FROM AdventureWorks2008R2Entities.SalesPersons AS sp " +
            //                        "WHERE sp.Employee.Person.FirstName == @firstName";

            //    ObjectParameter op = new ObjectParameter("firstName", "Stephen");
            //    ObjectParameter[] ops = new ObjectParameter[1];
            //    ops[0] = op;

            //    ObjectQuery<SalesPerson> salesPeople = context.CreateQuery<SalesPerson>(queryString, op);


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

            #region example #7

            //using (var context = new AdventureWorks2008R2Entities())
            //{

            //    var queryString = "SELECT VALUE sp " +
            //                        "FROM AdventureWorks2008R2Entities.SalesPersons AS sp " +
            //                        "WHERE sp.Employee.Person.FirstName == @firstName";

            //    ObjectQuery<SalesPerson> salesPeople = new ObjectQuery<SalesPerson>(queryString, context);
            //    salesPeople.Parameters.Add(new ObjectParameter("firstName", "Stephen"));


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

            #region example #8

            //using (var context = new AdventureWorks2008R2Entities())
            //{
            //    var salesPeople = context.SalesPersons.Where(c => c.Employee.Person.FirstName == "Stephen");

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

            #region example #9

            //using (var context = new AdventureWorks2008R2Entities())
            //{
            //    var salesPeople = context.SalesPersons
            //                                .Where(sp => sp.Employee.JobTitle == "Sales Representative")
            //                                .OrderBy(sp => sp.Employee.Person.LastName);

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


            #region example #10

            //using (var context = new AdventureWorks2008R2Entities())
            //{


            //    var salesPeople = context.SalesPersons
            //                            .Where("it.Employee.JobTitle == 'Sales Representative'")
            //                            .OrderBy("it.Employee.Person.LastName");

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

            //Program.EntityClientQueryContacts();

        }


        #region working code commented out
        static void EntityClientQueryContacts()
        {
            //using (EntityConnection conn = new EntityConnection("name=AdventureWorks2008R2Entities"))
            //{
            //    conn.Open();
            //    var queryString = "SELECT VALUE sp " +
            //                        "FROM AdventureWorks2008R2Entities.SalesPersons AS sp ";
                
            //    //var queryString =   "SELECT VALUE p " +
            //    //                    "FROM AdventureWorks2008R2Entities.SalesPersons AS sp " +
            //    //                    "  INNER JOIN AdventureWorks2008R2Entities.Employees AS e ON e.BusinessEntityID = sp.BusinessEntityID " +
            //    //                    "  INNER JOIN AdventureWorks2008R2Entities.People AS p ON p.BusinessEntityID = sp.BusinessEntityID " + 
            //    //                    "WHERE sp.Employee.Person.FirstName == 'Stephen'";

            //    //var queryString =   "SELECT sp, e, p " +
            //    //                    "FROM AdventureWorks2008R2Entities.SalesPersons AS sp " +
            //    //                    "  INNER JOIN AdventureWorks2008R2Entities.Employees AS e ON e.BusinessEntityID = sp.BusinessEntityID " +
            //    //                    "  INNER JOIN AdventureWorks2008R2Entities.People AS p ON p.BusinessEntityID = sp.BusinessEntityID " +
            //    //                    "WHERE sp.Employee.Person.FirstName == 'Stephen'";

            //    EntityCommand cmd = conn.CreateCommand();
            //    cmd.CommandText = queryString;
                
            //    using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
            //    {
            //        while (rdr.Read())
            //        {

            //            var results = from sp in rdr.OfType<SalesPerson>().AsEnumerable() select sp;

            //            foreach (var r in results.ToList())
            //            { 
                            
            //            }
            //            //var col1 = rdr[0];
            //            //var col2 = rdr[1];
            //            //var col3 = rdr[2];

            //            //Console.WriteLine("{0} {1}", rdr.GetString(4).Trim(), rdr.GetString(6).Trim());
            //        }
            //    }

            //    conn.Close();
            //    Console.Write("Press Enter...");
            //    Console.ReadLine();
            //}
        }
        #endregion

    }
}
