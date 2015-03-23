using Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TempWebApp.DAC
{
    public class Delete
    {
        DBInfo Info = new DBInfo();
        public string Record(int id)
        {
            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("DeleteEmployee");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
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
