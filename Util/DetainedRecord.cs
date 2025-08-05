using System;

namespace Util
{
    public class DetainedRecord
    {
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }
        public string NationalNumber { get; set; }
        public string FullName { get; set; }
        public int DriverID { get; set; }


        public DetainedRecord(int detainID, int licenseID, DateTime detainDate,
                             decimal fineFees, int createdByUserID, bool isReleased,
                             DateTime? releaseDate, int? releasedByUserID,
                             int? releaseApplicationID, string nationalNumber,
                             string fullName, int driverID)
        {
            DetainID = detainID;
            LicenseID = licenseID;
            DetainDate = detainDate;
            FineFees = fineFees;
            CreatedByUserID = createdByUserID;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseApplicationID = releaseApplicationID;
            NationalNumber = nationalNumber;
            FullName = fullName;
            DriverID = driverID;
        }

        public object[] ToDataRow()
        {
            return new object[]
            {
                DriverID,
                LicenseID,
                DetainDate,
                IsReleased ? "Yes" : "No",
                FineFees,
                IsReleased ? ((DateTime)ReleaseDate).ToShortDateString() : "N/A",
                NationalNumber,
                FullName,
                IsReleased ? ReleaseApplicationID.ToString() : "N/A"
            };
        }
    }
}