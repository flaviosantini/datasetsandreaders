using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReadersAndSets
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateTables.CreateSmallTable();
            //CreateTables.CreateLargeTable();
            //CreateTables.GenerateDataLargeTable();
            //CreateTables.GenerateDataSmallTable();

            var dateTimeList = new List<DateTime> {DateTime.Now};
            
            //Start Calling
            //var records = RetrieveData.RetrieveLargeObjectUsingReader();
            //var records = RetrieveData.RetrieveSmallObjectsUsinReader();
            //var records = RetrieveData.RetrieveLargeObjectUsingDataSet();
            var records = RetrieveData.RetrieveSmallObjectUsingDataSet();
            dateTimeList.Add(DateTime.Now);

            //Iterating through list
            foreach (DataRow record in records.Rows)
            {
                Console.WriteLine(record["Id"]);
            }

            dateTimeList.Add(DateTime.Now);

            foreach (var dateTime in dateTimeList)
            {
                Console.WriteLine(dateTime.ToString(CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
