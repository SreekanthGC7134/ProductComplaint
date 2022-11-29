<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMain.Master" AutoEventWireup="true" CodeBehind="Complaint.aspx.cs" Inherits="Honda.User.Complaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center">Register A Complaint</h1>
    <table align="center">
        <tr>
            <td>
                Product
            </td>
            <td>
               
                        <asp:DropDownList ID="DropDownList2" runat="server" Style="margin-left: 8px" Width="148px">
                        </asp:DropDownList></td>
        </tr>
        <tr>
                    <td>
                        <asp:Label ID="msg" runat="server" Text="Your Complaint" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="complaint" runat="server" Style="margin-left: 6px; margin-top: 8px;" Width="442px" Height="94px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" /></td>
                </tr>


    </table>
</asp:Content>
