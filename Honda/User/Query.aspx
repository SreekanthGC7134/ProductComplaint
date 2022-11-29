<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMain.Master" AutoEventWireup="true" CodeBehind="Query.aspx.cs" Inherits="Honda.User.Query" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h3 align="center">Querry Registartion</h3>
    <table align="center">
         <tr>
            <td>Choose your product</td>
            <td>
                <asp:DropDownList ID="ddlproduct" runat="server"></asp:DropDownList>
                </td>
               
        </tr>
        <tr>
            <td>Enter your Querry</td>
            <td>
                <asp:TextBox ID="txtqry" runat="server" Style="margin-left: 6px; margin-top: 8px;" Width="442px" Height="94px"></asp:TextBox>
        </tr>
        
        <tr>
            <td>
                <asp:Button ID="btnreg" runat="server" Text="Register" OnClick="btnreg_Click"/></td>
        </tr>
    </table>
</asp:Content>
