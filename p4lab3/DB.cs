using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace p4lab3
{
    class DB
    {
        public void Select(IDbConnection connection)
        {
            string sql = "SELECT * FROM Region";
            var result = connection.Query<Region>(sql);
            foreach(var item in result)
            {
                Console.WriteLine(item.RegionID + " "+item.RegionDescription);
            }
        }

        public void Insert(IDbConnection connection,int id,string desc)
        {
            var sql = @"INSERT INTO Region(RegionID, RegionDescription) VALUES(@id,@desc)";
            var changed = connection.Execute(sql,
                new {
                    id = id,
                    desc=desc
                });
            Console.WriteLine($"Wrzucono {changed}");
        }

        public void Delete(IDbConnection connection, Region region)
        {

            var sql = @"DELETE FROM Region WHERE RegionID = @idRegion";
            var changed = connection.Execute(sql,
                new
                {
                    idRegion = region.RegionID
                }
                );
            Console.WriteLine($"Wrzucono {changed}");

        }
    }
}
