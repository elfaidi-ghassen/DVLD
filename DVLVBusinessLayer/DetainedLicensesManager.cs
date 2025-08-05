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
    public class DetainedLicensesManager
    {


        /// <summary>
        /// Return a List of DetainedRecord objects populated
        /// from the database as data rows
        /// </summary>
        public static List<DetainedRecord> GetDetainedLicensesList()
        {
            List<DetainedRecord> listOfDetaiendLicenses = new List<DetainedRecord>();
            return DetainedLicensesData.GetRecordsDataTable()
                .Rows.Cast<DataRow>().Select(row => RowToDetainedRecord(row)).ToList();
        }
        private static DetainedRecord RowToDetainedRecord(DataRow row)
        {

            DateTime? releaseDate = null;
            int? releasedByUserID = null;
            int? releaseApplicationID = null;
            if (row["ReleaseDate"] != DBNull.Value)
                releaseDate = (DateTime)row["ReleaseDate"];
            if (row["ReleasedByUserID"] != DBNull.Value)
                releasedByUserID = Convert.ToInt32(row["ReleasedByUserID"]);
            if (row["ReleaseApplicationID"] != DBNull.Value)
                releaseApplicationID = Convert.ToInt32(row["ReleaseApplicationID"]);


            return new DetainedRecord(
                detainID: Convert.ToInt32(row["DetainID"]),
                licenseID: Convert.ToInt32(row["LicenseID"]),
                detainDate: Convert.ToDateTime(row["DetainDate"]),
                fineFees: Convert.ToDecimal(row["FineFees"]),
                createdByUserID: Convert.ToInt32(row["CreatedByUserID"]),
                isReleased: Convert.ToInt32(row["IsReleased"]) == 1,
                releaseDate: releaseDate,
                releasedByUserID: releasedByUserID,
                releaseApplicationID: releaseApplicationID,
                nationalNumber: row["NationalNo"].ToString(),
                fullName: row["FullName"].ToString(),
                driverID: Convert.ToInt32(row["DriverId"]));
        }
    }
}
