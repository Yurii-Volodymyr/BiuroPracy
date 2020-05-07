<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddPlaceOfResidenceControl.ascx.cs" Inherits="BiuroPracy.Controls.AddPlaceOfResidenceControl" %>
<div class="form-group">
    <label class="contorl-label col-sm-2">Ulica:</label>
    <div class="col-sm-10">
        <asp:TextBox ID="txtStreet" class="form-control" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="tfvStreet" ControlToValidate="txtStreet" runat="server" ErrorMessage="Wymagane pole"></asp:RequiredFieldValidator>
    </div>
</div>
<div class="form-group">
    <label class="contorl-label col-sm-2">Kod pocztowy:</label>
    <div class="col-sm-10">
        <asp:TextBox ID="txtZipCode" class="form-control" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="tfvZipCode" ControlToValidate="txtZipCode" runat="server" ErrorMessage="Wymagane pole"></asp:RequiredFieldValidator>
    </div>
</div>
<div class="form-group">
    <label class="contorl-label col-sm-2">Miasto:</label>
    <div class="col-sm-10">
        <asp:DropDownList ID="ddlCity" class="form-control" runat="server"></asp:DropDownList>
         <asp:RequiredFieldValidator ID="tfvCity" ControlToValidate="ddlCity" runat="server" ErrorMessage="Wymagane pole"></asp:RequiredFieldValidator>
    </div>
</div>
<div class="form-group">
    <label class="contorl-label col-sm-2">Kraj:</label>
    <div class="col-sm-10">
        <asp:DropDownList ID="ddlCountry" class="form-control" runat="server"></asp:DropDownList>
         <asp:RequiredFieldValidator ID="tfvCountry" ControlToValidate="ddlCountry" runat="server" ErrorMessage="Wymagane pole"></asp:RequiredFieldValidator>
    </div>
</div>