using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp6.lobsterClasses
{
    class lobsterClass
    {
        public string companyName { get; set; }
        public long quantity { get; set; }
        public long price { get; set; }
        public string id { get; set; }
        public string date { get; set; }
        public string country { get; set; }
        static string myconnstring = ConfigurationManager.ConnectionStrings["DBapplication.Properties.Settings.ConnectionString"].ConnectionString;

        public DataTable select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM [حصر الاستاكوزا]";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            } catch(Exception ex)
            {

            } finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable calcSum()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT [اسم الشركة],  SUM([الكمية بالكيلو]) as [الكمية الكلية بالكيلو], SUM([المبلغ]) as [المبلغ الكلي] FROM [حصر الاستاكوزا] GROUP BY [اسم الشركة]; ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool insert(lobsterClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO [حصر الاستاكوزا] VALUES(@companyName, @quantity, @price, @id, @date, @country); ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                cmd.Parameters.AddWithValue("@companyName", c.companyName);
                cmd.Parameters.AddWithValue("@quantity", c.quantity);
                cmd.Parameters.AddWithValue("@price", c.price);
                cmd.Parameters.AddWithValue("@id", c.id);
                cmd.Parameters.AddWithValue("@date", c.date);
                cmd.Parameters.AddWithValue("@country", c.country);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool update(lobsterClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE [حصر الاستاكوزا] SET [اسم الشركة]=@companyName, [الكمية بالكيلو]=@quantity, المبلغ=@price, [رقم المطالبة]=@id, التاريخ=@date, الدولة=@country WHERE [رقم المطالبة]=@id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@companyName", c.companyName);
                cmd.Parameters.AddWithValue("@quantity", c.quantity);
                cmd.Parameters.AddWithValue("@price", c.price);
                cmd.Parameters.AddWithValue("@id", c.id);
                cmd.Parameters.AddWithValue("@date", c.date);
                cmd.Parameters.AddWithValue("@country", c.country);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool delete(lobsterClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM [حصر الاستاكوزا] WHERE [رقم المطالبة]=@id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", c.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        
        public bool confirmPassword(string password)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "SELECT COUNT(*) FROM [passwords] WHERE [user password] = @password" ;
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                Int32 rows = (Int32)cmd.ExecuteScalar();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool confirmAdminPassword(string password)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "SELECT COUNT(*) FROM [passwords] WHERE [admin password] = @password";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                Int32 rows = (Int32)cmd.ExecuteScalar();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool updatePassword(string newPassword)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE passwords SET [user password]=@newPassword WHERE id=@id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.Parameters.AddWithValue("@id", 1);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

    }
}
