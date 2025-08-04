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
    public class LicenseClassManager
    {
        public static LicenseClass GetLicenseClassById(int idToFind)
        {
            DataRow row = LicenseClassData.GetDataRowById(idToFind);
            int id = Convert.ToInt32(row["LicenseClassID"]);
            string name = row["ClassName"]?.ToString();
            string description = row["ClassDescription"]?.ToString();
            int minAge = Convert.ToInt32(row["MinimumAllowedAge"]);
            int validity = Convert.ToInt32(row["DefaultValidityLength"]);
            decimal fees = Convert.ToDecimal(row["ClassFees"]);
            return new LicenseClass(id, name, description, minAge, validity, fees);
        }
        
        public static List<LicenseClass> GetAllClasses()
        {
            List<LicenseClass> classes = new List<LicenseClass>();
            foreach (DataRow row in LicenseClassData.GetDataTable().Rows)
            {

                object idObj = row["LicenseClassID"];
                object nameObj = row["ClassName"];
                object descObj = row["ClassDescription"];
                object ageObj = row["MinimumAllowedAge"];
                object validityObj = row["DefaultValidityLength"];
                object feesObj = row["ClassFees"];

                int id = Convert.ToInt32(idObj);
                string name = nameObj?.ToString();
                string description = descObj?.ToString();
                int minAge = Convert.ToInt32(ageObj);
                int validity = Convert.ToInt32(validityObj);
                decimal fees = Convert.ToDecimal(feesObj);

                classes.Add(new LicenseClass(id, name, description, minAge, validity, fees));
            }

            return classes;
        }

    }
}
