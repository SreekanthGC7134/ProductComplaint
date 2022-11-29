<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ViewQuerry.aspx.cs" Inherits="Honda.Admin.ViewQuerry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center">View Querry</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="customer_name" HeaderText="Customer Name" />
            <asp:BoundField DataField="product_name" HeaderText="Product Name" />
            <asp:BoundField DataField="date" HeaderText="Date" />
            <asp:BoundField DataField="querry" HeaderText="Querry" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:HyperLinkField DataNavigateUrlFields="querryId" DataNavigateUrlFormatString="Reply.aspx?eid=[1]" HeaderText="Reply" Text="Go" />
        </Columns>
    </asp:GridView>
</asp:Content>
