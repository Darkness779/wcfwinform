using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QLVS_1911060974_Hai
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
            connStringBuilder.InitialCatalog = "QLSV_1911060974";
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
        public int InsertClass1(Class1 p)
        {
            try
            {
                comm.CommandText = "INSERT INTO hai VALUES(@Masv, @Tensv, @Hocphan, @Makhoa, @Malop)";
                comm.Parameters.AddWithValue("Masv", p.Masv);
                comm.Parameters.AddWithValue("Tensv", p.Tensv);
                comm.Parameters.AddWithValue("Hocphan", p.Hocphan);
                comm.Parameters.AddWithValue("Makhoa", p.Makhoa);
                comm.Parameters.AddWithValue("Malop", p.Malop);

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

        public int UpdateClass1(Class1 p)
        {
            try
            {
                comm.CommandText = "UPDATE hai SET Tensv=@Tensv, Hocphan=@Hocphan, Makhoa=@Makhoa, Malop=@Malop  WHERE Masv=@Masv";
                comm.Parameters.AddWithValue("Masv", p.Masv);
                comm.Parameters.AddWithValue("Tensv", p.Tensv);
                comm.Parameters.AddWithValue("Hocphan", p.Hocphan);
                comm.Parameters.AddWithValue("Makhoa", p.Makhoa);
                comm.Parameters.AddWithValue("Malop", p.Malop); ;

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

        public int DeleteClass1(Class1 p)
        {
            try
            {
                comm.CommandText = "DELETE hai WHERE Masv=@Masv";
                comm.Parameters.AddWithValue("Masv", p.Masv);
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

        public Class1 GetClass1(Class1 p)
        {
            Class1 Class1 = new Class1();
            try
            {
                comm.CommandText = "SELECT * FROM hai WHERE Masv=@Masv";
                comm.Parameters.AddWithValue("Masv", p.Masv);
                comm.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Class1.Masv = Convert.ToInt32(reader[0]);
                    Class1.Tensv = reader[1].ToString();
                    Class1.Hocphan = reader[2].ToString();
                    Class1.Makhoa = reader[3].ToString();
                    Class1.Malop = reader[4].ToString();
                }
                return Class1;
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

        public List<Class1> GetAllClass1s()
        {
            List<Class1> Class1L = new List<Class1>();
            try
            {
                comm.CommandText = "SELECT * FROM hai";
                comm.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Class1 Class1 = new Class1()
                    {
                        Masv = Convert.ToInt32(reader[0]),
                        Tensv = reader[1].ToString(),
                        Hocphan = reader[2].ToString(),
                        Makhoa = reader[3].ToString(),
                        Malop = reader[4].ToString(),
                    };
                    Class1L.Add(Class1);
                }
                return Class1L;
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
    }
}
