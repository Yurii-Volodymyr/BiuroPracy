<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Layout.Master" CodeBehind="Employees.aspx.cs" Inherits="BiuroPracy.Employees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link href="Styles/AddEmployee.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" Runat="Server">
    <h4>Lista pracowników</h4>
  <div style="margin: 0 auto; width:90%">
    <asp:GridView  ID="gvEmployees"  runat="server" AutoGenerateColumns="False"   CssClass= "table table-bordered table-striped"  AlternatingRowStyle-CssClass="alt">
      
        <Columns>
            <asp:BoundField DataField="Email" HeaderText="Email"></asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="Imię"></asp:BoundField>
            <asp:BoundField DataField="Surename" HeaderText="Nazwisko"></asp:BoundField>
            <asp:BoundField DataField="DateOfBirth" HeaderText="Data urodzin"></asp:BoundField>
        </Columns>
    </asp:GridView>
   </div>
</asp:Content>
