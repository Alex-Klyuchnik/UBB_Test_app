using System;
using System.Data.SqlClient;
using ServerServiceApp.Entities;

namespace ServerServiceApp.DB
{
    public class DBEdit
    {
        internal string SQLConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Projects\UBB_Test_app\UBB_Test_app\DB\localDB.accdb;Persist Security Info=True";
        
        internal bool AddCity (City addedCity)
        {
            string cityAddSQL = @"insert into Cities (CityName, Region, Country, Attribute) values (?,?,?,?)";
            try
            {
                using (SqlConnection connection = new SqlConnection(SQLConnStr))
                {
                    using (SqlCommand command = new SqlCommand(cityAddSQL,connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("CityName", addedCity.Name);
                        command.Parameters.AddWithValue("Region", addedCity.Region);
                        command.Parameters.AddWithValue("Country", addedCity.Country);
                        command.Parameters.AddWithValue("Attribute", addedCity.Attrib);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        internal bool RemoveCity (int id)
        {
            string cityRemoveSQL = string.Concat("delete from Cities where Id=", id.ToString());
            try
            {
                using (SqlConnection connection = new SqlConnection(SQLConnStr))
                {
                    using (SqlCommand command = new SqlCommand(cityRemoveSQL,connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        internal bool EditCity (int id, City changedCity)   
        {
            string cityEditSQL = string.Concat("update Cities set CityName=@CityName, Region=@Region, Country=@Country, Attribute=@Attribute where Id=",id.ToString());
            try
            {
                using (SqlConnection connection = new SqlConnection(SQLConnStr))
                {
                    using (SqlCommand command = new SqlCommand(cityEditSQL,connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@CityName", changedCity.Name);
                        command.Parameters.AddWithValue("@Region", changedCity.Region);
                        command.Parameters.AddWithValue("@Country", changedCity.Country);
                        command.Parameters.AddWithValue("@Attribute", changedCity.Attrib);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false; 
            }
            
        }

        internal string MaxPop ()  
        {
            SqlDataReader reader;
            using (SqlConnection connection = new SqlConnection(SQLConnStr))
            {
                object[] objReader = new object[3];
                string result = "";
                string maxPopSQL = "select CityId, count(*) from People group by CityId";
                using (SqlCommand command = new SqlCommand(maxPopSQL, connection))
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int columnsNumber = reader.GetValues(objReader);
                        for (int i = 0; i < columnsNumber; i++)
                        {
                            result = string.Concat(result, objReader[i].ToString(), " ");
                        }
                    }
                    reader.Close();
                    return result;
                }
            }
        }

        internal bool Report ()     //TODO Change method type; Implement
        {
            return false;
        }

        internal bool AddPerson(Person addedPerson)     
        {
            string personAddSQL = @"insert into People (CityId, FIO) values (?,?)";
            try
            {
                using (SqlConnection connection = new SqlConnection(SQLConnStr))
                {
                    using (SqlCommand command = new SqlCommand(personAddSQL,connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("CityId", addedPerson.CityId);
                        command.Parameters.AddWithValue("FIO", addedPerson.FIO);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            
        }

        internal bool RemovePerson(int id)
        {
            string personRemoveSQL = string.Concat("delete from People where Id=", id.ToString());
            try
            {
                using (SqlConnection connection = new SqlConnection(SQLConnStr))
                {
                    using (SqlCommand command = new SqlCommand(personRemoveSQL,connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);   
                return false;    
            }
        }

        internal bool EditPerson(int id, Person changedPerson)      
        {
            string personEditSQL = string.Concat("update People set CityId=@CityId, FIO=@FIO where Id=",id.ToString());
            try
            {
                using (SqlConnection connection = new SqlConnection(SQLConnStr))
                {
                    using (SqlCommand command = new SqlCommand(personEditSQL,connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@CityId", changedPerson.CityId);
                        command.Parameters.AddWithValue("@FIO", changedPerson.FIO);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;    
            }
        }

        internal string ResolveCityName (int id)
        {
            string cityName="";
            string resolveNameSQL = string.Concat("select CityName from Cities where Id=", id.ToString());
            try
            {
                using (SqlConnection connection = new SqlConnection(SQLConnStr))
                {
                    using (SqlCommand command = new SqlCommand(resolveNameSQL,connection))
                    {
                        connection.Open();
                        cityName = command.ExecuteScalar().ToString();
                    }   
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cityName;
        }
    }
}