<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMain.Master" AutoEventWireup="true" CodeBehind="Complaintstatus.aspx.cs" Inherits="Honda.User.Coplaintstatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center">Complaint Status</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="product_name" HeaderText="Product Name" />
            <asp:BoundField DataField="complaint" HeaderText="Your Complaint" />
            <asp:BoundField DataField="date" HeaderText="Date" />
            <asp:BoundField DataField="status" HeaderText="Admin Status" />
        </Columns>
    </asp:GridView>
</asp:Content>
