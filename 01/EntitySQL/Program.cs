using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using System.Data.EntityClient;
using System.Data.Objects;


namespace EntitySQL
{
    class Program
    {
        static void Main(string[] args)
        {

            #region example #1
            //using (var context = new SPE())
            //{

            //    String query = "SELECT p.FirstName, p.LastName, p.Title " +
            //                   "FROM SPE.People AS p " +
            //                   "WHERE p.FirstName='Crystal'";

            //    ObjectQuery<DbDataRecord> salesPeople = context.CreateQuery<DbDataRecord>(query);

            //    foreach (var person in salesPeople)
            //    {
            //        string firstName, lastName, title;
            //        firstName = person.GetString(0).ToString();
            //        lastName = person.GetString(1).ToString();
            //        title = person.GetValue(2).GetType() == System.DBNull.Value.GetType() ? string.Empty : person.GetString(2).ToString();
            //        Console.WriteLine("{0} {1} {2}", title, firstName, lastName);
            //    }


            //}
            //Console.Write("Press Enter...");
            //Console.ReadLine();
            #endregion

            #region example #2
            //using (var context = new SPE())
            //{


            //    String query = "SELECT p.FirstName, p.LastName, p.Title " +
            //                   "FROM SPE.People AS p " +
            //                   "WHERE p.FirstName='Crystal'";

            //    ObjectQuery<DbDataRecord> salesPeople = context.CreateQuery<DbDataRecord>(query);

            //    foreach (var person in salesPeople)
            //    {
            //        Console.WriteLine("{0} {1} {2}",
            //            person["Title"].ToString().Trim(),
            //            person["FirstName"].ToString().Trim(),
            //            person["LastName"].ToString().Trim());
            //    }


            //}
            //Console.Write("Press Enter...");
            //Console.ReadLine();
            #endregion

            #region example #3
            //using (var context = new SPE())
            //{


            //    String query = "SELECT sp, sp.Employee, sp.Employee.Person " +
            //                   "FROM SPE.SalesPersons AS sp ";


            //    ObjectQuery<DbDataRecord> salesPeople = context.CreateQuery<DbDataRecord>(query);

            //    foreach (var sp in salesPeople)
            //    {
            //        Person p = sp[2] as Person;

            //        if (p != null)
            //        {
            //            Console.WriteLine("{0} {1} {2}",
            //                p.Title == null ? String.Empty : p.Title.ToString().Trim(),
            //                p.FirstName.ToString().Trim(),
            //                p.LastName.ToString().Trim());

            //        }
            //        else
            //        {
            //            Console.WriteLine("The value for the sales person information was not found.");
            //        }
            //    }


            //}
            //Console.Write("Press Enter...");
            //Console.ReadLine();
            #endregion

        }
    }
}
