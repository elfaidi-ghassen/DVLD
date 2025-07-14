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
        public static List<LicenseClass> GetAllClasses()
        {
            List<LicenseClass> classes = new List<LicenseClass>();
            foreach (DataRow row in LicenseClassData.GetDataTable().Rows)
            {
                // Store values in variables for debugging
                object idObj = row["LicenseClassID"];
                object nameObj = row["ClassName"];
                object descObj = row["ClassDescription"];
                object ageObj = row["MinimumAllowedAge"];
                object validityObj = row["DefaultValidityLength"];
                object feesObj = row["ClassFees"];

                // Optional: You can set breakpoints or log these values here
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
