<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ViewComplaint.aspx.cs" Inherits="Honda.Admin.ViewComplaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 style="text-align:center">View Complaint</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting1" DataKeyNames="complaintId" >
        <Columns>
            <asp:BoundField DataField="customer_name" HeaderText="Customer Name" />
            <asp:BoundField DataField="product_name" HeaderText="Product Name" />
            <asp:BoundField DataField="complaint" HeaderText="Complaint" />
            <asp:BoundField DataField="date" HeaderText="Date" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:CommandField DeleteText="Confirm" HeaderText="Confirmation" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
