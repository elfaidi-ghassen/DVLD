
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using Util;
using Util.DVLVBusinessLayer;

namespace DVLVBusinessLayer
{
    public class LocalDLApplicationManager
    {


        public static int GetApplicationIdByLocalId(int localAppId)
        {
            return LocalDLApplicationData.GetApplicationIdByLocalId(localAppId);
        }
        public static List<LocalManageDLApplication> GetApplications()
        {
            List<LocalManageDLApplication> rows = new List<LocalManageDLApplication>();
            foreach (DataRow row in LocalDLApplicationData.GetDataTable().Rows)
            {
                rows.Add(new LocalManageDLApplication(
                    Convert.ToInt32(row["LocalDrivingLicenseApplicationID"]),
                    (string)(row["ClassName"]),
                    (string)(row["NationalNo"]),
                    (string)(row["FullName"]),
                    (DateTime)(row["ApplicationDate"]),
                    Convert.ToInt32(row["PassedTests"]),
                    Convert.ToInt32(row["ApplicationStatus"])

                    ));
            }
            return rows;
        }

        public static LocalManageDLApplication GetApplicatioByLocalId(int localAppId)
        {
            DataRow appRow = LocalDLApplicationData.GetApplicatioByLocalId(localAppId);
            if (appRow == null) { return null; }
            return RowToDLApplication(appRow);
        }

        private static LocalManageDLApplication RowToDLApplication(DataRow row)
        {
            return new LocalManageDLApplication(
                    Convert.ToInt32(row["LocalDrivingLicenseApplicationID"]),
                    (string)(row["ClassName"]),
                    (string)(row["NationalNo"]),
                    (string)(row["FullName"]),
                    (DateTime)(row["ApplicationDate"]),
                    Convert.ToInt32(row["PassedTests"]),
                    Convert.ToInt32(row["ApplicationStatus"])

                    );
        }
        public static List<LocalManageDLApplication> GetApplicationsByStatus(enApplicationStatus status)
        {
            List<LocalManageDLApplication> rows = new List<LocalManageDLApplication>();
            foreach (DataRow row in LocalDLApplicationData.GetDataTableByStatusDataTable(status).Rows)
            {
                rows.Add(RowToDLApplication(row));
            }
            return rows;
        }
        public static int? CreateApplication(int applicationId, int licenseClassId)
        {
            return DrivingLicenseApplicationData.CreateApplication(applicationId, licenseClassId);
        }
        public static bool PersonHasActiveDLApplication(int personId, int licenseClassId)
        {
            return DrivingLicenseApplicationData.PersonHasActiveDLApplication(personId, licenseClassId);
        }
    }
}
