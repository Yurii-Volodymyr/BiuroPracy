<%@ Page Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="BiuroPracy.AddEmployee" %>
<%@ Register TagPrefix="employee" TagName="AddEmployeeControl" Src="Controls/AddEmployeeControl.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/AddEmployee.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <h4>Dodawanie pracowników</h4>
    <asp:Panel ID ="panelInfo" runat="server">
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    </asp:Panel>
    <div class="bodyForm">
        <employee:AddEmployeeControl Id="crtlAddEmployee" runat="server" />
       
        <div class="form-group">
            <asp:Button ID="btnsave" CssClass="btn-primary" runat="server" Text="Zapisz" OnClick="btnsave_Click1"  />
           
        </div>
        <div class="form-group">
            <asp:Button ID="btnTestHibertate" runat="server" Text="TestHibertate" OnClick="btnTestNHibertate_Click" />
        </div>
    </div>
</asp:Content>