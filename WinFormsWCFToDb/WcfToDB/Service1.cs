using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfToDB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public Service1()
        {
            ConnectToDb();
        }
        SqlConnection conn;
        SqlCommand comm;

        SqlConnectionStringBuilder connStringBuilder;

        void ConnectToDb()
        {
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "LAPTOP-067SJILE\\SQLEXPRESS";
            connStringBuilder.InitialCatalog = "WCF";
            connStringBuilder.Encrypt = true;
            connStringBuilder.TrustServerCertificate = true;
            connStringBuilder.ConnectTimeout = 30;
            connStringBuilder.AsynchronousProcessing = true;
            connStringBuilder.MultipleActiveResultSets = true;
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());
            comm = conn.CreateCommand();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int InsertPerson(Person p)
        {
            try
            {
                comm.CommandText = "INSERT INTO TPerson VALUES(@ID, @Name, @Age)";
                comm.Parameters.AddWithValue("ID", p.ID);
                comm.Parameters.AddWithValue("Name", p.Name);
                comm.Parameters.AddWithValue("Age", p.Age);

                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception) 
            {
                throw;
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }    
            }
        }

        public int UpdatePerson(Person p)
        {
            try
            {
                comm.CommandText = "UPDATE TPerson SET Name=@Name, Age=@Age WHERE ID=@ID";
                comm.Parameters.AddWithValue("ID", p.ID);
                comm.Parameters.AddWithValue("Name", p.Name);
                comm.Parameters.AddWithValue("Age", p.Age);

                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public int DeletePerson(Person p)
        {
            try
            {
                comm.CommandText = "DELETE TPerson WHERE ID=@ID";
                comm.Parameters.AddWithValue("ID", p.ID);
                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public Person GetPerson(Person p)
        {
            Person person = new Person();
            try
            {
                comm.CommandText = "SELECT * FROM TPerson WHERE ID=@ID";
                comm.Parameters.AddWithValue("ID", p.ID);
                comm.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    person.ID = Convert.ToInt32(reader[0]);
                    person.Name = reader[1].ToString();
                    person.Age = Convert.ToInt32(reader[2]);
                }
                return person;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public List<Person> GetAllPersons()
        {
        List<Person> personL = new List<Person>();
            try
            {
                comm.CommandText = "SELECT *FROM TPerson";
                comm.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    Person person = new Person()
                    {
                        ID = Convert.ToInt32(reader[0]),
                        Name = reader[1].ToString(),
                        Age = Convert.ToInt32(reader[2]),
                    };
                    personL.Add(person);
                }    
                return personL;
            }
            catch(Exception)
            {
                throw;
            }
            finally { if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
