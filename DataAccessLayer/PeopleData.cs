using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace DataAccessLayer
{
    public class PeopleData
    {
        public static bool PersonIsUser(int personId)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                            SELECT 1 
                            FROM users WHERE 
                            PersonId = @PersonId";

            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@PersonId", personId);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                found = reader.Read();
                reader.Close();
            }
            catch (Exception e)
            {
                // !!!
            }
            finally
            {
                connection.Close();
            }
            return found;
        }
        public static bool DeleteById(int id)
        {
            int affectedRows = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"DELETE FROM People
                            WHERE PersonId = @PersonId";

            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@PersonId", id);
            try
            {
                connection.Open();
                affectedRows = command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                // !!!
            }
            finally
            {
                connection.Close();
            }

            return affectedRows > 0;
        }
        public static bool PersonExists(int id)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"SELECT 1 AS exist
                             FROM people
                             WHERE PersonId = @PersonId";

            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@PersonId", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                found = reader.Read();
                reader.Close();
            }
            catch (Exception e)
            {
                // !!!
            }
            finally
            {
                connection.Close();
            }
            return found;

        }
        public static Person GetPersonById(int personID)
        {
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"SELECT * 
                     FROM People
                     WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@PersonID", personID);

            // Initialize all fields as null
            int foundPersonID = 0;
            string nationalNo = null, firstName = null, secondName = null,
                   thirdName = null, lastName = null,
                   address = null, phone = null, email = null, imagePath = null;
            int? nationalityCountryID = null;
            enGender? gender = null;
            DateTime? dateOfBirth = null;
            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    foundPersonID = (int)reader["PersonID"];

  
                    nationalNo = (string)reader["NationalNo"];

                    firstName = (string)reader["FirstName"];

                    secondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                        thirdName = (string)reader["ThirdName"];

                    lastName = (string)reader["LastName"];

                    gender = (enGender)(Convert.ToInt32(reader["Gendor"]));

                    address = (string)reader["Address"];

                    phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        email = (string)reader["Email"];

                    nationalityCountryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                        imagePath = (string)reader["ImagePath"];

                    dateOfBirth = (DateTime)reader["DateOfBirth"];

                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Log the exception if needed
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            if (isFound)
            {
                return new Person(
                personID: foundPersonID,
                nationalNo: nationalNo,
                firstName: firstName,
                secondName: secondName,
                thirdName: thirdName,
                lastName: lastName,
                dateOfBirth: (DateTime) dateOfBirth,
                gendor: (enGender)gender, 
                address: address,
                phone: phone,
                email: email,
                nationalityCountryID: (int)nationalityCountryID,
                imagePath: imagePath);
            }
            else
            {
                return null;
            }
        }

        public static Person GetPersonByNationalNo(string nationalNo)
        {
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"SELECT * 
                     FROM People
                     WHERE NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@NationalNo", nationalNo);

            // Initialize all fields as null

            string firstName = null, secondName = null,
                   thirdName = null, lastName = null,
                   address = null, phone = null, email = null, imagePath = null;
            int? nationalityCountryID = null;
            int? personId = null;
            enGender? gender = null;
            DateTime? dateOfBirth = null;
            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {



                    personId = (int)reader["PersonID"];

                    firstName = (string)reader["FirstName"];

                    secondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                        thirdName = (string)reader["ThirdName"];

                    lastName = (string)reader["LastName"];

                    gender = (enGender)(Convert.ToInt32(reader["Gendor"]));

                    address = (string)reader["Address"];

                    phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        email = (string)reader["Email"];

                    nationalityCountryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                        imagePath = (string)reader["ImagePath"];

                    dateOfBirth = (DateTime)reader["DateOfBirth"];

                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Log the exception if needed
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            if (isFound)
            {
                return new Person(
                personID: (int)personId,
                nationalNo: nationalNo,
                firstName: firstName,
                secondName: secondName,
                thirdName: thirdName,
                lastName: lastName,
                dateOfBirth: (DateTime)dateOfBirth,
                gendor: (enGender)gender,
                address: address,
                phone: phone,
                email: email,
                nationalityCountryID: (int)nationalityCountryID,
                imagePath: imagePath);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetPeopleDataTable()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"SELECT [PersonID]
                                  ,[NationalNo]
                                  ,[FirstName]
                                  ,[SecondName]
                                  ,[ThirdName]
                                  ,[LastName]
                                  ,[DateOfBirth]
                                  ,[Gendor]
                                  ,[Address]
                                  ,[Phone]
                                  ,[Email]
                                  ,Countries.CountryName
                                  ,[ImagePath]
                              FROM [dbo].[People] INNER JOIN Countries
                                ON People.NationalityCountryID = Countries.CountryID;
                            ";
            SqlCommand command = new SqlCommand(QUERY, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }

            }
            catch (Exception e)
            {
                // !!!
            }
            finally
            {
                connection.Close();
            }
            return dataTable;


        }
        public static bool NationalNoExists(string NationalNo)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"SELECT 1 AS exist
                             FROM people
                             WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                found = reader.Read();
                reader.Close();
            }
            catch (Exception e)
            {
                // !!!
            }
            finally
            {
                connection.Close();
            }
            return found;
        }

        public static int? AddPerson(string nationalNo, string firstName, string secondName,
                    string thirdName, string lastName, DateTime dateOfBirth, int gendor,
                    string address, string phone, string email, int nationalityCountryID,
                    string imagePath)
        {
            int? personId = null;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"INSERT INTO [dbo].[People]
                           ([NationalNo]
                           ,[FirstName]
                           ,[SecondName]
                           ,[ThirdName]
                           ,[LastName]
                           ,[DateOfBirth]
                           ,[Gendor]
                           ,[Address]
                           ,[Phone]
                           ,[Email]
                           ,[NationalityCountryID]
                           ,[ImagePath])
                     VALUES(
                           @nationalNo,
                           @firstName,
                           @secondName,
                           @thirdName,
                           @lastName,
                           @dateOfBirth,
                           @gendor, 
                           @address,
                           @phone,
                           @email,
                           @nationalityCountryID,
                           @imagePath);
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@nationalNo", nationalNo);
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@secondName", secondName);
            
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@gendor", gendor);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@phone", phone);

            command.Parameters.AddWithValue("@nationalityCountryID", nationalityCountryID);
            

            if (thirdName == null)
            {
                command.Parameters.AddWithValue("@thirdName", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@thirdName", dateOfBirth);
            }

            if (email == null)
            {
                command.Parameters.AddWithValue("@email", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@email", email);
            }

            if (imagePath == null)
            {
                command.Parameters.AddWithValue("@imagePath", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@imagePath", imagePath);
            }

            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    personId = insertedID;
                }
            }
            catch (Exception e)
            {
                // ---
            }
            finally
            {
                connection.Close();
            }
            return personId;

        }



        public static bool UpdatePerson(Person person)
        {
            int affectedRows = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                UPDATE [dbo].[People]
                SET [NationalNo] = @nationalNo
                    ,[FirstName] = @firstName
                    ,[SecondName] = @secondName
                    ,[ThirdName] = @thirdName
                    ,[LastName] = @lastName
                    ,[DateOfBirth] = @dateOfBirth
                    ,[Gendor] = @gendor
                    ,[Address] = @address
                    ,[Phone] = @phone
                    ,[Email] = @email
                    ,[NationalityCountryID] = @nationalityCountryID
                    ,[ImagePath] = @imagePath
                WHERE personId = @personId";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@nationalNo", person.NationalNo);
            command.Parameters.AddWithValue("@firstName", person.FirstName);
            command.Parameters.AddWithValue("@secondName", person.SecondName);
            if (person.ThirdName == null)
                command.Parameters.AddWithValue("@thirdName", DBNull.Value);
            else
                command.Parameters.AddWithValue("@thirdName", person.ThirdName);



            if (person.Email == null)
                command.Parameters.AddWithValue("@email", DBNull.Value);
            else
                command.Parameters.AddWithValue("@email", person.Email);


            if (person.ImagePath == null)
                command.Parameters.AddWithValue("@imagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@imagePath", person.ImagePath);


            command.Parameters.AddWithValue("@lastName", person.LastName);
            command.Parameters.AddWithValue("@dateOfBirth", person.DateOfBirth);
            command.Parameters.AddWithValue("@gendor", (int)person.Gendor);
            command.Parameters.AddWithValue("@address", person.Address);
            command.Parameters.AddWithValue("@phone", person.Phone);
            command.Parameters.AddWithValue("@nationalityCountryID", person.NationalityCountryID);
            command.Parameters.AddWithValue("@personId", person.PersonID);

            try
            {
                connection.Open();
                affectedRows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                // !!!
            }
            finally
            {
                connection.Close();
            }

            return affectedRows > 0;
        }


    }
}
