
using DataAccessLayer;

namespace DVLVBusinessLayer
{
    public class DrivingLicenseApplicationManager
    {
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
