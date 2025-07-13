using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DVLVBusinessLayer
{
    public class TestTypeManager
    {
        public static bool Update(TestType type)
        {
            return TestTypeData.Update(type);
        }
        public static TestType GetTestTypeById(int id)
        {
            return RowToTestType(
                TestTypeData.GetTestTypeById(id));
        }
        public static List<TestType> GetAllTestTypes()
        {
            List<TestType> typesList = new List<TestType>();

            foreach (DataRow row in TestTypeData.GetDataTable().Rows)
            {
                typesList.Add(RowToTestType(row));
            }

            return typesList;


        }
        private static TestType RowToTestType(DataRow row)
        {
            if (row == null) { return null; }
            return new TestType(
                                (int)row["TestTypeId"],
                                (string)row["TestTypeTitle"],
                                (string)row["TestTypeDescription"],
                                (Decimal)row["TestTypeFees"]);
        }
    }
}

