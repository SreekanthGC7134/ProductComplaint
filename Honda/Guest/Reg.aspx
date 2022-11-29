<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="Honda.Guest.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2 style="text-align:center">Registration</h2>
      <table align="center">
          <tr>
            <td>Name</td>
             <td> <asp:TextBox ID="name" runat="server"></asp:TextBox></td>
          </tr>
          
          <tr>
              <td>Contact Number</td>
              <td> <asp:TextBox ID="phone" runat="server"></asp:TextBox></td>
          </tr>
          <tr>
              <td>Email</td>
              <td><asp:TextBox ID="email" runat="server"></asp:TextBox></td>
          </tr>
          <tr>
              <td>District</td>
              <td> <asp:TextBox ID="district" runat="server"></asp:TextBox></td>
          </tr>
          
          <tr>
              <td>Place</td>
              <td> <asp:TextBox ID="place" runat="server"></asp:TextBox></td>
          </tr>
          <tr>
              <td>Password</td>
              <td>
                  <asp:TextBox ID="pwd" inputtype="password" runat="server"></asp:TextBox></td>
          </tr>
        
          <tr>
             <td> <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /></td>
              <td><asp:Button ID="Button2" runat="server" Text="Cancel" /></td>
          </tr>
      </table>
    </form>
</body>
</html>
