using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DVLVBusinessLayer
{
    public class DriverManager
    {
        public static List<DriverView> GetDriversViewList()
        {
            List<DriverView> drivers = new List<DriverView>();
            foreach (DataRow row in DriversData.GetDriversViewDataTable().Rows)
            {
                drivers.Add(DataRowToDriverView(row));
            }
            return drivers;
        }

        private static DriverView DataRowToDriverView(DataRow row)
        {
            return new DriverView(
                    Convert.ToInt32(row["DriverID"]),
                    Convert.ToInt32(row["PersonID"]),
                    row["NationalNo"].ToString(),
                    row["FullName"].ToString(),
                    (DateTime)row["CreatedDate"],
                    Convert.ToInt32(row["ActiveLicensesCount"]));
        }
        public static bool PersonIsDriver(int PersonID)
        {
            return DriversData.PersonIsDriver(PersonID);
        }
        public static Driver GetDriverByPersonId(int PersonID)
        {
            return DataRowToDriver(DriversData.GetDataRowByPersonID(PersonID));

        }
        private static Driver DataRowToDriver(DataRow row)
        {
            if (row == null)
                return null;

            return new Driver(
                driverID: Convert.ToInt32(row["DriverID"]),
                personID: Convert.ToInt32(row["PersonID"]),
                createdByUserID: Convert.ToInt32(row["CreatedByUserID"]),
                createdDate: Convert.ToDateTime(row["CreatedDate"])
            );
        }
        public static int? AddDriverGetId(int PersonID, int UserID)
        {
            return DriversData.AddDriverGetId(PersonID, UserID);
        }
    }
}
