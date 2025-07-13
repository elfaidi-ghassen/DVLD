using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{

        public enum enGender { Male, Female }
        public class Person
        {
            public int PersonID { get; set; }
            public string NationalNo { get; set; }
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string ThirdName { get; set; } // nullable
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public enGender Gendor { get; set; } 
            public string Address { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; } // nullable
            public int NationalityCountryID { get; set; }
            public string ImagePath { get; set; } // nullable
            public Person(int personID, string nationalNo, string firstName, string secondName,
                    string thirdName, string lastName, DateTime dateOfBirth, enGender gendor,
                    string address, string phone, string email, int nationalityCountryID,
                    string imagePath)
            {
                PersonID = personID;
                NationalNo = nationalNo;
                FirstName = firstName;
                SecondName = secondName;
                ThirdName = thirdName;
                LastName = lastName;
                DateOfBirth = dateOfBirth;
                Gendor = gendor;
                Address = address;
                Phone = phone;
                Email = email;
                NationalityCountryID = nationalityCountryID;
                ImagePath = imagePath;
            }

        public string FullName
        {
            get
            {
                return String.Join(" ", new List<string>() 
                        { FirstName, SecondName, ThirdName, LastName }
                        .Where(s => s != null));

            }
        }


    }
}
