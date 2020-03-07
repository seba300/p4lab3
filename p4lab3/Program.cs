using System;
using System.Data.SqlClient;
using Dapper;

namespace p4lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            using var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            var db = new DB();
            db.Select(connection);
           // db.Insert(connection, 90, "RegionZ");

            Region reg = new Region();
            reg.RegionID = 300;
            //db.Delete(connection,reg);
        }
    }
}
