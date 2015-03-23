<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadEmployees.aspx.cs" Inherits="TempWebApp.ReadEmployees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <ul>
    <%
        TempWebApp.DAC.Read objRead = new TempWebApp.DAC.Read();
        List<Properties.Employee> Employees = objRead.Employee();
        foreach (Properties.Employee Emp in Employees) 
        {%>
           <li> <%=Emp.Name %> - <a href="DeleteEmployee?id=<%=Emp.IdEmployee %>">Delete</a></li>
        <%}%>
        </ul>

</body>
</html>
