<%@ Page Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddPlaceOfResidence.aspx.cs" Inherits="BiuroPracy.AddPlaceOfResidence" %>
<%@ Register TagPrefix="place" TagName="AddPlaceOfResidenceControl" Src="Controls/AddPlaceOfResidenceControl.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/AddEmployee.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <h4>Dodawanie miejsca zamieszkania</h4>
    <div class="bodyForm">
        <place:AddPlaceOfResidenceControl Id="crtlAddPlaceOfResidence" runat="server" />
        <div class="form-group">
            <asp:Button ID="btnsave" CssClass="btn-primary" runat="server" Text="Zapisz" />
        </div>
    </div>
</asp:Content>