<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UserConfirm.aspx.cs" Inherits="Honda.Admin.UserConfirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h2 table="center">User Details</h2>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="login_id" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
               
                <asp:BoundField DataField="user_name" HeaderText="Name" />
                <asp:BoundField DataField="user_ph" HeaderText="Contact No." />
                <asp:BoundField DataField="user_district" HeaderText="District" />
                <asp:BoundField DataField="user_place" HeaderText="Place" />
                <asp:BoundField DataField="user_email" HeaderText="Email" />
                <asp:BoundField DataField="status" HeaderText="Status" />
                <asp:CommandField DeleteText="Confirm" HeaderText="Action" ShowDeleteButton="true" />
            </Columns>



       </asp:GridView>
</asp:Content>
