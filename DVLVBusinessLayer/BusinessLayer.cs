using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Util;
using static System.Net.Mime.MediaTypeNames;

namespace DVLVBusinessLayer
{
    public class PersonManager
    {
        public static bool PersonIsUser(int personId)
        {
            return PeopleData.PersonIsUser(personId);
        }
        public static bool DeleteById(int id)
        {
            Person toBeDeleted = GetPersonById(id);
            bool deleted = PeopleData.DeleteById(id);
            
            if (deleted && toBeDeleted.ImagePath != null)
            {
                ImageHandler.DeleteImage(toBeDeleted.ImagePath);
            }
            return deleted;
        }
        public static DataTable GetPeopleDataTable()
        {
            return PeopleData.GetPeopleDataTable();

        }
        public static Person GetPersonById(int id)
        {
            return PeopleData.GetPersonById(id);
        }
        public static Person GetPersonByNationalNo(string nat)
        {
            return PeopleData.GetPersonByNationalNo(nat);
        }
        public static bool AddPerson(string nationalNo, string firstName, string secondName,
                    string thirdName, string lastName, DateTime dateOfBirth, enGender gendor,
                    string address, string phone, string email, int nationalityCountryID,
                    string imagePath) {

            if (imagePath != null)
                imagePath = ImageHandler.SaveImage(imagePath, Settings.IMAGES_PATH);

            return PeopleData.AddPerson(nationalNo, firstName, secondName,
                    thirdName, lastName, dateOfBirth, (int)gendor,
                    address, phone, email, nationalityCountryID,
                    imagePath) != null;
        }

        public static int? AddPersonGetId(string nationalNo, string firstName, string secondName,
            string thirdName, string lastName, DateTime dateOfBirth, enGender gendor,
            string address, string phone, string email, int nationalityCountryID,
            string imagePath)
        {

            if (imagePath != null)
                imagePath = ImageHandler.SaveImage(imagePath, Settings.IMAGES_PATH);

            return PeopleData.AddPerson(nationalNo, firstName, secondName,
                    thirdName, lastName, dateOfBirth, (int)gendor,
                    address, phone, email, nationalityCountryID,
                    imagePath);
        }



        public static bool UpdatePerson(Person person)
        {
            if (!PeopleData.PersonExists(person.PersonID))
            {
                return false;
            }
            Person oldPerson = PeopleData.GetPersonById(person.PersonID);
            if (oldPerson.ImagePath != null && oldPerson.ImagePath != person.ImagePath)
            {
                ImageHandler.DeleteImage(oldPerson.ImagePath);
            }

            if (person.ImagePath != null)
                person.ImagePath = ImageHandler.SaveImage(person.ImagePath, Settings.IMAGES_PATH);
            return PeopleData.UpdatePerson(person);

        }



        public static bool NationalNoExists(string NationalNo)
        {
            return PeopleData.NationalNoExists(NationalNo);
        }
    }
}
