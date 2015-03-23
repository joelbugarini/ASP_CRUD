using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Properties;
using TempWebApp.DAC;

namespace TempWebApp
{
    public partial class CreateEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Create objCreate = new Create();

            Employee emp = new Employee();
            emp.Name = Name.Text;
            emp.LastName = LastName.Text;
            emp.Salary = Convert.ToDecimal(Salary.Text);
            emp.BirthDate = Convert.ToDateTime(BirthDate.Text);

            objCreate.Record(emp);
        }
    }
}