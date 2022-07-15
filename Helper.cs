using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lems
{
    static class Helper
    {
        public static string ConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["LemsDBCn"].ConnectionString;
            }
        }

        //SqlConnection con = new SqlConnection(Helper.ConnectionString);
    }

    
    public class Connection
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;

        public void connection()
        {
            con = new SqlConnection(Helper.ConnectionString);
            con.Open();
        }

        public void sendData(string SQL)
        {
            try
            {
                connection();
                cmd = new SqlCommand(SQL, con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void getData(string SQL)
        {
            try
            {
                connection();
                sda = new SqlDataAdapter(SQL, con);


            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }

    

}
