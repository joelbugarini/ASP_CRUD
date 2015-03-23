using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Properties;
using System.Data;
using System.Data.SqlClient;

namespace TempWebApp.DAC
{
    public class Create
    {
        DBInfo Info = new DBInfo();
        public string Record(Employee obj)
        {
            using(SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("CreateEmployee");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@LastName", obj.LastName);
                cmd.Parameters.AddWithValue("@Salary", obj.Salary);
                cmd.Parameters.AddWithValue("@BirthDate", obj.BirthDate);
                cmd.Connection = con;

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    return "Success";
                }
                catch (SqlException ex) 
                {
                    return ex.Message;
                }
            }
            
        }
    }
}
