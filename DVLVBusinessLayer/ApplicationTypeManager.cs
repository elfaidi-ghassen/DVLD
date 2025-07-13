using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLVBusinessLayer
{
    public class ApplicationTypeManager
    {
        public static bool Update(ApplicationType type)
        {
            return ApplicationTypesData.Update(type);
        }
        public static ApplicationType GetApplicationTypeById(int id)
        {
            return RowToApplicationType(
                ApplicationTypesData.GetApplicationTypeById(id));
        }
        public static List<ApplicationType> GetAllApplicationsTypes()
        {
            List<ApplicationType> typesList = new List<ApplicationType>();

            foreach (DataRow row in ApplicationTypesData.GetDataTable().Rows)
            {
                typesList.Add(RowToApplicationType(row));
            }

            return typesList;


        }
        private static ApplicationType RowToApplicationType(DataRow row)
        {
            if (row == null) { return null; }
            return new ApplicationType(
                                (int)row["ApplicationTypeId"],
                                (string)row["ApplicationTypeTitle"],
                                (Decimal)row["ApplicationFees"]);
        }
    }
}
