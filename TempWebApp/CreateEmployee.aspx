<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateEmployee.aspx.cs" Inherits="TempWebApp.CreateEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
          <asp:TextBox ID="Name" runat="server"></asp:TextBox>
        </p>
        <p>
           <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
        </p>
        <p>
           <asp:TextBox ID="Salary" runat="server"></asp:TextBox>
        </p>
        <p>
           <asp:TextBox ID="BirthDate" runat="server"></asp:TextBox>
        </p>
     <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
    </div>
    </form>
    
</body>
</html>
