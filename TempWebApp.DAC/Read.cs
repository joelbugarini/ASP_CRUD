using Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TempWebApp.DAC
{
    public class Read
    {
       DBInfo Info = new DBInfo();
       public List<Employee> Employee()
       {
           string casa = Info.sqlSet();
           using (SqlConnection con = new SqlConnection(Info.sqlSet()))
           {
               List<Employee> Employees = new List<Employee>();
               SqlCommand cmd = new SqlCommand();               
               cmd = new SqlCommand("SelectEmployee");
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Connection = con;

               con.Open();

               try
               {
                   using (SqlDataReader reader = cmd.ExecuteReader())
                   {
                       // Loop through each record.
                       while (reader.Read())
                       {
                           Employee tmp = new Employee();

                           tmp.IdEmployee = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdEmployee;
                           tmp.Name = (reader.GetValue(1) != DBNull.Value) ? Convert.ToString(reader.GetValue(1)) : tmp.Name;
                           tmp.LastName = (reader.GetValue(2) != DBNull.Value) ? Convert.ToString(reader.GetValue(2)) : tmp.LastName;
                           tmp.Salary = (reader.GetValue(3) != DBNull.Value) ? Convert.ToDecimal(reader.GetValue(3)) : tmp.Salary;
                           tmp.BirthDate = (reader.GetValue(4) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(4)) : tmp.BirthDate;                           

                           Employees.Add(tmp);
                       }
                   }
                   return Employees;
               }
               catch (SqlException ex)
               {
                   return null;
               }
           }
       }
    }
}
