using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DK
{
    class SqlSupportMethods
    {
        public static SqlConnection cnn;

        //Kết nối Sql Server với Visual Studio
        public static void Connect()
        {
            try
            {
                cnn = new SqlConnection(@"Data Source=K;Initial Catalog=DoDucKhai;Integrated Security=True");

                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error!");
            }
        }

        //Ngắt kết nối Sql Server với Visual Studio
        public static void Disconnect()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
                cnn = null;
            }
        }

        //Lấy dữ liệu từ Database theo truy vấn
        public static DataTable GetData(string cmd)
        {
            Connect();

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd, cnn);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }

            return null;
        }

        //Thực thi truy vấn với truy vấn dạng string
        public static void Execute(string cmd)
        {
            Connect();

            try
            {
                new SqlCommand(cmd, cnn).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        //Thực thi truy vấn với truy vấn dạng SqlCommand
        public static void Execute(SqlCommand cmd)
        {
            Connect();
            cmd.Connection = cnn;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        //Lấy giá trị từ Database thỏa mãn truy vấn
        public static string GetValue(string cmd)
        {
            Connect();

            string id = string.Empty;

            try
            {
                SqlDataReader reader = new SqlCommand(cmd, cnn).ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetValue(0).ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }

            return id;
        }
    }
}
