<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Reply.aspx.cs" Inherits="Honda.Admin.Reply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <h3 align="center">Reply</h3>
    <table align="center">
        <tr>
            <td>Product-Name</td>
            <td>
                <asp:TextBox ID="txtreply" runat="server"></asp:TextBox></td>
        </tr>
        
        <tr>
            <td>
                <asp:Button ID="btnreg"  runat="server" Text="Register" OnClick="Button1_Click1" /></td>
        </tr>
    </table>
</asp:Content>
