<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Honda.Admin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product View</title>
  
</head>
<body style="background-color:aqua">
    <form id="form1" runat="server">
        <h1 style="text-align:center">Product</h1>
              
      <table align="center">
        <tr>
            <td>Product</td>
            <td><asp:TextBox ID="product" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
              <td>Amount</td>
              <td><asp:TextBox ID="amount" runat="server"></asp:TextBox></td>
            
          </tr>
          <tr>
              
              <td><asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /></td>
            </tr>
      </table>
        <table align="center">
            <tr><td><h2>List Of Products</h2></td></tr>

            <tr>
                <td>
                   
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="product_id" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting">
                        <Columns>
                            <asp:BoundField DataField="product_name" HeaderText="Product" />
                            <asp:BoundField DataField="product_amount" HeaderText="Amount" />
                            <asp:CommandField HeaderText="Edit" ShowEditButton="true"/>
                            <asp:CommandField HeaderText="Delete" ShowDeleteButton="true"/>
                        </Columns>
                    </asp:GridView>
                    </td>
            </tr>
        </table>
    </form>
</body>
</html>
