using System;
using System.Text;

namespace DataReadersAndSets
{
    public static class CreateTables
    {
        public static void CreateSmallTable()
        {
            var instruction = new StringBuilder();
            instruction.AppendLine("CREATE TABLE SmallTable ");
            instruction.AppendLine("(");
            instruction.AppendLine("ID INT ");

            for (var i = 0; i < 10; i++)
            {
                instruction.AppendLine(String.Format(", COLUMN{0} VARCHAR(150) ", i));
            }
            instruction.AppendLine(");");
            SqlObject.Execute(instruction.ToString());
        }

        public static void CreateLargeTable()
        {
            var instruction = new StringBuilder();
            instruction.AppendLine("CREATE TABLE LargeTable ");
            instruction.AppendLine("(");
            instruction.AppendLine("ID INT ");

            for (var i = 0; i < 60; i++)
            {
                instruction.AppendLine(String.Format(", COLUMN{0} VARCHAR(150) ", i));
            }
            instruction.AppendLine(");");
            SqlObject.Execute(instruction.ToString());
        }

        public static void GenerateDataLargeTable()
        {
            for (var recordNumber = 0; recordNumber < 300 * 1000; recordNumber++)
            {
                var instruction = new StringBuilder();
                instruction.AppendLine("INSERT INTO LargeTable VALUES ");
                instruction.AppendLine("(");
                instruction.AppendLine(String.Format("{0} ", recordNumber));

                for (var columnNumber = 0; columnNumber < 60; columnNumber++)
                {
                    instruction.AppendLine(String.Format(", '{0}-{1}'  ", recordNumber, columnNumber));
                }
                instruction.AppendLine(");");

                SqlObject.Execute(instruction.ToString());
            }
            
        }

        public static void GenerateDataSmallTable()
        {
            for (var recordNumber = 54501; recordNumber < 300 * 1000; recordNumber++)
            {
                var instruction = new StringBuilder();
                instruction.AppendLine("INSERT INTO SmallTable VALUES ");
                instruction.AppendLine("(");
                instruction.AppendLine(String.Format("{0} ", recordNumber));

                instruction.AppendLine(String.Format(", '{0}-0', '{0}-1', '{0}-2', '{0}-3', '{0}-4', '{0}-5', '{0}-6', '{0}-7', '{0}-8', '{0}-9'  ",
                    recordNumber));
                instruction.AppendLine(");");

                SqlObject.Execute(instruction.ToString());
            }
        }

        public static void DeleteRecordsLargeTable()
        {
            
        }

        public static void DeleteRecordsSmallTable()
        {
            
        }
    }
}