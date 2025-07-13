using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
using DataAccessLayer;
namespace DVLVBusinessLayer
{
    public class CountryManager
    {
        public static List<Country> GetAllCountries()
        {
            return CountryData.GetAllCountries();
        }
        public static Country FindCountryById(int id)
        {
            return CountryData.FindCountryById(id);
        }
        public static Country FindCountryByName(string name)
        {
            return CountryData.FindCountryByName(name);
        }
    }
}
