using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataReadersAndSets
{
    public static class RetrieveData
    {
        const string SqlInstructionSmallTable = "SELECT * FROM SMALLTABLE;";
        const string SqlInstructionLargeTable = "SELECT * FROM LARGETABLE;";

        public static IList<LargeObject> RetrieveLargeObjectUsingReader()
        {
            var reader = SqlObject.RetrieveQueryInDataReader(SqlInstructionLargeTable);

            return reader.Select(dataReader => new LargeObject
            {
                Id = dataReader.GetInt32(0), 
                Field01 = dataReader.GetString(1), 
                Field02 = dataReader.GetString(2), 
                Field03 = dataReader.GetString(3), 
                Field04 = dataReader.GetString(4), 
                Field05 = dataReader.GetString(5), 
                Field06 = dataReader.GetString(6), 
                Field07 = dataReader.GetString(7), 
                Field08 = dataReader.GetString(8), 
                Field09 = dataReader.GetString(9), 
                Field10 = dataReader.GetString(10), 
                Field11 = dataReader.GetString(11), 
                Field12 = dataReader.GetString(12), 
                Field13 = dataReader.GetString(13), 
                Field14 = dataReader.GetString(14), 
                Field15 = dataReader.GetString(15), 
                Field16 = dataReader.GetString(16), 
                Field17 = dataReader.GetString(17), 
                Field18 = dataReader.GetString(18), 
                Field19 = dataReader.GetString(19), 
                Field20 = dataReader.GetString(20), 
                Field21 = dataReader.GetString(21), 
                Field22 = dataReader.GetString(22), 
                Field23 = dataReader.GetString(23), 
                Field24 = dataReader.GetString(24), 
                Field25 = dataReader.GetString(25), 
                Field26 = dataReader.GetString(26), 
                Field27 = dataReader.GetString(27), 
                Field28 = dataReader.GetString(28), 
                Field29 = dataReader.GetString(29), 
                Field30 = dataReader.GetString(30), 
                Field31 = dataReader.GetString(31), 
                Field32 = dataReader.GetString(32), 
                Field33 = dataReader.GetString(33), 
                Field34 = dataReader.GetString(34), 
                Field35 = dataReader.GetString(35), 
                Field36 = dataReader.GetString(36), 
                Field37 = dataReader.GetString(37), 
                Field38 = dataReader.GetString(38), 
                Field39 = dataReader.GetString(39), 
                Field40 = dataReader.GetString(40), 
                Field41 = dataReader.GetString(41), 
                Field42 = dataReader.GetString(42), 
                Field43 = dataReader.GetString(43), 
                Field44 = dataReader.GetString(44), 
                Field45 = dataReader.GetString(45), 
                Field46 = dataReader.GetString(46), 
                Field47 = dataReader.GetString(47), 
                Field48 = dataReader.GetString(48), 
                Field49 = dataReader.GetString(49), 
                Field50 = dataReader.GetString(50), 
                Field51 = dataReader.GetString(51), 
                Field52 = dataReader.GetString(52), 
                Field53 = dataReader.GetString(53), 
                Field54 = dataReader.GetString(54), 
                Field55 = dataReader.GetString(55), 
                Field56 = dataReader.GetString(56), 
                Field57 = dataReader.GetString(57), 
                Field58 = dataReader.GetString(58), 
                Field59 = dataReader.GetString(59), 
                Field60 = dataReader.GetString(60)
            }).ToList();
        }

        public static IList<SmallObject> RetrieveSmallObjectsUsinReader()
        {
            var reader = SqlObject.RetrieveQueryInDataReader(SqlInstructionSmallTable);

            return reader.Select(dataReader => new SmallObject()
            {
                Id = dataReader.GetInt32(0),
                Field01 = dataReader.GetString(1),
                Field02 = dataReader.GetString(2),
                Field03 = dataReader.GetString(3),
                Field04 = dataReader.GetString(4),
                Field05 = dataReader.GetString(5),
                Field06 = dataReader.GetString(6),
                Field07 = dataReader.GetString(7),
                Field08 = dataReader.GetString(8),
                Field09 = dataReader.GetString(9),
                Field10 = dataReader.GetString(10)
            }).ToList();
        }

        public static DataTable RetrieveLargeObjectUsingDataSet()
        {
            return SqlObject.RetrieveQueryInDataSet(SqlInstructionLargeTable).Tables[0];
        }

        public static DataTable RetrieveSmallObjectUsingDataSet()
        {
            return SqlObject.RetrieveQueryInDataSet(SqlInstructionSmallTable).Tables[0];
        }
    }
}