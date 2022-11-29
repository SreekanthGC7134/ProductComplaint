<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="Honda.Admin.ViewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> Customers</h1>
    <p>&nbsp;</p>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <p style="background-color:aquamarine">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="login_id" >
<Columns>
    <asp:BoundField DataField="user_name" HeaderText="Name" />
    <asp:BoundField DataField="user_ph" HeaderText="Contact Number" />
    <asp:BoundField DataField="user_district" HeaderText="District" />
    <asp:BoundField DataField="user_place" HeaderText="Place" />
    <asp:BoundField DataField="user_email" HeaderText="Email" />
     <asp:BoundField DataField="status" HeaderText="Status" />
</Columns>
</asp:GridView>
        </p>
        
</asp:Content>
